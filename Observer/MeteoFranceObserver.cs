using System;

namespace Observer
{
    public class MeteoFranceObserver : IObserver
    {
        private string _temperature;
        public void update(IObservable observable)
        {
            _temperature = observable._temperature;
            display();
        }

        public void display()
        {
            Console.WriteLine($"MeteoFranceObserver : La temperature est de {_temperature} !");
        }
    }
}