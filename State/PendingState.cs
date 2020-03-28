using System;

namespace State
{
    internal class PendingState : IState
    {
        private Context context;

        public PendingState(Context context)
        {
            this.context = context;
        }

        public void entrer()
        {
            Console.WriteLine("l'utilisateur tente de rentrer");
            context.changeState(new CloseState(context), " l'utilisateur est rentrer!");
        }

        public void paye()
        {
            Console.WriteLine("l'utilisateur tente de rentrer");
            context.changeState(new PendingState(context), "l'utilisateur ne peut pas payer");
        }

        public void payeFail()
        {
            throw new System.NotImplementedException();
        }

        public void payeOk()
        {
            throw new System.NotImplementedException();
        }
    }
}