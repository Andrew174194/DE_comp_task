using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_computation
{
    abstract class Num_methods : Grid
    {
        internal double[] er;

        protected Num_methods(int n, double x0, double X) : base(n, x0, X) {}

        protected double f(double x, double y)
        {
            return (y * y - y) / x;
        }

        internal void LTE(Exact e)
        {
            er = new double[y.Length];

            for (int i = 0; i < y.Length; i++)
            {
                er[i] = Math.Abs(e.y[i] - y[i]);
            }
        }

        internal double max_LTE()
        {
            double MAX = -1;
            for (int i = 0; i < er.Length; i++)
            {
                if (er[i] > MAX) MAX = er[i];
            }
            return MAX;
        }
    }
}
