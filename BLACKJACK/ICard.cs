using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public interface ICard
    {
        int Id { get; set; }
        string[] Suit { get; set; }
        int Value { get; set; }
        string Name { get; set; }
        string[] CardPack { get; set; }
        string[] LoadCardSuit();
        string[] CreateCardPack();
    }
}
