using System;

namespace Observer
{
    public class WorldWheatherObservable : IObserver, IDisplay
    {
        private IObservable _station;
        private State _state;

        public WorldWheatherObservable(IObservable station)
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
            Console.WriteLine($"WorldWheatherObservable : La temperature est de {_state.temperature} !");
        }
    }
}