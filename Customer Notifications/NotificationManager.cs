using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Notifications
{
    public class NotificationManager
    {
        private INotification _notification;
        public NotificationManager(INotification notification)
        {
            _notification = notification;
        }
        public void Notify(string message)
        {
            _notification.Send(message);
        }
    }
}
