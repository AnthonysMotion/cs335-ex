using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Motorcycle : IVehicle
    {
        public Motorcycle(string m, string mo, int y, double e)
        {
            Make = m; Model = mo; Year = y; EngineSize = e;
        }

        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public static void Ride(Motorcycle c)
        {
            Console.WriteLine("Riding the motorcycle...");
        }

        public static void DisplayInfo(Motorcycle m)
        {
            Console.WriteLine("Motorcycle Information: ");
            Console.WriteLine("Make: {0}", m.Make);
            Console.WriteLine("Model: {0}", m.Model);
            Console.WriteLine("Year: {0}", m.Year);
            Console.WriteLine("");
        }
    }
}