using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Configuration;
using System.Linq;
using System.Web;
using Business;
using WebApplication.SignalR;
using System.Data.SqlClient;

namespace WebApplication.SignalR_Data
{
    public class NotificationRepository
    {
        public NotificationInfo GetData()
        {
            int rowcounter = 0;
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ReservationDbContext"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT ReservationId from dbo.Reservations", connection))
                {
                    command.Notification = null;

                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == System.Data.ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        rowcounter++;
                    }


                    return new NotificationInfo { RowCount = rowcounter, Date = DateTime.Now };

                }
            }
        }
    
        public void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency dependency = (SqlDependency)sender;
            dependency.OnChange -= dependency_OnChange;

            if (e.Type == SqlNotificationType.Change)
            {
                NotificationHub.Show();
            }
        }
    }
}