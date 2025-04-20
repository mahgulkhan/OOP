using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Hand
    {
        protected List<Card> cards = new List<Card>();

        public void addaCard(Card card)
        {
            cards.Add(card);
        }

        public void showHand(bool revealAll = true)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (!revealAll && i == 1)
                    Console.WriteLine("Hidden card");
                else
                    Console.WriteLine(cards[i].toString());
            }
        }
    }
}
