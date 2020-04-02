namespace Observer
{
    public interface IObserver
    {
        public void update(IObservable observable);
    }
}