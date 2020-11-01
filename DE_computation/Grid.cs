using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_computation
{
    abstract class Grid
    {
        internal double[] x;
        internal double[] y;

        protected double h;

        protected Grid(int N, double x0, double X)
        {
            h = (X - x0) / N;

            x = new double[N + 1];

            x[0] = x0;

            for (int i = 1; i <= N; i++)
            {
                x[i] = x[i - 1] + h;
            }
        }
    }
}
