using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l05_ex1
{
    internal class Product
    {
        public Product(int id, string name, string category, string brand)
        {
            Id = id;
            Name = name;
            Category = category;
            Brand = brand;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
}
