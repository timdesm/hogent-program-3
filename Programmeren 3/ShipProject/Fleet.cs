using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3.ShipProject
{
    class Fleet
    {
        protected Dictionary<String, Ship> _ships = new Dictionary<string, Ship>();
        protected string name { get; set; }


        public Fleet(string name)
        {
            this.name = name;
        }
        

    }
}
