namespace DE_computation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Graphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Errors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.enter_N_end = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.enter_N_start = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.write_con = new System.Windows.Forms.Label();
            this.change_err = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.check_RK = new System.Windows.Forms.CheckBox();
            this.check_IEuler = new System.Windows.Forms.CheckBox();
            this.check_Euler = new System.Windows.Forms.CheckBox();
            this.plot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.enter_Y0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enter_N = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enter_Xmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_X0 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graphics)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Errors)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.enter_N_end);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.enter_N_start);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.write_con);
            this.splitContainer1.Panel2.Controls.Add(this.change_err);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.check_RK);
            this.splitContainer1.Panel2.Controls.Add(this.check_IEuler);
            this.splitContainer1.Panel2.Controls.Add(this.check_Euler);
            this.splitContainer1.Panel2.Controls.Add(this.plot);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.enter_Y0);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.enter_N);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.enter_Xmax);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.enter_X0);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 673);
            this.splitContainer1.SplitterDistance = 1052;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Graphics);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Errors);
            this.splitContainer2.Size = new System.Drawing.Size(1052, 673);
            this.splitContainer2.SplitterDistance = 443;
            this.splitContainer2.TabIndex = 0;
            // 
            // Graphics
            // 
            chartArea1.Name = "ChartArea1";
            this.Graphics.ChartAreas.Add(chartArea1);
            this.Graphics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Graphics.Legends.Add(legend1);
            this.Graphics.Location = new System.Drawing.Point(0, 24);
            this.Graphics.Name = "Graphics";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Exact";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Euler";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Euler Improved";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Runge-Kutta";
            this.Graphics.Series.Add(series1);
            this.Graphics.Series.Add(series2);
            this.Graphics.Series.Add(series3);
            this.Graphics.Series.Add(series4);
            this.Graphics.Size = new System.Drawing.Size(1052, 419);
            this.Graphics.TabIndex = 0;
            this.Graphics.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePlotsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // savePlotsToolStripMenuItem
            // 
            this.savePlotsToolStripMenuItem.Name = "savePlotsToolStripMenuItem";
            this.savePlotsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.savePlotsToolStripMenuItem.Text = "Save plot";
            this.savePlotsToolStripMenuItem.Click += new System.EventHandler(this.savePlotsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Errors
            // 
            chartArea2.Name = "ChartArea1";
            this.Errors.ChartAreas.Add(chartArea2);
            this.Errors.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "GTE";
            this.Errors.Legends.Add(legend2);
            this.Errors.Location = new System.Drawing.Point(0, 0);
            this.Errors.Name = "Errors";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "GTE";
            series5.Name = "Euler";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "GTE";
            series6.Name = "Euler Improved";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "GTE";
            series7.Name = "Runge-Kutta";
            this.Errors.Series.Add(series5);
            this.Errors.Series.Add(series6);
            this.Errors.Series.Add(series7);
            this.Errors.Size = new System.Drawing.Size(1052, 226);
            this.Errors.TabIndex = 0;
            this.Errors.Text = "chart1";
            // 
            // enter_N_end
            // 
            this.enter_N_end.Location = new System.Drawing.Point(119, 558);
            this.enter_N_end.Name = "enter_N_end";
            this.enter_N_end.Size = new System.Drawing.Size(74, 20);
            this.enter_N_end.TabIndex = 20;
            this.enter_N_end.Text = "32";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = " - ";
            // 
            // enter_N_start
            // 
            this.enter_N_start.Location = new System.Drawing.Point(15, 558);
            this.enter_N_start.Name = "enter_N_start";
            this.enter_N_start.Size = new System.Drawing.Size(74, 20);
            this.enter_N_start.TabIndex = 17;
            this.enter_N_start.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter the N range:";
            // 
            // write_con
            // 
            this.write_con.AutoSize = true;
            this.write_con.Location = new System.Drawing.Point(14, 456);
            this.write_con.Name = "write_con";
            this.write_con.Size = new System.Drawing.Size(137, 13);
            this.write_con.TabIndex = 14;
            this.write_con.Text = "Differential constant = -1,00";
            // 
            // change_err
            // 
            this.change_err.Location = new System.Drawing.Point(15, 603);
            this.change_err.Name = "change_err";
            this.change_err.Size = new System.Drawing.Size(178, 58);
            this.change_err.TabIndex = 13;
            this.change_err.Text = "Explore max_GTE to N dependence";
            this.change_err.UseVisualStyleBackColor = true;
            this.change_err.Click += new System.EventHandler(this.change_err_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Show approximate methods";
            // 
            // check_RK
            // 
            this.check_RK.AutoSize = true;
            this.check_RK.Checked = true;
            this.check_RK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_RK.Location = new System.Drawing.Point(15, 416);
            this.check_RK.Name = "check_RK";
            this.check_RK.Size = new System.Drawing.Size(86, 17);
            this.check_RK.TabIndex = 11;
            this.check_RK.Text = "Runge-Kuttu";
            this.check_RK.UseVisualStyleBackColor = true;
            this.check_RK.CheckedChanged += new System.EventHandler(this.plot_Draw);
            // 
            // check_IEuler
            // 
            this.check_IEuler.AutoSize = true;
            this.check_IEuler.Checked = true;
            this.check_IEuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_IEuler.Location = new System.Drawing.Point(15, 389);
            this.check_IEuler.Name = "check_IEuler";
            this.check_IEuler.Size = new System.Drawing.Size(97, 17);
            this.check_IEuler.TabIndex = 10;
            this.check_IEuler.Text = "Euler Improved";
            this.check_IEuler.UseVisualStyleBackColor = true;
            this.check_IEuler.CheckedChanged += new System.EventHandler(this.plot_Draw);
            // 
            // check_Euler
            // 
            this.check_Euler.AutoSize = true;
            this.check_Euler.Checked = true;
            this.check_Euler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Euler.Location = new System.Drawing.Point(15, 362);
            this.check_Euler.Name = "check_Euler";
            this.check_Euler.Size = new System.Drawing.Size(50, 17);
            this.check_Euler.TabIndex = 9;
            this.check_Euler.Text = "Euler";
            this.check_Euler.UseVisualStyleBackColor = true;
            this.check_Euler.CheckedChanged += new System.EventHandler(this.plot_Draw);
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(15, 253);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(178, 56);
            this.plot.TabIndex = 8;
            this.plot.Text = "Plot graphs";
            this.plot.UseVisualStyleBackColor = true;
            this.plot.Click += new System.EventHandler(this.plot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Y_0";
            // 
            // enter_Y0
            // 
            this.enter_Y0.Location = new System.Drawing.Point(15, 89);
            this.enter_Y0.Name = "enter_Y0";
            this.enter_Y0.Size = new System.Drawing.Size(138, 20);
            this.enter_Y0.TabIndex = 6;
            this.enter_Y0.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter N";
            // 
            // enter_N
            // 
            this.enter_N.Location = new System.Drawing.Point(15, 208);
            this.enter_N.Name = "enter_N";
            this.enter_N.Size = new System.Drawing.Size(138, 20);
            this.enter_N.TabIndex = 4;
            this.enter_N.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter X";
            // 
            // enter_Xmax
            // 
            this.enter_Xmax.Location = new System.Drawing.Point(15, 147);
            this.enter_Xmax.Name = "enter_Xmax";
            this.enter_Xmax.Size = new System.Drawing.Size(138, 20);
            this.enter_Xmax.TabIndex = 2;
            this.enter_Xmax.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter X_0";
            // 
            // enter_X0
            // 
            this.enter_X0.Location = new System.Drawing.Point(15, 33);
            this.enter_X0.Name = "enter_X0";
            this.enter_X0.Size = new System.Drawing.Size(138, 20);
            this.enter_X0.TabIndex = 0;
            this.enter_X0.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical solutions";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graphics)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Errors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphics;
        private System.Windows.Forms.DataVisualization.Charting.Chart Errors;
        private System.Windows.Forms.Button change_err;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_RK;
        private System.Windows.Forms.CheckBox check_IEuler;
        private System.Windows.Forms.CheckBox check_Euler;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enter_Y0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enter_N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enter_Xmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enter_X0;
        private System.Windows.Forms.Label write_con;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox enter_N_start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox enter_N_end;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

