using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makihypynpistelasku
{
    class Wind
    {
        decimal location1;
        decimal location2;
        decimal location3;
        decimal location4;
        decimal location5;
        decimal WindAverage;
        int WindDirection = 0;

        //Constructors
        public Wind (decimal Location1, decimal Location2, decimal Location3, decimal Location4, decimal Location5)
        {
            location1 = Location1;
            location2 = Location2;
            location3 = Location3;
            location4 = Location4;
            location5 = Location5;

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
