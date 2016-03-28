using Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ReservationDbContext>(null);

            modelBuilder.Entity<Reservation>().ToTable("Reservations");
            modelBuilder.Entity<Reservation>().Property(r => r.ReservationId);
            modelBuilder.Entity<Reservation>().Property(r => r.Date);
            modelBuilder.Entity<Reservation>().Property(r => r.GuestsAmount);
            modelBuilder.Entity<Reservation>().Property(r => r.Observations);
            modelBuilder.Entity<Reservation>().Property(r => r.SaleChannel);
            modelBuilder.Entity<Reservation>().Property(r => r.FirstName);
            modelBuilder.Entity<Reservation>().Property(r => r.LastName);
            modelBuilder.Entity<Reservation>().Property(r => r.PhoneNumber);
            modelBuilder.Entity<Reservation>().Property(r => r.EMail);
            modelBuilder.Entity<Reservation>().Property(r => r.TableNumber);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
