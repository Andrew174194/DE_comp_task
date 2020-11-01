using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_computation
{
    public partial class Form1 : Form
    {
        Exact exact;
        Euler eu;
        Euler_Impr ie;
        Runge_Kutta rk;

        double x_0;
        double y_0;
        double x_max;
        int N;

        private bool N_mode = false;

        public Form1()
        {
            InitializeComponent();
        }

        //MVC for functions graphs and local errors

        //Contoller
        private void plot_Click(object sender, EventArgs e)
        {
            try
            {
                x_0 = Double.Parse(enter_X0.Text);
                y_0 = Double.Parse(enter_Y0.Text);
                x_max = Double.Parse(enter_Xmax.Text);
                N = Int32.Parse(enter_N.Text);

                if (x_max <= x_0) throw new WrongDataException("X must to be greater than x_0");
                if (N <= 0) throw new WrongDataException("N must be greater than 0");

                plot_Computation();
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are available to enter",  "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(WrongDataException exc)
            {
                MessageBox.Show(exc.Message, "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Something does wrong...\n" + exp.Message, "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Model
        private void plot_Computation()
        {
            try
            {
                exact = new Exact(N, x_0, y_0, x_max);
                eu = new Euler(N, x_0, y_0, x_max);
                ie = new Euler_Impr(N, x_0, y_0, x_max);
                rk = new Runge_Kutta(N, x_0, y_0, x_max);
                eu.LTE(exact);
                ie.LTE(exact);
                rk.LTE(exact);

                plot_Draw(null, null);
            }
            catch (DiscontinuityException ex)
            {
                MessageBox.Show("There is a point of discontinuity in the x interval (x = " + ex.Message + ")",
                                    "Discontinuity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something does wrong...\n" + exp.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //View
        private void plot_Draw(object sender, EventArgs e)
        {
            try
            {
                Graphics.Series[0].Points.DataBindXY(exact.x, exact.y);
                write_con.Text = "Differential constant = " + exact.con.ToString("F");

                Graphics.Series[1].Points.DataBindXY(eu.x, eu.y);
                Errors.Series[0].Points.DataBindXY(eu.x, eu.er);
                Graphics.Series[1].Enabled = check_Euler.Checked;
                Errors.Series[0].Enabled = check_Euler.Checked;

                Graphics.Series[2].Points.DataBindXY(ie.x, ie.y);
                Errors.Series[1].Points.DataBindXY(ie.x, ie.er);
                Graphics.Series[2].Enabled = check_IEuler.Checked;
                Errors.Series[1].Enabled = check_IEuler.Checked;

                Graphics.Series[3].Points.DataBindXY(rk.x, rk.y);
                Errors.Series[2].Points.DataBindXY(rk.x, rk.er);
                Graphics.Series[3].Enabled = check_RK.Checked;
                Errors.Series[2].Enabled = check_RK.Checked;

                Graphics.ChartAreas[0].AxisX.Minimum = x_0;
                Errors.ChartAreas[0].AxisX.Minimum = x_0;
                Graphics.ChartAreas[0].AxisX.Maximum = x_max;
                Errors.ChartAreas[0].AxisX.Maximum = x_max;

                change_err.Text = "Explore max_LTE to N dependence";
                N_mode = false;
            }
            catch(Exception exp)
            {
                MessageBox.Show("Something wrong with graphic drawing\n" + exp.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void change_err_Click(object sender, EventArgs e)
        {
            if (N_mode == false)
            {
                try
                {
                    int N_start = Int32.Parse(enter_N_start.Text);
                    int N_end = Int32.Parse(enter_N_end.Text);

                    if (N_start <= 0) throw new WrongDataException("Start N must be greater than 0");
                    if (N_end <= N_start) throw new WrongDataException("Upper bound N have to be greater than start N");
                    
                    double[] max_er_eu = new double[N_end - N_start + 1];
                    double[] max_er_ie = new double[N_end - N_start + 1];
                    double[] max_er_rk = new double[N_end - N_start + 1];

                    double[] N_ = new double[N_end - N_start + 1];

                    int index = 0;

                    for (int i = N_start; i <= N_end; i++)
                    {
                        Exact exact_N = new Exact(i, x_0, y_0, x_max);
                        Euler eu_N = new Euler(i, x_0, y_0, x_max);
                        eu_N.LTE(exact_N);
                        max_er_eu[index] = eu_N.max_LTE();
                        Euler_Impr ie_N = new Euler_Impr(i, x_0, y_0, x_max);
                        ie_N.LTE(exact_N);
                        max_er_ie[index] = ie_N.max_LTE();
                        Runge_Kutta rk_N = new Runge_Kutta(i, x_0, y_0, x_max);
                        rk_N.LTE(exact_N);
                        max_er_rk[index] = rk_N.max_LTE();
                        N_[index] = i;
                        index++;
                    }

                    Errors.ChartAreas[0].AxisX.Minimum = N_start;
                    Errors.ChartAreas[0].AxisX.Maximum = N_end;

                    Errors.Series[0].Points.DataBindXY(N_, max_er_eu);
                    Errors.Series[1].Points.DataBindXY(N_, max_er_ie);
                    Errors.Series[2].Points.DataBindXY(N_, max_er_rk);

                    N_mode = true;
                    change_err.Text = "Back to LTE to x dependence";

                }
                catch (DiscontinuityException ex)
                {
                    MessageBox.Show("There is a point of discontinuity in the x interval (x = " + ex.Message + ")",
                                        "Discontinuity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (WrongDataException exp)
                {
                    MessageBox.Show(exp.Message, "Wrong data", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Only integer numbers are allowed to enter", "Error", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Something does wrong...\n" + exp.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Errors.ChartAreas[0].AxisX.Minimum = x_0;
                Errors.ChartAreas[0].AxisX.Maximum = x_max;

                Errors.Series[0].Points.DataBindXY(eu.x, eu.er);
                Errors.Series[1].Points.DataBindXY(ie.x, ie.er);
                Errors.Series[2].Points.DataBindXY(rk.x, rk.er);
                change_err.Text = "Explore max_LTE to N dependence";
                N_mode = false;
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            plot_Click(sender, e);
        }

        //menuStrip functions
        private void savePlotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save plot as picture ...";
                sfd.Filter = "*.png|*.png;|*.jpg|*.jpg";
                sfd.AddExtension = true;
                sfd.FileName = "Graphic_Solutions";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1: Graphics.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                        case 2: Graphics.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
                    }
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program computes graphs for differential equation\n" +
                             "y' = (y^2 - y)/x\n" +
                             "by numerical and analytical solutions.\n\n" +
                             "The upper graph constantly shows the exact solution and Euler,\n" +
                             "Improved Euler, and Runge - Kuttu methods optionally.\n\n" + 
                             "You can save graphs plot as .png or .jpq in File->Save plot menu.", "Help");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This C# program was wrote as a Differential\n" +
                            "equation computational assignment.\n\n" +
                            "Created by Innopolis University BS19_02 student\n" + 
                            "Khoroshavin Andrey\n October 2020", "About");
        }
    }
}
