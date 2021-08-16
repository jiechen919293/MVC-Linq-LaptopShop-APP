using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_LaptopShop_Jie_Chen.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public Brand Brand { get; set; }
        public Laptop(int id, string model, double price, int year, Brand brand)
        {
            Id = id;
            Model = model;
            Price = price;
            Year = year;
            Brand = brand;
        }
    }
}
