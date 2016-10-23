using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLoie
{
    public class Dice
    {
        private static Random mRandom = new Random();

        public int De1
        {
            get;
            private set;
        }

        public int De2
        { 
            get; 
            private set;
        }

        public int Somme
        {
            get 
            {
                return De1 + De2;
            }
        }

        private Dice()
        {
            De1 = mRandom.Next(1,7);
            De2 = mRandom.Next(1,7);
        }

        public static Dice Fabrique()
        {
            return new Dice();
        }

    }
}
