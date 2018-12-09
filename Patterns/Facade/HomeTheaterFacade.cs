using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class HomeTheaterFacade
    {
        private Screen _screen;
        private Tuner _tuner;
        private DVDPlayer _dvdplayer;
        private Popcorn _popcorn;
        private Amplifier _amp;
        public HomeTheaterFacade(
            Screen screen,
            Tuner tuner,
            DVDPlayer dvdplayer,
            Popcorn popcorn,
            Amplifier amp
            )
        {
            this._screen = screen;
            this._tuner = tuner;
            this._dvdplayer = dvdplayer;
            this._popcorn = popcorn;
            this._amp = amp;
        }
        public void WatchMovie()
        {
            _screen.Up();
            _tuner.On();
            _dvdplayer.Play();
            _popcorn.On();
            _amp.SetSurrounSound();
            _amp.SetVolume(10);
        }
        public void EndMovie()
        {
            _screen.Down();
            _tuner.Off();
            _dvdplayer.Stop();
            _popcorn.Off();
            _amp.Off();
        }
    }
}
