using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public interface IPlayer
    {
        int Score { get; set; }
        string[] ChoosedCards { get; set; }
        Dictionary<char,string> Decision { get; set; }
        void ChooseStartCards();
    }
}
