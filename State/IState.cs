namespace State
{
    public interface IState
    {
        public void paye();
        public void payeOk();
        public void payeFail();
        public void entrer();
    }
}