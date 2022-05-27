using System;
using System.Collections.Generic;
using System.Text;

namespace progressions
{
    class GeometricProgression : Progression
    {
        private double a;
        private double q;

        public GeometricProgression(double a, double q)
        {
            this.a = a;
            this.q = q;
        }

        public override double SumElement(int k) => (a * (Math.Pow(q, k - 1) - 1)) / (q - 1);
    }
}
