﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace HelpDesk
{
    public class notificationHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}