using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_computation
{
    class Runge_Kutta:Num_methods
    {
        private double k_1, k_2, k_3, k_4;

        public Runge_Kutta(int N, double x0, double y0, double X):base(N, x0, X)
        {
            y = new double[N + 1];
            y[0] = y0;

            for (int i = 0; i < N; i++)
            {
                k_1 = f(x[i], y[i]);
                k_2 = f(x[i] + h / 2, y[i] + h / 2 * k_1);
                k_3 = f(x[i] + h / 2, y[i] + h / 2 * k_2);
                k_4 = f(x[i] + h, y[i] + h * k_3);
                y[i + 1] = y[i] + h / 6 * (k_1 + 2 * k_2 + 2 * k_3 + k_4);
            }
        }
    }
}
