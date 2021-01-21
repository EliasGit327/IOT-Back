using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace IOT_Back.Hubs
{
    public class DevicesHub : Hub
    {
        public async Task SendToEveryone(string message)
        {
            var postTest = new
            {
                message = message
            };
            await Clients.All.SendAsync("send", postTest);
        }
    }
}