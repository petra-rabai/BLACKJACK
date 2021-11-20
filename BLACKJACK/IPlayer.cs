﻿using System;
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
        Dictionary<chat,setting> Decision { get; set; }
        void GetStartCards();
    }
}
