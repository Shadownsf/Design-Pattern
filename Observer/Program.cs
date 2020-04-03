using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable observable = new Observable();
            observable.add(new MeteoFranceObserver(observable ));
            observable.add(new WorldWheatherObservable(observable));

            while(true)
            {
                Console.WriteLine("\nQuelles est la temperature ?");
                State state = new State();

                state.temperature = Console.ReadLine();

                observable.update(state);
                observable.notify();
            }      
        }
    }
}
