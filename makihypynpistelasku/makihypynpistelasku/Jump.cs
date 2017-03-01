using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makihypynpistelasku
{
    public class Jump
    {
        public string _contenderName;
        public decimal _jumpLenght;
        public int _criticalPoint;

        private decimal _points1;
        private decimal _points2;
        private decimal _points3;
        private decimal _points4;
        private decimal _points5;
        public decimal _pointsTotal;

        private decimal _location1;
        private decimal _location2;
        private decimal _location3;
        private decimal _location4;
        private decimal _location5;
        public decimal _windAverage;

        //Constructors
        public Jump(string Name, decimal JumpLenght, int CriticalPoint,
            decimal Value1, decimal Value2, decimal Value3, decimal Value4, decimal Value5,
            decimal Value6, decimal Value7, decimal Value8, decimal Value9, decimal Value10)
        {
            _contenderName = Name;
            _jumpLenght = JumpLenght;
            _criticalPoint = CriticalPoint;
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
            _pointsTotal = (((_points1 + _points2 + _points3 + _points4 + _points5) - min) - max);

            _windAverage = (_location1 + _location2 + _location3 + _location4 + _location5) / 5;
        }

        //Properties

        //Methods
        public void CriticalPointCheck()
        {
            if (_jumpLenght >= _criticalPoint)
            {
                _pointsTotal += 60 + (_jumpLenght - _criticalPoint) * 1.8m;
            }
            else
            {
                _pointsTotal -= (_criticalPoint - _jumpLenght) * 1.8m;
            }
        }
        public void WindEffectCheck()
        {
            decimal WindEffect = _windAverage * (_criticalPoint - 36) / 20;
            if (WindEffect > 0)
            {
                if (WindEffect * 10 - Math.Floor(WindEffect * 10) >= 0.75m)
                {
                    _pointsTotal += (Math.Ceiling(WindEffect * 10) / 10) * 1.8m;
                }
                if (WindEffect * 10 - Math.Floor(WindEffect * 10) >= 0.25m && WindEffect / 10 - Math.Floor(WindEffect / 10) < 0.75m)
                {
                    _pointsTotal += (Math.Ceiling(WindEffect * 10 - 0.5m) / 10) * 1.8m;
                }
                if (WindEffect * 10 - Math.Floor(WindEffect * 10) < 0.25m)
                {
                    _pointsTotal += (Math.Floor(WindEffect * 10) / 10) * 1.8m;
                }
            }
            if (WindEffect < 0)
            {
                if (WindEffect / 10 - Math.Floor(WindEffect / 10) <= 0.75m)
                {
                    _pointsTotal += (Math.Ceiling(WindEffect * 10) / 10) * 1.8m;
                }
                if (WindEffect / 10 - Math.Floor(WindEffect / 10) <= 0.25m && WindEffect / 10 - Math.Floor(WindEffect / 10) > 0.75m)
                {
                    _pointsTotal += (Math.Ceiling(WindEffect * 10 - 0.5m) / 10) * 1.8m;
                }
                if (WindEffect / 10 - Math.Floor(WindEffect / 10) > 0.25m)
                {
                    _pointsTotal += (Math.Floor(WindEffect * 10) / 10) * 1.8m;
                }
            }
        }
    }
}
