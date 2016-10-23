using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    class Plateau
    {
        public Boolean Jeu;
        public Player Win;
        public Player[] tabPlayer;
        public Case[] plateau;

        // Le plateau avec 63 cases et un maximum de 4 joueurs.
        public Plateau()
        {
            tabPlayer = new Player[4];
            plateau = new Case[64];
            Jeu = false;
        }
        // Configuration du jeu
        // Nombre de joueurs + créations des cases
        public void Config()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nombre de joueurs ( 2 - 3 - 4) : ");
            int NbJoueur = int.Parse(Console.ReadLine());
            while (NbJoueur < 2 || NbJoueur > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Il ne peut y avoir que 2 - 3 - 4 joueurs.\n");
                Console.WriteLine("Nombre de joueurs ( 2 - 3 - 4) : ");
                NbJoueur = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            for (int i = 0; i < NbJoueur; i++)
            {
                Console.WriteLine("\nNom du joueur : ");
                String nom = Console.ReadLine();
                Player joueur = new Player(nom);
                tabPlayer[i] = joueur;
            }

            // Création des cases sur le plateau
            for (int i = 0; i <= 63; i++)
            {
                if ((i % 9 == 0 || i == 6 || i == 42 || i == 58) && i != 63)
                    plateau[i] = new CaseJump();
                else if (i == 19 || i == 31 || i == 52)
                    plateau[i] = new CaseWait();
                else if (i == 63)
                    plateau[i] = new CaseWin();
                else
                    plateau[i] = new CaseNormal();
            }


        }

        // Jouer() va tourner en permanence jusqu'à la fin du jeu et configure le jeu au lancement.
        public void Jouer()
        {
            Config();

            Console.WriteLine("\n \t\t\tLa partie va commencer !");
            while (Jeu == false)
            {
                foreach (Player player in tabPlayer)
                {
                    if (player != null)
                    {
                        if (player.Wait == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;    
                            Console.WriteLine("________________________________________________");
                            Console.WriteLine("\n\n" + player.Nom + "! Vous devez passer votre tour !");
                        }

                        if (player.Wait > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("________________________________________________");
                            Console.WriteLine("\n\n" + player.Nom + "! Vous devez passer votre tour !");
                            player.Wait = player.Wait - 1;
                        }

                        if (player.Wait == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("________________________________________________");
                            Console.WriteLine("\n\n C'est au tour de " + player.Nom + " ! Vous êtes sur la case " + player.NumCase);
                            Console.ReadLine();
                            player.Somme();
                            Console.WriteLine("Vous avez lancé les dés : " + player.De1 + " et " + player.De2);
                            Console.WriteLine("Vous faites " + player.getSommeDes() + " au lancer de dés.");
                            plateau[player.NumCase].Avance(player);
                            Console.ReadLine();

                            if (player.Win == true)
                            {
                                Win = player;
                                Jeu = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
