using System;

namespace Observer
{
    public class MeteoFranceObserver : IObserver, IDisplay
    {
        private IObservable _station;
        private State _state;

        public MeteoFranceObserver(IObservable station)
        {
            _station = station;
        }
        
        public void update()
        {
            _state = _station.getState();
            display();
        }

        public void display()
        {
            Console.WriteLine($"MeteoFranceObserver : La temperature est de {_state.temperature} !");
        }
    }
}