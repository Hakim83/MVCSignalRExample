using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MVCSignalRExample
{
    public class RefreshHub : Hub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<RefreshHub>();
        public static void Refresh()
        {
            hubContext.Clients.All.refresh();
        }
    }
}