using B2B_API.App_Start;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace B2B_API.signalr
{
    public class MyHub : Microsoft.AspNet.SignalR.Hub
    {
        public void Announce(string message)
        {
            Clients.All.Announce(GetListPayableBooking());
            //Clients.All.Announce(message);
        }

        public string GetListPayableBooking()
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return CMSService.ConvertDataSetToArray(bus.ActionBooking("{}"));
        }

        public void Announce2(string message)
        {
            Announce(message);
            //Clients.All.Announce(message);
        }

        public DateTime GetServerDateTime()
        {
            return DateTime.Now;
        }
    }
}