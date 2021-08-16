using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_LaptopShop_Jie_Chen.Models
{
    public class Brand
    {
        public string Name { get; set; }
        public List<Laptop> Laptops { get; set; }
        public Brand(string name)
        {
            Name = name;
            Laptops = new List<Laptop>();
        }
        public List<Laptop> MakeLaptops(string model, double price, int num, int year = 2021)
        {
            List<Laptop> labList = new List<Laptop>();
            for (int i = 1; i <= num; i++)
            {
                labList.Add(new Laptop(Laptops.Count() + i, model, price, year, this));
            }
            this.Laptops.AddRange(labList);
            return labList;
        }
    }
}
