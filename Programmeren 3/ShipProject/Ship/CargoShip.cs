using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3
{
    class CargoShip : Ship
    {
        protected double worth { get; set; }

        public CargoShip()
        {
            this.worth = 0;
        }

        public CargoShip(int length, int width, string name, double worth)
        {
            this.length = length;
            this.width = width;
            this.name = name;
            this.worth = worth;
        }
    }
}
