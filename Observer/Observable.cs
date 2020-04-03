using System;
using System.Collections.Generic;

namespace Observer
{
    public class Observable : IObservable
    {
        public List<IObserver> _watchers;
        private State _state;
        public Observable()
        {
            _watchers = new List<IObserver>();
            _state = new State();
            _state.temperature = "0";
        }
        public void add(IObserver item)
        {
            _watchers.Add(item);
        }

        public State getState()
        {
            return _state;
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

        public void update(State state)
        {
            _state = state;
        }
    }
}