using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    
    public class Player
    {
        private static Random Rand1 = new Random();
        public String Nom;
        public int NumCase=0;
        public int Wait;
        public int De1, De2, SommeDes;
        public bool Win;
        public int getSommeDes()
        {
            return De1+De2;
        }
        
        public Player(String Nom)
        {
            this.Nom = Nom;
        }

        public int LancerDe()
        {
            return Rand1.Next(1, 7);
        }

        public int Somme()
        {
            De1 = LancerDe();
            De2 = LancerDe();
            SommeDes = De1 + De2;
            NumCase = NumCase + SommeDes;

            if (NumCase > 63)
                NumCase = 63 - (NumCase - 63);
            return NumCase;
        }

    }
}
