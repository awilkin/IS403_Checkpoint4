using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Basically, we're really awesome. We like music, and so do you if you're here. Obviously. ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us! Call 999-999-9999. Or email us at blowout@test.com";

            return View();
        }

        public ActionResult Rentals()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Instrument(string name, string condition)
        {
            ViewBag.InstrumentName = name;
            ViewBag.Condition = condition;
        
            if (ViewBag.InstrumentName == "Trumpet")
            {
                if (ViewBag.Condition == "Used")
                {
                    ViewBag.Price = "$25 a month";
                    ViewBag.NewPrice = "$55 a month";
                    ViewBag.UsedPrice = "$25 a month";
                }
                else
                {
                    ViewBag.Price = "$55 a month";
                    ViewBag.NewPrice = "$55 a month";
                    ViewBag.UsedPrice = "$25 a month";
                }
            }
            if (ViewBag.InstrumentName == "Trombone")
            {
                if (ViewBag.Condition == "Used")
                {
                    ViewBag.Price = "$35 a month";
                    ViewBag.NewPrice = "$60 a month";
                    ViewBag.UsedPrice = "$35 a month";
                }
                else
                {
                    ViewBag.Price = "$60 a month";
                    ViewBag.NewPrice = "$60 a month";
                    ViewBag.UsedPrice = "$35 a month";
                }
            }
            if (ViewBag.InstrumentName == "Tuba")
            {
                if (ViewBag.Condition == "Used")
                {
                    ViewBag.Price = "$50 a month";
                    ViewBag.NewPrice = "$70 a month";
                    ViewBag.UsedPrice = "$55 a month";
                }
                else
                {
                    ViewBag.Price = "$70 a month";
                    ViewBag.NewPrice = "$70 a month";
                    ViewBag.UsedPrice = "$55 a month";
                }
            }
            if (ViewBag.InstrumentName == "Flute")
            {
                if (ViewBag.Condition == "Used")
                {
                    ViewBag.Price = "$25 a month";
                    ViewBag.NewPrice = "$40 a month";
                    ViewBag.UsedPrice = "$25 a month";
                }
                else
                {
                    ViewBag.Price = "$40 a month";
                    ViewBag.NewPrice = "$40 a month";
                    ViewBag.UsedPrice = "$25 a month";
                }
            }
            if (ViewBag.InstrumentName == "Clarinet")
            {
                if (ViewBag.Condition == "Used")
                {
                    ViewBag.Price = "$27 a month";
                    ViewBag.NewPrice = "$35 a month";
                    ViewBag.UsedPrice = "$27 a month";
                }
                else
                {
                    ViewBag.Price = "$35 a month";
                    ViewBag.NewPrice = "$35 a month";
                    ViewBag.UsedPrice = "$27 a month";
                }
            }
            if (ViewBag.InstrumentName == "Saxophone")
            {
                if (ViewBag.Condition == "Used")
                {
                    ViewBag.Price = "$30 a month";
                    ViewBag.NewPrice = "$42 a month";
                    ViewBag.UsedPrice = "$30 a month";
                }
                else
                {
                    ViewBag.Price = "$42 a month";
                    ViewBag.NewPrice = "$42 a month";
                    ViewBag.UsedPrice = "$30 a month";
                }
            }
            return View();
        }
    }
}