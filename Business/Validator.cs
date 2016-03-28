using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Validator
    {
        public bool IsReservationUnique(Reservation desiredBooking, List<Reservation> bookings)
        {
            foreach (Reservation r in bookings)
            {
                if ((desiredBooking.Date >= r.Date && desiredBooking.Date < r.Date.AddMinutes(90)) && r.TableNumber == desiredBooking.TableNumber)
                    return false;
            }

            return true;
        }

        public bool ValidateReservation(Reservation booking)
        {
            return booking.Date >= DateTime.Now &&
                (booking.GuestsAmount >= 1 && booking.GuestsAmount <= 20) &&
                (booking.TableNumber >= 1 && booking.TableNumber <= 20);
        }
    }
}
