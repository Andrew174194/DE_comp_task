using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_computation
{
    class Euler_Impr : Num_methods
    {
        private double k;
        public Euler_Impr(int N, double x0, double y0, double X) : base(N, x0, X)
        {
            y = new double[N + 1];
            y[0] = y0;

            for (int i = 0; i < N; i++)
            {
                k = f(x[i], y[i]);
                y[i + 1] = y[i] + h / 2 * k + h / 2 * f(x[i] + h, y[i] + h * k);
            }
        }
    }
}
