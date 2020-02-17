using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3
{
    class CruiseShip : Ship
    {
        protected int passengers { get; set; }

        public CruiseShip(int length, int width, string name, int passengers)
        {
            this.length = length;
            this.width = width;
            this.name = name;
            this.passengers = passengers;
        } 
    }
}
