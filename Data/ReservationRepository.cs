using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ReservationRepository : IDisposable
    {
        private ReservationDbContext dbContext;

        public ReservationRepository()
        {
            dbContext = new ReservationDbContext();
        }

        public List<Reservation> ObtainReservations()
        {
            return dbContext.Reservations.ToList();
        }

        public void InsertReservation(Reservation reservation)
        {
            dbContext.Reservations.Add(reservation);
            dbContext.SaveChanges();
        }

        public void UpdateReservation(Reservation reservation)
        {
            dbContext.Entry(reservation).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteReservation(Reservation reservation)
        {
            dbContext.Reservations.Remove(reservation);
            dbContext.SaveChanges();
        }

        public Reservation GetById(int id)
        {
            return dbContext.Reservations.SingleOrDefault(p => p.ReservationId == id);
        }

        public int GetRowCount()
        {
            
            return dbContext.Reservations.Count();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}