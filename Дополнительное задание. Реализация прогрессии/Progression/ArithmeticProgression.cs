using System;
using System.Collections.Generic;
using System.Text;

namespace Progression
{
    class ArithmeticProgression: Progression
    {
        private double a;
        private double d;

        public ArithmeticProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }

        public override double GetElement(int k) => a + d * (k - 1);
    }
}
