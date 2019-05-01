using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    public class Roulette
    {
        //variables
        public int counter = 0;
        public int FireAway = 2;
        public bool isFireAway = false;
        public int winCounter = 0;
        public int loseCounter = 0;
        public int gpCounter = 0;




        // get random number
        public int RND()
        {
            Random r = new Random();
            return r.Next(1, 7);
        }




    }
}
