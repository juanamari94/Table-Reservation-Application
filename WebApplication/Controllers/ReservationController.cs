using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using WebApplication.SignalR_Data;
using Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ReservationController : Controller
    {
        public ActionResult ReservationHome()
        {
            return View();
        }

        public ActionResult ReservationCreate()
        {
            return View();
        }

        public ActionResult ReservationOK()
        {
            return View();
        }

        public ActionResult GetUpdate()
        {
            NotificationRepository updateRepo = new NotificationRepository();
            return PartialView("_NotificationsCount", updateRepo.GetData());
        }

        [HttpPost]
        public ActionResult ReservationRetrieve(ReservationViewModel reservationVM)
        {
            ReservationRepository repo;
            List<Reservation> bookings = new List<Reservation>();
            List<string> strList = new List<string>();
            strList.Add(reservationVM.Observations);
            strList.Add(reservationVM.FirstName);
            strList.Add(reservationVM.LastName);
            strList.Add(reservationVM.PhoneNumber);
            strList.Add(reservationVM.EMail);
            Reservation reservation = new Reservation(0,
                                                      reservationVM.Date,
                                                      reservationVM.GuestsAmount,
                                                      strList[0],
                                                      "Sitio Web",
                                                      strList[1],
                                                      strList[2],
                                                      strList[3],
                                                      strList[4],
                                                      reservationVM.TableNumber
                                                      );

            using(repo = new ReservationRepository())
            {
                bookings = repo.ObtainReservations();
            }

            Validator validate = new Validator();

            if (validate.IsReservationUnique(reservation, bookings) && validate.ValidateReservation(reservation))
            {
                using (ReservationRepository repository = new ReservationRepository())
                {
                    repository.InsertReservation(reservation);
                }

                return View("ReservationOK");
            }
            else
            {
                return View("ReservationError");
            }
        }

        [HttpPost]
        public ActionResult ReservationError()
        {
            return View("ReservationCreate");
        }
    }
}