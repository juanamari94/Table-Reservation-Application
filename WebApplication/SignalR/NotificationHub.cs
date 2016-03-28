﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApplication.SignalR
{
    public class NotificationHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        [HubMethodName("show")]
        public static void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            context.Clients.All.displayStatus();
        }
    }
}