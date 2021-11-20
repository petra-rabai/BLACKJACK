using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class CDealer : IPlayer
    {
        public int Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] ChoosedCards { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<char, string> Decision { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChooseStartCards()
        {
            throw new NotImplementedException();
        }
    }
}
