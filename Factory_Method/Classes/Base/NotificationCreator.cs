using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Classes.Base
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();
    }
}
