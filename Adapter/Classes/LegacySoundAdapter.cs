using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    public class LegacySoundAdapter : IAudioPlayer
    {
        private readonly LegacySoundSystem _system = new LegacySoundSystem();

        public LegacySoundAdapter(LegacySoundSystem system)
        {
            _system = system;
        }

        public void Play(string file) => _system.StartPlaying(file);



    }
}
