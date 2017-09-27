﻿using Horizon.Logic;
using Horizon.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Horizon.MVC.Controllers
{
    public class HomeController : Controller
    {
        private LogicFacade book = new LogicFacade();

        public ActionResult Index()
        {
            IEnumerable<Flight> flights = new List<Flight>();

            return View(flights);
        }

        [HttpPost]
        public ActionResult Index(Flight flight)
        {
            //book.flightDestinationAndArrival(flight);

            return RedirectToAction("AvailableFlights");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AvailableFlights(string startLoc, string destLoc, DateTime startSearch, DateTime endSearch, int numberOFPassengers)
        {
            //IEnumerable<Booking> bookings = book.GetAllFlights(startLoc, destLoc, startSearch, endSearch, numberOFPassengers);

            return View(bookings);
        }

        public ActionResult BookingInfo()
        {
            IEnumerable<Booking> booking = new List<Booking>();

            return View(booking);
        }

    }
}