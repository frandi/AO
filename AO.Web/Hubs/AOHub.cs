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
        private List<string> _participants;

        public AOHub()
        {
            _participants = new List<string>();
        }

        public void AddParticipant(string participant)
        {
            _participants.Add(participant);
            Clients.All.addParticipant(participant);
        }

        public void ClearParticipants()
        {
            _participants.Clear();
            Clients.All.clearParticipants();
        }

        public string[] GetParticipants()
        {
            return _participants.ToArray();
        }

        public void Shuffle()
        {
            Clients.All.startShuffle();
        }

        public void Stop()
        {
            string winner = Randomizer.GetRandomArrayContent(_participants.ToArray());
            Clients.All.stopShuffle(winner);
        }
    }
}