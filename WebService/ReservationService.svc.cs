using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Web.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using Data;
using Business;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservationService" in both code and config file together.
    public class ReservationService : IReservationService, IDisposable
    {
        ReservationRepository repo;

        public List<Business.Reservation> RequestReservationRetrieval()
        {
            string syncstring = WebConfigurationManager.AppSettings["SyncDate"];
            List<Business.Reservation> webReservations;
            DateTime syncdate;

            using (repo = new ReservationRepository())
            {
                webReservations = repo.ObtainReservations();
            }

            if (syncstring == "nil")
            {
                syncdate = DateTime.Now;
                ChangeSyncDate(DateTime.Now);
            }
            else
            {
                syncdate = Convert.ToDateTime(syncstring);
            }

            List<Business.Reservation> filteredReservations = new List<Business.Reservation>();

            foreach (Reservation r in webReservations)
            {
                if (r.Date <= DateTime.Now && r.Date >= syncdate)
                    filteredReservations.Add(r);

            }

            if(filteredReservations.Count() > 0)
                ChangeSyncDate(DateTime.Now);

            return filteredReservations;
        }

        private void ChangeSyncDate(DateTime date)
        {
            var configuration = WebConfigurationManager.OpenWebConfiguration("~");
            var section = (AppSettingsSection)configuration.GetSection("appSettings");
            section.Settings["SyncDate"].Value = date.ToString();
            configuration.Save();
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
