using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    public class CaseJump :Case
    {
        public override void Avance(Player joueur)
        {
            int de1 = joueur.De1;
            int de2 = joueur.De2;
            // Gestion du 1er lancer de dés
            if (joueur.NumCase == 9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                if ((de1 == 5 && de2 == 4) || (de1 == 4 && de2 == 5))
                {
                    Console.WriteLine("5 & 4 au premier lancer !! Vous arrivez à la case 53.");
                    joueur.NumCase = 53;
                }

                if ((de1 == 3 && de2 == 6) || (de1 == 6 && de2 == 3))
                {
                    Console.WriteLine(" 6 & 3 au premier lancer !! Vous arrivez à la case 26.");
                    joueur.NumCase = 26;
                }

                else
                    Console.WriteLine("Vous arrivez sur la case " + joueur.NumCase + ".");

            }
            // Gestion des cases bénef
            else if (joueur.NumCase % 9 == 0 && joueur.NumCase != 9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Votre lancer est doublé.");
                joueur.NumCase += joueur.getSommeDes();
                if (joueur.NumCase > 63)
                    joueur.NumCase = 63 - (joueur.NumCase - 63);
                Console.WriteLine("Vous êtes sur la case "+joueur.NumCase+".");

            }
            // Gestion du pont
            else if (joueur.NumCase == 6)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Vous avancez jusqu'à la case 12.");
                joueur.NumCase = 12;
            }
            // Gestion du labyrinthe
            else if (joueur.NumCase == 42)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Perdu dans le labyrinthe vous arrivez à la case 30.");
                joueur.NumCase = 30;
            }
            // Gestion de la mort
            else if (joueur.NumCase == 58)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Vous êtes mort !");
                joueur.NumCase = 0;
            }

        }
    }
}
