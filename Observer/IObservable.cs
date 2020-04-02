namespace Observer
{
    public interface IObservable
    {
        public string _temperature {get; set;}
        public void add(IObserver item);
        public void remove(IObserver item);
        public void notify();
        public void update(string temperature);
    }
}