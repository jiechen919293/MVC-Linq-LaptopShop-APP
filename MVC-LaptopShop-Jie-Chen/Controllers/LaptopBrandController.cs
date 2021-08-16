using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_LaptopShop_Jie_Chen.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_LaptopShop_Jie_Chen.Controllers
{
    public class LaptopBrandController : Controller
    {
        public Database db = new Database();
        public IActionResult Index()
        {
            return View();
        }

        //1.Show the TOP 2 expensive laps
        public IActionResult LaptopTopExpensiveTwo()
        {
            var laps = db.Laptops.OrderBy(lap => lap.Price).TakeLast(2).ToList();
            return View(laps);
        }

        //2.Show the Top 3 cheap laps
        public IActionResult LaptopTopCheapThree()
        {
            var laps = db.Laptops.OrderBy(lap => lap.Price).Take(3).ToList();
            return View(laps);
        }

        //3.Affordable Laptops with input of max price
        public IActionResult AffordableLaptops()
        {
            return View(db.Laptops);
        }
        [HttpPost]
        public IActionResult AffordableLaptops(double Price)
        {
            var laps = db.Laptops.Where(lap => lap.Price <= Price).ToList();
            return View(laps);
        }

        //4.Compare Laptops
        public IActionResult CompareLaptops()
        {
            ViewBag.id1 = new SelectList(db.Laptops, "Id", "Model");
            ViewBag.id2 = new SelectList(db.Laptops, "Id", "Model");
            return View();
        }
        [HttpPost]
        public IActionResult CompareLaptops(int id1, int id2)
        {
            ViewBag.id1 = new SelectList(db.Laptops, "Id", "Model");
            ViewBag.id2 = new SelectList(db.Laptops, "Id", "Model");
            var laps = db.Laptops.Where(lap => lap.Id == id1 || lap.Id == id2).ToList();
            return View(laps);
        }

        //5.select brand with year/price order
        public IActionResult SelectLaptopsBrand()
        {
            List<string> OrderBy = new List<string> { "Price", "Year" };
            ViewBag.OrderChoices = new SelectList(OrderBy);
            ViewBag.Name = new SelectList(db.Brands, "Name", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult SelectLaptopsBrand(string Name, string OrderChoices)
        {
            List<string> OrderBy = new List<string> { "Price", "Year" };
            ViewBag.OrderChoices = new SelectList(OrderBy);
            var laps = db.Laptops.Where(lap => lap.Brand.Name == Name).ToList();
            ViewBag.Name = new SelectList(db.Brands, "Name", "Name");
            switch (OrderChoices)
            {
                case "Price": return View(laps.OrderBy(lap => lap.Price).ToList());

                case "Year": return View(laps.OrderBy(lap => lap.Year).ToList());

                default: return View(laps);
            }

        }

        //6.select brand with year/price filter
        public IActionResult SelectLaptopsWithFilter()
        {
            List<string> OrderBy = new List<string> { "Price", "Year" };
            ViewBag.OrderChoices = new SelectList(OrderBy);
            ViewBag.Name = new SelectList(db.Brands, "Name", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult SelectLaptopsWithFilter(string Name, string OrderChoices, int number)
        {
            List<string> OrderBy = new List<string> { "Price", "Year" };
            ViewBag.OrderChoices = new SelectList(OrderBy);
            var laps = db.Laptops.Where(lap => lap.Brand.Name == Name).ToList();
            ViewBag.Name = new SelectList(db.Brands, "Name", "Name");
            switch (OrderChoices)
            {
                case "Price": return View(laps.Where(lap => lap.Price <= number).OrderBy(lap => lap.Price).ToList());

                case "Year": return View(laps.Where(lap => lap.Year >= number).OrderBy(lap => lap.Year).ToList());

                default: return View(laps);
            }

        }

        //7.Show All Laptops in Brand
        public IActionResult LaptopsInBrand()
        {
            var LaptopsByBrand = db.Laptops.GroupBy(c => c.Brand.Name);
            var dict = LaptopsByBrand.ToDictionary(g => g.Key, g => g.ToList());
            return View(dict);
        }

        //8.Add new laptop 
        public IActionResult AddNewLaptops()
        {
            ViewBag.Name = new SelectList(db.Brands, "Name", "Name");
            return View(db.Laptops);
        }
        [HttpPost]
        public IActionResult AddNewLaptops(string Name, string laptype, double Price, int Num)
        {
            ViewBag.Name = new SelectList(db.Brands, "Name", "Name");
            var brand = db.Brands.FirstOrDefault(b => b.Name == Name);
            var newLaptops = brand.MakeLaptops(laptype, Price, Num, 2021);
            db.Laptops.AddRange(newLaptops);
            return View(brand.Laptops);
        }

        //9.Add new brand
        public IActionResult AddNewBrand()
        {

            return View(db.Brands);
        }
        [HttpPost]
        public IActionResult AddNewBrand(string Brand)
        {
            var newBrand = new Brand(Brand);
            db.Brands.Add(newBrand);

            return View(db.Brands);
        }
    }
}




