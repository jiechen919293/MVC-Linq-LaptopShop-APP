using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_LaptopShop_Jie_Chen.Models
{
    public class Database
    {
        public List<Laptop> Laptops { get; set; }
        public List<Brand> Brands { get; set; }
        public Database()
        {
            Laptops = new List<Laptop>();
            Brands = new List<Brand>();

            #region //Creat basic brands and add to List
            var apple = new Brand("Apple");
            var benq = new Brand("Benq");
            var asus = new Brand("Asus");
            Brands.Add(apple);
            Brands.Add(benq);
            Brands.Add(asus);
            #endregion

            #region //Creat basic laptops and add to List
            var mac128 = new Laptop(1, "Mac128", 1999.99, 2017, apple);
            Laptops.Add(mac128);
            apple.Laptops.Add(mac128);
            var mac256 = new Laptop(2, "Mac256", 2499.99, 2018, apple);
            Laptops.Add(mac256);
            apple.Laptops.Add(mac256);
            var macPro = new Laptop(3, "MacPro", 2599.99, 2020, apple);
            Laptops.Add(macPro);
            apple.Laptops.Add(macPro);
            var benq128 = new Laptop(4, "Benq128", 1199.99, 2017, benq);
            Laptops.Add(benq128);
            benq.Laptops.Add(benq128);
            var benq256 = new Laptop(5, "Benq256", 1299.99, 2018, benq);
            Laptops.Add(benq256);
            benq.Laptops.Add(benq256);
            var benqPro = new Laptop(6, "BenqPro", 1399.99, 2019, benq);
            Laptops.Add(benqPro);
            benq.Laptops.Add(benqPro);
            var asus128 = new Laptop(7, "Asus128", 1499.99, 2017, asus);
            Laptops.Add(asus128);
            asus.Laptops.Add(asus128);
            var asus256 = new Laptop(8, "Asus256", 1599.99, 2018, asus);
            Laptops.Add(asus256);
            asus.Laptops.Add(asus256);
            var asusPro = new Laptop(9, "AsusPro", 1699.99, 2020, asus);
            Laptops.Add(asusPro);
            asus.Laptops.Add(asusPro);
            var asusMini = new Laptop(10, "AsusMini", 899.99, 2021, asus);
            Laptops.Add(asusMini);
            asus.Laptops.Add(asusMini);
            var macMini = new Laptop(11, "MacMini", 999.99, 2021, apple);
            Laptops.Add(macMini);
            apple.Laptops.Add(macMini);
            #endregion


        }
    }
}
