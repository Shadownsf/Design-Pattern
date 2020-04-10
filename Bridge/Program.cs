using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Artist 1 - 
            Artist artist1 = new Artist();
            artist1.Fullname = "John Pasci";
            artist1.Bio = "Ex singer of group Pourquoi pas au diner.";
            artist1.Image = 
            @"G   __
\\  ,,)_
 \'-\( /
   \ | ,\
    \|_/\\
    / _ '.D
   / / \ |
  /_\  |_\
  '-    '-";

            /// Artist 2
            Artist artist2 = new Artist();
            artist2.Fullname = "leny creuvé";
            artist2.Bio = "main singer of group - SuIcidE Yourself !.";
            artist2.Image = 
            @"     /     |    \
     /      |     \
    /O   O  | O   O\
   //|\ /|\  /|\ /|\\              
  /=/ \=/ \= / \=/ \=\
 / ==  ==  ==  ==  == \
/ ==   ==  ==  ==   == \";

            // Book 1
            Book book1 = new Book();
            book1.Title = "Tommorow, been a long time";
            book1.Synopsys = "the same synopsys of Back to the futur !";
            book1.Cover = 
            @"   _____
  /     \
/- (*) |*)\
|/\.  _>/\|
    \__/    |\
   _| |_   \-/
  /|\__|\  //
 |/|   |\\//
 |||   | ~'
 ||| __|
 /_\| ||
 \_/| ||
   |7 |7
   || ||
   || ||
   /\ \ \  fog
  ^^^^ ^^^";




            /// Ressources
            IRessource artistRessource1 = new ArtistRessource(artist1);
            IRessource artistRessource2 = new ArtistRessource(artist2);

            IRessource bookRessource1 = new BookRessource(book1);

            /// Views

            View shortView1 = new ShortView(artistRessource1);
            View longView1 = new LongView(artistRessource1);
            
            View shortView2 = new ShortView(artistRessource2);
            View longView2 = new LongView(artistRessource2);

            View shortView3 = new ShortView(bookRessource1);
            View longView3 = new LongView(bookRessource1);

            while(true)
            {
                Console.WriteLine("Quelle Type de view voulez-vous voir ? Short(1) : Long(2)");

                string choix = Console.ReadLine();

                if (choix == "1")
                {
                    shortView1.show();
                    Console.WriteLine("\n//////////////////////////////////////////////////////////////\n");
                    shortView2.show();
                    Console.WriteLine("\n//////////////////////////////////////////////////////////////\n");
                    shortView3.show();
                }
                else
                {
                    longView1.show();
                    Console.WriteLine("\n//////////////////////////////////////////////////////////////\n");
                    longView2.show();
                    Console.WriteLine("\n//////////////////////////////////////////////////////////////\n");
                    longView3.show();
                }
                Console.WriteLine("\nEnd of Views\n\n");
            }
        }
    }
}
