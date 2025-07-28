using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes
{
    public class HomeTheaterFacade
    {
        private readonly DVDPlayer _player;
        private readonly Lights _lights;
        private readonly Projector _projector;
        private readonly SoundSystem _sound;

        public HomeTheaterFacade(DVDPlayer player, Lights lights, Projector projector, SoundSystem sound)
        {
            _player = player; _lights = lights; _projector = projector; _sound = sound;
        }

        public void WatchMovie()
        {
            _player.Play(); _lights.Dim(); _projector.On(); _sound.TurnOn();
        }
        public void EndMovie()
        {
            _player.Stop(); _lights.Bright(); _projector.Off(); _sound.TurnOff();
        }
    }
}
