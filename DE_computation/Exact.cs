using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_computation
{
    class Exact:Grid
    {
        internal double con;
        public Exact(int N, double x0, double y0, double X) :base(N, x0, X)
        {
            y = new double[N + 1];
            y[0] = y0;

            con = (y[0] - 1) / (y[0] * x[0]);

            if ((0 >= x0) && (0 <= X)) throw new DiscontinuityException("0");
            double x_dis = 1 / con;
            if ((x_dis >= x0) && (x_dis <= X)) throw new DiscontinuityException(x_dis.ToString("F"));

            for (int i = 1; i <= N; i++)
            {
                y[i] = 1 / (1 - x[i] * con);
            }
        }
    }
}
