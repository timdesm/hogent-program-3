using System;

namespace Programmeren_3
{
    class ShipProject
    {
        static void Main(String[] args)
        {
            Ship s1 = new CargoShip(120, 40, "Test cargo", 500000);
            Console.WriteLine(s1.ToString());
        }
    }
}
