using Factory_Method.Classes.Base;
using Factory_Method.Classes.Notification;
using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Classes.NotificationCreator
{
    public class SmsNotificationCreator : Factory_Method.Classes.Base.NotificationCreator
    {
        public override INotification CreateNotification() => new SmsNotification();
    }
}
