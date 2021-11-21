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
            CHuman human = new CHuman();
            CDealer dealer = new CDealer();
            CGame game = new CGame();

            game.SetuptheGameTable(human, dealer, cardDeck);
        }
    }
}
