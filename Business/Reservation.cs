using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime Date { get; set; }
        public int GuestsAmount { get; set; }
        public string Observations { get; set; }
        public string SaleChannel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public int TableNumber { get; set; }

        public Reservation()
        {
            // Parameter-less constructor.
        }

        public Reservation(int reservationId, DateTime date, int guestsAmount, string observations, string saleChannel, string firstName, string lastName, string phoneNumber, string eMail, int tableNumber)
        {
            this.ReservationId = reservationId;
            this.Date = date;
            this.GuestsAmount = guestsAmount;
            this.Observations = observations;
            this.SaleChannel = saleChannel;
            this.FirstName = firstName;
            this.LastName= lastName;
            this.PhoneNumber = phoneNumber;
            this.EMail = eMail;
            this.TableNumber = tableNumber;
        }

        public override string ToString()
        {
            return this.ReservationId + " - " + this.Date.ToString() + this.GuestsAmount + " - " + this.Observations + " - " + this.SaleChannel + " - " + this.FirstName + " - " + this.LastName + " - " + this.PhoneNumber + " - " + this.EMail + " - " + this.TableNumber;
        }
    }
}
