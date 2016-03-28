using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Business.Tests
{
    [TestClass]
    public class BusinessTest
    {
        [TestMethod]
        public void Test_Validator_IsReservationUnique_True()
        {
            Reservation desiredBooking = new Reservation(0, DateTime.Now, 1, " ", " ", " ", " ", " ", " ", 1);

            List<Reservation> bookings = new List<Reservation>();
            bookings.Add(new Reservation(1, DateTime.Now.AddMinutes(90), 1, " ", " ", " ", " ", " ", " ", 1));
            bookings.Add(new Reservation(1, DateTime.Now.AddMinutes(180), 2, " ", " ", " ", " ", " ", " ", 1));

            bool result = (new Validator()).IsReservationUnique(desiredBooking, bookings);
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Test_Validator_IsReservationUnique_False()
        {
            Reservation desiredBooking = new Reservation(0, DateTime.Now, 1, " ", " ", " ", " ", " ", " ", 1);
            List<Reservation> bookings = new List<Reservation>();
            bookings.Add(new Reservation(0, DateTime.Now.AddMinutes(15), 1, " ", " ", " ", " ", " ", " ", 1));
            bookings.Add(new Reservation(0, DateTime.Now.AddMinutes(105), 1, " ", " ", " ", " ", " ", " ", 1));

            bool result = (new Validator()).IsReservationUnique(bookings[0], bookings);
            Assert.IsFalse(result);
        }
    }
}
