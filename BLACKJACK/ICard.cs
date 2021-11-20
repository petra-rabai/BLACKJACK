using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public interface ICard
    {
        string[] CardSuit { get; set; }
        int[] CardValue { get; set; }
        string[] CardName { get; set; }
        int CardId { get; set; }
        string [,,,] CardsPack { get; set; }
        void CreateCardsPack();
        string[] LoadCardSuitIdentity();
        void ShufflingCards();
        int[] LoadCardValue();
    }
}
