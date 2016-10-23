using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    // Permet de gérer les cases à effet négatif pour le joueur.
    public class CaseWait :Case
    {
        // ActualPlayer correspond au joueur qui est dans le piège.
        // Ainsi nous pouvons liberer l'ancien et mettre le nouveau joueur.
        public Player ActualPlayer;

        // Tous les cas seront traité ici.

        public override void Avance(Player joueur)
        {
            if (joueur.NumCase == 19)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Repos à l'hôtel.");
                ActualPlayer = joueur;
                joueur.Wait = 2;
                Console.WriteLine("Vous êtes sur la case " + joueur.NumCase + ".");
            }

            if (joueur.NumCase == 31)
            {
                if (ActualPlayer == null)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Aïe vous tombez dans le puit !");
                    ActualPlayer = joueur;
                    joueur.Wait = -1;
                    Console.WriteLine("Vous êtes sur la case " + joueur.NumCase + ".");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Aïe vous tombez dans le puit ! "+ActualPlayer.Nom+" sort du puit.");
                    ActualPlayer.Wait = 0;
                    ActualPlayer = joueur;
                    ActualPlayer.Wait = -1;
                    Console.WriteLine("Vous êtes sur la case "+ joueur.NumCase+".");
                }
            }
            if (joueur.NumCase == 52)
            {
                if (ActualPlayer == null)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Prison !!");
                    ActualPlayer = joueur;
                    joueur.Wait = -1;
                    Console.WriteLine("Vous êtes sur la case " + joueur.NumCase + ".");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Prison !! "+ActualPlayer.Nom+" est donc libéré.");
                    ActualPlayer.Wait = 0;
                    ActualPlayer = joueur;
                    ActualPlayer.Wait = -1;
                    Console.WriteLine("Vous êtes sur la case "+ joueur.NumCase+".");
                }
            }

        }
    }
}
