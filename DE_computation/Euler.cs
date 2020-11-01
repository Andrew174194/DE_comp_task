using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_computation
{
    class Euler:Num_methods
    {
        public Euler(int N, double x0, double y0, double X):base(N, x0, X)
        {
            y = new double[N + 1];
            y[0] = y0;

            for (int i = 0; i < N; i++)
            {
                y[i + 1] = y[i] + h * f(x[i], y[i]);
            }

        }
    }
}
