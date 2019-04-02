using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class Coordinates
    {
        public double x;
        public double y;

        public Coordinates(double x, double y)
        {
            this.y = y;
            this.x = x;
        }

        public Coordinates(Random randomNumberGenerator)
        {
            this.x = randomNumberGenerator.NextDouble();
            this.y = randomNumberGenerator.NextDouble();
        }


    }
}
