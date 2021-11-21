using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class CGame : IGame
    {
        private const int gameGoal = 21;
        private const int MaxValue = 1000000;

        public int Goal { get; set; } = gameGoal;
        public int Round { get; set; } = 0;
        public int AvailableCredit { get; set; } = 0;
        public int Bet { get; set; } = 0;

        public void SetuptheGameTable(CHuman human, CDealer dealer, CCardDeck cardDeck)
        {
            cardDeck.CreateCardPack();
            GenerateStartAvailableCredit();
            GetStartCardsFromPlayers(human, dealer, cardDeck);
            GameCore(human, dealer, cardDeck);
        }

        public int GenerateStartAvailableCredit()
        {
            Random credit = new Random();
            AvailableCredit = credit.Next(MaxValue);

            return AvailableCredit;
        }

        public void GetStartCardsFromPlayers(CHuman human, CDealer dealer, CCardDeck cardDeck)
        {
            human.ChooseStartCards(cardDeck);
            dealer.ChooseStartCards(cardDeck);
        }

        public void GameCore(CHuman human, CDealer dealer, CCardDeck cardDeck)
        {
            if (Round == 0)
            {
                InitializeFirstRound(human,dealer);
            }
            else
            {
                NextRound();
            }
        }

        public void NextRound()
        {
            throw new NotImplementedException();
        }

        public void InitializeFirstRound(CHuman human, CDealer dealer)
        {
            Console.WriteLine("Your available Credit for the game: " + "\n" + AvailableCredit.ToString());
            Console.WriteLine("Add your bet: " + "\n");
            RecieveBetFromHuman();
            AvailableCredit = AvailableCredit - Bet;
            Console.WriteLine("Your first card: " + "\n" + human.ChoosedCards[0]);
            Console.WriteLine("The Dealer first card: " + "\n" + dealer.ChoosedCards[0]);
            Console.WriteLine("Your second card: " + "\n" + human.ChoosedCards[1]);

            CheckRoundResult(human,dealer);

        }

        public void CheckRoundResult(CHuman human, CDealer dealer)
        {
            int currentCardsValue;
            string[] humanFirstCardData = new string[4];
            string[] humanSecondCardData = new string[4];
            humanFirstCardData = human.ChoosedCards[0].Split('-');
            humanSecondCardData = human.ChoosedCards[1].Split('-');
            currentCardsValue = Convert.ToInt32(humanFirstCardData[3] + humanSecondCardData[3]);
            if (((humanFirstCardData[2] == "Ace") || (humanSecondCardData[2] == "Ace")) && ((humanFirstCardData[3] == "10") || (humanSecondCardData[3] == "10")))
            {
                Console.WriteLine("You are WIN!");
                AvailableCredit = AvailableCredit + Bet;
            }
            else
            {
                human.MakeDecision();
            }
            
        }

        public int RecieveBetFromHuman()
        {
            Bet =  Convert.ToInt32(Console.ReadLine());
            return Bet;
        }

       
    }
}
