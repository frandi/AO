using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using AO.Web.Libs;

namespace AO.Web.Hubs
{
    public class AOHub : Hub
    {
        public void Shuffle(string[] participants)
        {
            Clients.All.startShuffle(participants);
        }

        public void Stop(string[] participants)
        {
            string winner = Randomizer.GetRandomArrayContent(participants);
            Clients.All.stopShuffle(winner);
        }
    }
}