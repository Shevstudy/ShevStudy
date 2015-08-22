using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle2
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle2(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            this.driverIntensity = intensity;
            this.driverName = name;
        }
    }
}
