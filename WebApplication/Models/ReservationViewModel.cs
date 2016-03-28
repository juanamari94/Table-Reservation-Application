using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ReservationViewModel
    {
        public int ReservationId { get; set; }
        public DateTime Date { get; set; }
        public int GuestsAmount { get; set; }
        public string Observations { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public int TableNumber { get; set; }
    }
}