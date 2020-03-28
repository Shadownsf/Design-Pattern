using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            while(true)
            {
                Console.WriteLine("Quelle Action voulez-vous executé ? Payé(1) : Entrer(2)");

                string choix = Console.ReadLine();

                if (choix == "1")
                {
                    context.paiementEssaie();
                }
                else
                {
                    context.entrer();
                }
            }
        }
    }
}
