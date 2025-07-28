using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes
{
    public class DVDPlayer
    {
        public void Play() => Console.WriteLine("DVD is PLAYING");
        public void Stop() => Console.WriteLine("DVD is STOPPED");
    }
}
