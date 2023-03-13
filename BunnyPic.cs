using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    public class BunnyPic : ICummable
    {
        private double cummabilityFactor;

        public BunnyPic(double cummy)
        {
            cummabilityFactor = cummy;
        }

        public double Cum()
        {
            return cummabilityFactor * 1000;
        }
    }
}
