using System;

namespace Observer
{
    public class WorldWheatherObservable : IObserver
    {
        private string _temperature;
        public void update(IObservable observable)
        {
            _temperature = observable._temperature;
            display();
        }

        public void display()
        {
            Console.WriteLine($"WorldWheatherObservable : La temperature est de {_temperature} !");
        }

    }
}