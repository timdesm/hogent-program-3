using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3
{
    class Ship
    {
        protected int length { get; set; }
        protected int width { get; set; }
        protected string name { get; set; }

        

        public Ship()
        {
            this.length = 0;
            this.width = 0;
            this.name = "Default";
        }

        public Ship(int length, int width, string name)
        {
            this.length = length;
            this.width = width;
            this.name = name;
        }

        public override string ToString()
        {
           return  "Ship: " + this.name + " (" + this.length + "x" + this.width + ")";
        }
    }
}
