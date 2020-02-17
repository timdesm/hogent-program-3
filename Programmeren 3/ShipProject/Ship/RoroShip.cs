using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3
{
    class RoroShip : CargoShip 
    {
        protected int cars { get; set; }
        protected int trucks { get; set; }

        public RoroShip(int length, int width, string name, double worth, int cars, int trucks)
        {
            this.length = length;
            this.width = width;
            this.name = name;
            this.worth = worth;
            this.cars = cars;
            this.trucks = trucks;
        }
    }
}
