using System;

namespace State
{
    public class CloseState : IState
    {
        private Context context { get; set; }

        public CloseState(Context context)
        {
            this.context = context;
        }

        public void paye()
        {
            Console.WriteLine("tentative de paiement !");
            context.changeState(new PendingState(context), "le tourniquer passe a l'etat pending...");
        }

        public void payeFail()
        {
            Console.WriteLine("paiement échoué !");
            context.changeState(new CloseState(context), "Le tourniquer reste à l'etat Close...");
        }

        public void payeOk()
        {
            Console.WriteLine("paiement éfféctué !");
            context.changeState(new OpenState(context), "Le tourniquer passe à l'etat Open...");
        }

        public void entrer()
        {
            Console.WriteLine("le client entre !");
            context.changeState(new CloseState(context), "Le tourniquer reste a l'etat Close...");
        }
    }
}