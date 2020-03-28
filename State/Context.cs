using System;

namespace State
{
    public class Context
    {
        private IState state;
        public Context()
        {
            this.state = new CloseState(this);
            Console.WriteLine("Les tourniquer sont fermez!");
        }

        public void paiementEssaie()
        {
            state.paye();
        }

        public void paiementEchoué()
        {
            state.payeFail();
        }


        public void paiementReussit()
        {
            state.payeOk();
        }

        public void entrer()
        {
            state.entrer();
        }

        public void changeState(IState state, string message)
        {
            Console.WriteLine(message);
            this.state = state;
        }


    }
}