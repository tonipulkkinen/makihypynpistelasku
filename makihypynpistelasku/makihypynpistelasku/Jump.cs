using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makihypynpistelasku
{
    class Jump
    {
        public string contenderName;
        public decimal jumpLenght;

        public decimal points1;
        public decimal points2;
        public decimal points3;
        public decimal points4;
        public decimal points5;
        public decimal pointsTotal;

        public decimal location1;
        public decimal location2;
        public decimal location3;
        public decimal location4;
        public decimal location5;
        public decimal WindAverage;
        int WindDirection = 0;

        //Constructors
        public Jump(string Name, decimal JumpLenght)
        {
            contenderName = Name;
            jumpLenght = JumpLenght;
        }

        public Jump(string Purpose, decimal Value1, decimal Value2, decimal Value3, decimal Value4, decimal Value5)
        {
            if (Purpose == "Points")
            {
                points1 = Value1;
                points2 = Value2;
                points3 = Value3;
                points4 = Value4;
                points5 = Value5;

                decimal[] scores = new[] { points1, points2, points3, points4, points5 };
                decimal min = scores.Min();
                decimal max = scores.Max();
                pointsTotal = (((points1 + points2 + points3 + points4 + points5) - min) - max);
            }
            if (Purpose == "Wind")
            {
                location1 = Value1;
                location2 = Value2;
                location3 = Value3;
                location4 = Value4;
                location5 = Value5;

                WindAverage = (location1 + location2 + location3 + location4 + location5) / 5;
                if (WindAverage < 0)
                {
                    WindDirection = -1;
                }
                if (WindAverage > 0)
                {
                    WindDirection = 1;
                }
            }            
        }
    }
}
