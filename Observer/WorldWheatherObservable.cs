using System;

namespace Observer
{
    public class WorldWheatherObservable : IObserver, IDisplay
    {
        private IObservable _station;
        private string _temperature;

        public WorldWheatherObservable(IObservable station)
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
            Console.WriteLine($"WorldWheatherObservable : La temperature est de {_temperature} !");
        }

    }
}