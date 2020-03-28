using System;

namespace State
{
    internal class OpenState : IState
    {
        private Context context { get; set; }

        public OpenState(Context context)
        {
            this.context = context;
        }

        public void entrer()
        {
            Console.WriteLine("l'utilisateur rentre passe le tourniqué !");
            context.changeState(new CloseState(context), "le tourniquer ce bloque ");
        }

        public void paye()
        {
            Console.WriteLine("l'utilisateur tente de payer!");
            context.changeState(new OpenState(context), "Le tourniquer reste ouvert !");
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