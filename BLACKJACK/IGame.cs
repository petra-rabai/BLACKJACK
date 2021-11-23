using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public interface IGame
    {
        int Goal { get; set; }
        int Round { get; set; }
        int AvailableCredit { get; set; }
        int Bet { get; set; }
        int currentCardsValue { get; set; }
        void GetStartCardsFromPlayers(CHuman human, CDealer dealer, CCardDeck cardDeck);
        int RecieveBetFromHuman();
        int GenerateStartAvailableCredit();
        void InitializeFirstRound(CHuman human, CDealer dealer);
        void SetuptheGameTable(CHuman human, CDealer dealer, CCardDeck cardDeck);
    }
}
