using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class CCardDeck : ICard
    {
        public int Id { get; set; } = 0;
        public string[] Suit { get; set; } = new string[4];
        public int Value { get; set; } = 0;
        public string Name { get; set; }
        public string[] CardPack { get; set; } = new string[52];

        public string[] CreateCardPack()
        {
            for (int suit = 0; suit < Suit.Length; suit++)
            {
                for (int value = 0; value < 13; value++)
                {       
                    Value++;
                    if (Value == 1)
                    {
                        Name = "Ace";
                    }
                    else if (Value == 11)
                    {
                        Name = "King";
                    }
                    else if (Value == 12)
                    {
                        Name = "Queen";
                    }
                    else if (Value == 13)
                    {
                        Name = "Jack";
                    }
                    else
                    {
                        Name = Value.ToString();
                    }

                    CardPack[Id] = Id.ToString() + " - " + Suit[suit] + " - " + Name;
                    Id++;
                }

                Value = 0;
            }

            return CardPack;
        }

        public string[] LoadCardSuit()
        {
            Suit[0] = "Dimonds";
            Suit[1] = "Clubs";
            Suit[2] = "Hearts";
            Suit[3] = "Spades";

            return Suit;
        }
    }
}
