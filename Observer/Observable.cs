using System;
using System.Collections.Generic;

namespace Observer
{
    public class Observable : IObservable
    {
        public List<IObserver> _watchers;
        private string _temperature;
        public Observable()
        {
            _watchers = new List<IObserver>();
            _temperature = "0";
        }
        public void add(IObserver item)
        {
            _watchers.Add(item);
        }

        public string getState()
        {
            return _temperature;
        }

        public void notify()
        {
            foreach(var item in _watchers)
            {
                item.update();
            }
        }

        public void remove(IObserver item)
        {
            _watchers.Remove(item);
        }

        public void update(string temperature)
        {
            _temperature = temperature;
        }
    }
}