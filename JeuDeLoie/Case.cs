using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    public abstract class Case
    {
        public int Numero;

        public abstract void Avance(Player joueur);
    }
}
