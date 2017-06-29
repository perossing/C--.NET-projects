using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarChallenge
{
    public class Battle
    {

        public List<Card> Kitty = new List<Card>();

        /* Clears kitty. Sets next Cards to go into kitty to be first card
         * of each player's hand ( index[0] )
         * Builds string of Battle events by calling PlayRound() and DecideBattle()
         */
        public string StageBattle(Player player1, Player player2, out bool endGame)
        {
            endGame = false;
            bool isWar = false;
            Kitty.Clear();
            int nextCard = 0;
            string BattleReport = "";

            BattleReport += PlayRound(player1, player2, nextCard);
            BattleReport += DecideBattle(player1, player2, isWar, out endGame);
            return BattleReport;
        }

        /* Displays cards played by each player:
         * -- first in list for Battle,  -- indexed 0-3 for War).
         * Adds cards played to kitty & removes cards from players' hands.
         */           
        //public string PlayRound(Player player1, Player player2, List<Card> kitty, int nextCard)
        public string PlayRound(Player player1, Player player2, int nextCard)
        {
            string cardsPlayed = "";

            cardsPlayed += String.Format("{0} plays {1} -- {2} plays {3}<br/>",
                    player1.Name,
                    player1.Hand[nextCard].Name,
                    player2.Name,
                    player2.Hand[nextCard].Name);

            Kitty.Add(player1.Hand[nextCard]);
            Kitty.Add(player2.Hand[nextCard]);

            player1.Hand.Remove(player1.Hand[nextCard]);
            player2.Hand.Remove(player2.Hand[nextCard]);

            return cardsPlayed;
        } 
        
        /* Compares value of card played by each player:
         * -- fourth card (index 3) if War,  -- first two cards in kitty if Battle
         * If cards are equal, calls War(),
         * If cards not equal, calls TakeCards() passing appropriate winner & loser.
         * 
         */
        public string DecideBattle(Player player1, Player player2, bool isWar, out bool endGame)
        {
            Card card1;
            Card card2;
            string BattleResults = "";
            endGame = false;

            if (isWar) {card1 = player1.Hand[3]; card2 = player2.Hand[3];}
            else { card1 = Kitty[0]; card2 = Kitty[1]; }

            if (card1.FaceValue == card2.FaceValue) {
                isWar = true;
                BattleResults += War(player1, player2, out endGame);
            } else if (card1.FaceValue > card2.FaceValue) {
                BattleResults += TakeCards(player1, player2); //winner passed before loser
            } else {
                BattleResults += TakeCards(player2, player1); //winner passed before loser
            };

            return BattleResults;
        }

        /* Uses kitty to build list of cards played in Battle or War.
         * Adds all cards in kitty to winner's hand.
         */
        public string TakeCards(Player winner, Player loser)
        {
            string cardsWon = "";
            foreach (var card in Kitty)
            {
                cardsWon += card.Name + ", ";
            }
            winner.Hand.AddRange(Kitty);
            return String.Format("&nbsp;&nbsp;<b>{0}</b> Wins the Battle!<br/>&nbsp;&nbsp;{1} go to {2}<br/>",
                winner.Name,
                cardsWon.Substring(0, cardsWon.Length - 2),
                winner.Name);
        }

        /* Sets up a sequence of 4 battle rounds,  
         * loading kitty with each player's next card for each round.
         * Builds string of Battle events by calling PlayRound() and DecideBattle()
         */
        public string War(Player player1, Player player2, out bool endGame)
        {
            bool isWar = true;
            endGame = false;
            string warReport = "<b>! < < < < < < < < < < < < < < *** WAR *** > > > > > > > > > > > > > > > > !</b><br/>";

            for (int nextCard = 0; nextCard < 4; nextCard++)
            {
                if (player1.Hand.Count > 4 && player2.Hand.Count > 4)
                    warReport += PlayRound(player1, player2, nextCard);
                else
                {
                    endGame = true;
                    return warReport;
                }
            }

            warReport += DecideBattle(player1, player2, isWar, out endGame);
            return warReport;
        }

    }
}