using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3.ShipShit
{
    class ContainerShip : CargoShip
    {
        protected int capacity { get; set; }

        public ContainerShip(int length, int width, string name, double worth, int capacity)
        {
            this.length = length;
            this.width = width;
            this.name = name;
            this.worth = worth;
            this.capacity = capacity;
        }
    }
}
