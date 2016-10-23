using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    class Program
    {

        // Main avec création du plateau et lancement du jeu

        static void Main(string[] args)
        {
            Plateau plateau = new Plateau();
            plateau.Jouer();
        }
    }
}
