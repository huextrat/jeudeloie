using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    // La dernière case, celle de la victoire :)
    // Permet de savoir si le joueur a gagné, demande si le joueur veut rejouer.
    public class CaseWin :Case
    {
        public override void Avance(Player joueur)
        {
            if (joueur.NumCase == 63)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bravo vous avez gagné !");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Le vainqueur de la partie est " + joueur.Nom);
                Console.WriteLine("________________________________________________");
                joueur.Win = true;

                Console.WriteLine("\nVoulez vous rejouer ( O/N ) ?");
                String reponse = Console.ReadLine();
                if (reponse == "O")
                {
                    System.Diagnostics.ProcessStartInfo myInfo = new System.Diagnostics.ProcessStartInfo();
                    myInfo.FileName = "JeuDeLoie.exe";
                    System.Diagnostics.Process.Start(myInfo);
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
