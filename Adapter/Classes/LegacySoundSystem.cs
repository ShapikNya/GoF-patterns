using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    public class LegacySoundSystem
    {
        public void StartPlaying(string file)
        {
            Console.WriteLine($"Playing {file} with LegacySoundSystem...");
        }
    }

}
