using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makihypynpistelasku
{
    class Contender
    {
        public string name;
        public decimal jumpLenght;

        //Constructors
        public Contender(string Name, decimal JumpLenght)
        {
            name = Name;
            jumpLenght = JumpLenght;
        }
    }
}
