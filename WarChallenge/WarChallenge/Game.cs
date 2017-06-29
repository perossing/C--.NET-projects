using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarChallenge
{
    public class Game
    {
        public Player player1 = new Player { Name = "Player One", Hand = new List<Card> { } };
        public Player player2 = new Player { Name = "Player Two", Hand = new List<Card> { } };
        public Deck deck = new Deck();
        public Battle battle = new Battle();

        Random random = new Random();

        public void Deal(Player player)
        {
            int cardNumber = random.Next(0, deck.Cards.Count);
            player.Hand.Add(deck.Cards[cardNumber]);
            deck.Cards.Remove(deck.Cards[cardNumber]);
        }

        public string DisplayDeal(Player player)
        {
            string showDeal = "<h4>" + player.Name + "'s Hand:</h4>";
            foreach (var card in player.Hand)
            {
                showDeal += card.Name + "<br/>";
            }
            return showDeal;
        }

        public string CalcScore(Player player1, Player player2)
        {
            string winner = "nobody";
            string finalScore = String.Format("{0} has {1} cards.  {2} has {3} cards.<br/>", player1.Name, player1.Hand.Count, player2.Name, player2.Hand.Count);

            if (player1.Hand.Count > player2.Hand.Count) winner = player1.Name;
            if (player2.Hand.Count > player1.Hand.Count) winner = player2.Name;
      
            return finalScore += "<h3>" + winner.ToUpper() + " WINS!</h3>";
        }
    }




}