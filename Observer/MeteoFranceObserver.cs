using System;

namespace Observer
{
    public class MeteoFranceObserver : IObserver, IDisplay
    {
        private IObservable _station;
        private string _temperature;

        public MeteoFranceObserver(IObservable station)
        {
            _station = station;
        }
        
        public void update()
        {
            _temperature = _station.getState();
            display();
        }

        public void display()
        {
            Console.WriteLine($"MeteoFranceObserver : La temperature est de {_temperature} !");
        }
    }
}