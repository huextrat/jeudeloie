using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    public class CaseNormal :Case
    {
        // Gestion d'une case normal
        public override void Avance(Player joueur)
        {
            Console.WriteLine("Vous arrivez sur la case "+ joueur.NumCase+".");
        }
    }
}
