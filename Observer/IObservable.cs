namespace Observer
{
    public interface IObservable
    {
        public void add(IObserver item);
        public void remove(IObserver item);
        public void notify();
        public void update(State state);

        public State getState();
    }
}