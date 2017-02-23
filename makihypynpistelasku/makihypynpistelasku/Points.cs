using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makihypynpistelasku
{
    class Points
    {
        public decimal points1;
        public decimal points2;
        public decimal points3;
        public decimal points4;
        public decimal points5;
        public decimal pointsTotal;

        //Constructors
        public Points(decimal Points1, decimal Points2, decimal Points3, decimal Points4, decimal Points5)
        {
            points1 = Points1;
            points2 = Points2;
            points3 = Points3;
            points4 = Points4;
            points5 = Points5;

            decimal[] scores = new[] { points1, points2, points3, points4, points5 };
            decimal min = scores.Min();
            decimal max = scores.Max();
            pointsTotal = (((points1 + points2 + points3 + points4 + points5) - min) - max);
        }
    }
}
