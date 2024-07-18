using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Car : IVehicle
    {
        public Car(string m, string mo, int y, int nu, string t) {
            Make = m; Model = mo; Year = y; NumberOfDoors = nu; Type = t;
        }

        public int NumberOfDoors { get; set; }
        public string Type { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year {  get; set; }

        public static void Drive(Car c) {
            Console.WriteLine("Driving the car...");
        }

        public static void DisplayInfo(Car c) {
            Console.WriteLine("Car Information: ");
            Console.WriteLine("Make: {0}", c.Make);
            Console.WriteLine("Model: {0}", c.Model);
            Console.WriteLine("Year: {0}", c.Year);
            Console.WriteLine("");
        }
    }
}
