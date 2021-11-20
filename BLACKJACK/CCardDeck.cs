using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class CCardDeck
    {
        public string[] CardSuit = new string[4];
        public int[] CardValue = new int[13];
        public string[] CardName = new string[52];
        public int CardId = 0;
        public string[,] CardsPack = new string[52,13];

        public string[,] CreateCardsPack()
        {
            LoadCardSuitIdentity();
            LoadCardValue();
            // LoadCardName();
            for (int id  = 0; id < 53; id++)
            {
                for (int suit = 0; suit < CardSuit.Length; suit++)
                {
                    for (int value = 0; value < CardValue.Length; value++)
                    {
                        CardId++;
                        if (CardId >10 && CardId <14)
                        {
                            CardValue[CardId] = 10;
                        }
                        CardName[id] = CardSuit[suit] + " - " + CardValue[value];
                        if (CardId == 11 || CardId == 21 || CardId == 31 || CardId == 41)
                        {
                            CardName[id] = "King";
                        }
                        if (CardId == 11 || CardId == 21 || CardId == 31 || CardId == 41)
                        {
                            CardName[id] = "King";
                        }
                        CardsPack[suit, value] = CardId.ToString() + " - " + CardName[id]+ " - " + CardValue[value];
                    }
                }
            }
            
            return CardsPack;
        }

        public void ShufflingCards()
        {
            throw new NotImplementedException();
        }

        public string[] LoadCardSuitIdentity()
        {
            CardSuit[0] = "Clubs";
            CardSuit[1] = "Dimonds";
            CardSuit[2] = "Hearts";
            CardSuit[3] = "Spades";

            return CardSuit;
        }

        public int[] LoadCardValue()
        {
            for (int value = 1; value < CardValue.Length; value++)
            {
                CardValue[value] = value;
            }
            return CardValue;
        }

        //public string[] LoadCardName()
        //{
        //    for (int suit = 0; suit < CardSuit.Length; suit++)
        //    {
        //        for (int value = 1; value < CardValue.Length; value++)
        //        {
        //            CardName[value] = CardSuit[suit] + CardValue[value];
        //        }
        //    }
        //    return CardName;
        //}
    }
}
