using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCardDeck cardDeck = new CCardDeck();
            cardDeck.CreateCardPack();
            for (int i = 0; i < cardDeck.CardPack.Length; i++)
            {
                Console.WriteLine(cardDeck.CardPack.ElementAt(i));
            }
            Console.ReadLine();
        }
    }
}
