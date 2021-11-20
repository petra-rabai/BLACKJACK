﻿using System;
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
        void GetStartCardsFromPlayers(CHuman human, CDealer dealer);
        void RecieveBetFromHuman();
        string[] CardShuffeling(CCardDeck cardDeck);
    }
}
