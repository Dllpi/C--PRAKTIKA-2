using System;
using System.Collections.Generic;
using System.Text;

namespace progressions
{
    class ArithmeticProgression : Progression
    {
        private double a;
        private double d;

        public ArithmeticProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }

        public override double SumElement(int k) => ((2 * a) + d * (k - 1) / 2) * k;
    }
}
