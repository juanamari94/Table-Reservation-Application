using System;
using Data;
using WebApplication;
using WebApplication.Controllers;
using Business;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WebApplicationTests
{
    [TestClass]
    public class ReservationControllerTests
    {
        [TestMethod]
        public void IsReservationUnique_Test()
        {
            List<Reservation> bookings = new List<Reservation>();
            bookings.Add(new Reservation(0, DateTime.Now, 1, " ", " ", " ", " ", " ", " ", 1));
            bookings.Add(new Reservation(1, DateTime.Now.AddMinutes(90), 1, " ", " ", " ", " ", " ", " ", 1));
            bookings.Add(new Reservation(2, DateTime.Now.AddMinutes(45), 1, " ", " ", " ", " ", " ", " ", 1));

            PrivateObject o = new PrivateObject(typeof(ReservationController));
            bool b = Convert.ToBoolean(o.Invoke("IsReservationUnique", bookings[0], bookings[1]));

            b.Should().Be(true);
        }
    }
}
