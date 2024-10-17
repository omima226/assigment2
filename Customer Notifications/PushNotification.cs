﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Notifications
{
    internal class PushNotification:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
        }
    }
}
