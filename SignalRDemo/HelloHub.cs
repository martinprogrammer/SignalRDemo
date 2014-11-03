using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace SignalRDemo
{
    public class HelloHub : Hub
    {
        public void SayHello()
        {
            Clients.All.hello("Hello World");
            Thread.Sleep(1000);
            Clients.All.hello("This is me coming back from sleep");
            Thread.Sleep(1000);
            Clients.All.hello("Monday morning - new week all over again");
            Thread.Sleep(1000);
            Clients.All.hello("Neeed to turn the heating off");

        }

        public void SayGoodbye()
        {
            Clients.All.hello("GoodbyeNow");
        }
    }
}