using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class CGame : IGame
    {
        public int Goal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Round { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AvailableCredit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Bet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetStartCardsFromPlayers(CHuman human, CDealer dealer)
        {
            throw new NotImplementedException();
        }

        public void RecieveBetFromHuman()
        {
            throw new NotImplementedException();
        }
    }
}
