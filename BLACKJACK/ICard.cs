using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public interface ICard
    {
        string[] CardSuitIdentiy { get; set; }
        int[] CardValue { get; set; }
        string[] CardName { get; set; }

    }
}
