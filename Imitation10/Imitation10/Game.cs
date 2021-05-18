using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imitation10
{
    class Game
    {
        public double[] common_probs = { 0.2,0.2,0.2,0.2,0.2};
        
        public int roll()
        {
            Random rnd = new Random();
            double A = rnd.NextDouble();
            int k = 0;
            A -= common_probs[k];
            while (A > 0)
            {
                k++;
                A -= common_probs[k];
            }
            return k+1;
        }
        public int cheat_roll(double[] probs)
        {
            Random rnd = new Random();
            double A = rnd.NextDouble();
            int k = 0;
            A -= probs[k];
            while (A > 0)
            {
                k++;
                A -= probs[k];
            }
            return k+1;
        }

        public int[] cheat_roll()
        {
            int[] res = { 0, 0 };
            double[] cheat_probs = { 0.1, 0.1, 0.2, 0.2, 0.4};
            res[0] = cheat_roll(cheat_probs);
            res[1] = cheat_roll(cheat_probs);
            return res;
        }

        public int[] common_roll()
        {
            int[] res = { 0, 0 };
            res[0] = roll();
            res[1] = roll();
            return res;
        }
    }
}
