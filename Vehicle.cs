using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_Midterm_Review_2
{
    public abstract class Vehicle
    {
        string _make;

        public Vehicle(string make)
        {
            _make = make;
        }

        public string Make { get => _make; set => _make = value; }

        public override string ToString()
        {
            return $"{GetType().Name} - {Make}";
        }

    } // class

} // Vehicle

