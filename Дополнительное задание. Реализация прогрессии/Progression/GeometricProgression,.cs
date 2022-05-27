using System;
using System.Collections.Generic;
using System.Text;

namespace Progression
{
    class GeometricProgression: Progression
    {
        private double b;
        private double q;

        public GeometricProgression(double b, double q)
        {
            this.b = b;
            this.q = q;
        }

        public override double GetElement(int k) => b * Math.Pow(q, k - 1);
    }
}
