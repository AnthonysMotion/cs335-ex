using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class MobilePhone
    {
        public MobilePhone() 
        {
            Brand = ""; Model = ""; StorageCapacity = 0; Ram = 0; DisplaySize = 0.0; Price = 0.0m; count++;
        }

        public MobilePhone(string b, string m, int sc, int r, double ds, decimal p)
        {
            Brand = b; Model = m; StorageCapacity = sc; Ram = r; DisplaySize = ds; Price = p; count++;
        }

        static int count = 0;
        public string Brand { get; set; }
        public string Model { get; set; }
        public int StorageCapacity { get; set; }
        public int Ram { get; set; }
        public double DisplaySize { get; set; }
        public decimal Price { get; set; }

        public static void PrintDetails(MobilePhone m)
        {
            Console.WriteLine("Mobile Phone {0} Details:", count);
            Console.WriteLine("Brand: {0}", m.Brand);
            Console.WriteLine("Model: {0}", m.Model);
            Console.WriteLine("Storage Capacity: {0} GB", m.StorageCapacity);
            Console.WriteLine("RAM: {0} GB", m.Ram);
            Console.WriteLine("Display Size: {0} inches", m.DisplaySize); 
            Console.WriteLine("Price: ${0}", m.Price);
            Console.WriteLine("");
        }
    }
}
