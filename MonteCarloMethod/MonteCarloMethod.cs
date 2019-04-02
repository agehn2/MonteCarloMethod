using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class MonteCarloMethod
    {
        private Coordinates[] TestCollection(int size)
        {
            var coords = new Coordinates[size];
            var next = new Random();

            for (int i = 0; i < size; i++)
            {
                coords[i] = new Coordinates(next.NextDouble(), next.NextDouble());
            }

            return coords;
        }
        private double GetHypotenuse(Coordinates coord)
        {
            return Math.Sqrt(Math.Pow(coord.x, 2) + Math.Pow(coord.y, 2));
        }

        private double EstimatedPi(double overlapCircleAmount, double totalAmount)
        {
            return overlapCircleAmount / totalAmount * 4.0;
        }

        private int OverlapCircle(Coordinates[] coords)
        {
            int overlapTotal = 0;

            foreach (var coordinates in coords)
            {
                if (GetHypotenuse(coordinates) <= 1)
                {
                    overlapTotal += 1;
                }
            }

            return overlapTotal;
        }

        public double Estimate(int iterations)
        {
            Coordinates[] coordinates = TestCollection(iterations);
            int overlapTotal = OverlapCircle(coordinates);

            return EstimatedPi(overlapTotal, coordinates.Length);
        }

    }
}
