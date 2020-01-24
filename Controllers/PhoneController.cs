using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var Phone1 = new List<Phone>
            {
                new Phone {PhoneName = "Iphone 11", ScreenSize = 120, Manufacturer = "Apple", DateReleased = new DateTime(2019,12,02), MSRP = 120000},
                new Phone {PhoneName = "Samsung Galaxy S9", ScreenSize = 115, Manufacturer = "Samsung", DateReleased = new DateTime(2015,10,03), MSRP = 65000},
                new Phone {PhoneName = "One plus 6", ScreenSize = 100, Manufacturer = "One Plus", DateReleased = new DateTime(2019,02,01), MSRP = 90000},
            };
            return View(Phone1);
        }
    }
}