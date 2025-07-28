using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Classes.Notification
{
    public class EmailNotification : INotification
    {
        public void Send(string data) => Console.WriteLine($"Email Notification: {data}");
    }
}
    