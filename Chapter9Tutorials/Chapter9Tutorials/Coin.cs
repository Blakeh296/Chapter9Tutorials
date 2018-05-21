using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9Tutorials
{
    class Coin
    {
        // Field to represent the side facing up;
        private string sideUp;

        Random rand = new Random();

        // Constructor
        public Coin()
        {
            sideUp = "Heads";
        }

        // The toss method simulates tossing the coin.
        public void Toss()
        {
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }

        }

        // The GetSideUp method returns the value
        // of the sideUpfield
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
