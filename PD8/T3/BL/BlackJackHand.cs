using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class BlackjackHand : Hand
    {
        public int getBlackjackValue()
        {
            int val = 0;
            bool Ace = false;
            foreach (Card card in cards)
            {
                int Value = card.getValue();

                if (Value> 10)
                {
                    val += 10;
                }
                else if (Value == 1)
                {
                    val += 11;
                    Ace = true;
                }
                else
                {
                    val += Value;
                }
            }
            if (val > 21 && Ace)
            {
                val -= 10;
            }
            return val;
        }
    }
}
