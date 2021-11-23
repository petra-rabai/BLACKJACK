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
        public string[] ChoosedCards { get; set; } = new string[2];
        public Dictionary<char, string> Decision { get; set; } = new Dictionary<char, string>()
        {
            ['H'] = "Hit",
            ['S'] = "Stand",
            ['B'] = "Bust",
            ['R'] = "Surrender"
        };

        public string[] ChooseStartCards(CCardDeck cardDeck)
        {
            Random choose = new Random();

            for (int counter = 0; counter < ChoosedCards.Length; counter++)
            {
                int chooseHelper = choose.Next(cardDeck.CardPack.Length);
                ChoosedCards[counter] = cardDeck.CardPack.ElementAt(chooseHelper);
            }

            return ChoosedCards;
        }

        public void MakeDecision(CGame game)
        {
            throw new NotImplementedException();
        }
    }
}
