using System;
using Business;
using Data;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace WebService.Tests
{
    [TestClass]
    public class WebServiceTest
    {
        // constructor

        public WebServiceTest()
        {
            List<Reservation> reservations = new List<Reservation> { 
                
                new Reservation(0, DateTime.Now, 1, " ", " ", " ", " ", " ", " ", 1),
                new Reservation(1, DateTime.Now.AddMinutes(90), 2, " ", " ", " ", " ", " ", " ", 2),
                new Reservation(2, DateTime.Now.AddMinutes(180), 3, " ", " ", " ", " ", " ", " ", 3),
                
            };

            Mock<ReservationRepository> mockReservationRepository = new Mock<ReservationRepository>();
            mockReservationRepository.Setup(mr => mr.ObtainReservations()).Returns(reservations);

            mockReservationRepository.Setup(mr => mr.GetById(It.IsAny<int>())).Returns((int i) => reservations.Find(x => x.ReservationId == i));
            mockReservationRepository.Setup(mr => mr.InsertReservation(It.IsAny<Reservation>())).Callback<Reservation>(r => reservations.Add(r));
            mockReservationRepository.Setup(mr => mr.UpdateReservation(It.IsAny<Reservation>())).Callback<Reservation>(r =>
            {
                foreach(Reservation k in reservations)
                {
                    if(k.ReservationId == r.ReservationId)
                    {
                        k.Date = r.Date;
                        k.GuestsAmount = r.GuestsAmount;
                        k.FirstName = r.FirstName;
                        k.LastName = r.LastName;
                        k.PhoneNumber = r.PhoneNumber;
                        k.SaleChannel = r.SaleChannel;
                        k.TableNumber = r.TableNumber;
                        k.EMail = r.EMail;
                        k.Observations = r.Observations;
                    }
                }
                
            });

            mockReservationRepository.Setup(mr => mr.DeleteReservation(It.IsAny<Reservation>())).Callback<Reservation>(r =>
            {

                reservations.RemoveAt(reservations.FindIndex(x => x.ReservationId == r.ReservationId));

            });

            mockReservationRepository.Setup(mr => mr.GetRowCount()).Returns((int i) => reservations.Count);

            // this.mockReservationRepository = mockReservationRepository.Object; ????
        }

        [TestMethod]
        public void Test_GetById()
        {

        }


    }
}
