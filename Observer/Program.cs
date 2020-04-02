﻿using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable observable = new Observable();
            observable.add(new MeteoFranceObserver());
            observable.add(new WorldWheatherObservable());

            while(true)
            {
                Console.WriteLine("\nQuelles est la temperature ?");
                string temperature = Console.ReadLine();

                observable.update(temperature);
                observable.notify();
            }      
        }
    }
}