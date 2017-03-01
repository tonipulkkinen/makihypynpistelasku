using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makihypynpistelasku
{
    public class Jump
    {
        public string contenderName;
        public decimal jumpLenght;
        public int criticalPoint;

        private decimal _points1;
        private decimal _points2;
        private decimal _points3;
        private decimal _points4;
        private decimal _points5;
        public decimal pointsTotal;

        private decimal _location1;
        private decimal _location2;
        private decimal _location3;
        private decimal _location4;
        private decimal _location5;
        public decimal windAverage;

        //Constructors
        public Jump(string Name, decimal JumpLenght, int CriticalPoint,
            decimal Value1, decimal Value2, decimal Value3, decimal Value4, decimal Value5,
            decimal Value6, decimal Value7, decimal Value8, decimal Value9, decimal Value10)
        {
            contenderName = Name;
            jumpLenght = JumpLenght;
            criticalPoint = CriticalPoint;
            _points1 = Value1;
            _points2 = Value2;
            _points3 = Value3;
            _points4 = Value4;
            _points5 = Value5;
            _location1 = Value6;
            _location2 = Value7;
            _location3 = Value8;
            _location4 = Value9;
            _location5 = Value10;

            decimal[] scores = new[] { _points1, _points2, _points3, _points4, _points5 };
            decimal min = scores.Min();
            decimal max = scores.Max();
            pointsTotal = (((_points1 + _points2 + _points3 + _points4 + _points5) - min) - max);

            windAverage = (_location1 + _location2 + _location3 + _location4 + _location5) / 5;
        }

        //Properties

        //Methods
        public void CriticalPointCheck()
        {
            if (jumpLenght >= criticalPoint)
            {
                pointsTotal += 60 + (jumpLenght - criticalPoint) * 1.8m;
            }
            else
            {
                pointsTotal -= (criticalPoint - jumpLenght) * 1.8m;
            }
        }
    }
}
