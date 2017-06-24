using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DartsChallenge
{
    public class Game
    {
        Player player1;
        Player player2;
        Dart dart;

        public Game()
        {
            player1 = new Player();
            player1.Name = "Player One";

            player2 = new Player();
            player2.Name = "Player Two";

            dart = new Dart();
        }

        public string Play()
        {
            string roundResult = "";
            while (player1.Points < 300 && player2.Points < 300)
            {
                roundResult += throwThreeDarts(player1);
                roundResult += throwThreeDarts(player2);
            }
            return roundResult;
        }

        private string throwThreeDarts(Player player)
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                player.Throw(dart);
                result += DisplayTurn(dart, player);
            }
            return result += "<br/>";
        }

        private string DisplayTurn(Dart dart, Player player)
        {
            // Enables the display of each Throw to call out a Bullseye
            string wedgeName = "wedge";
            if (dart.Hit == 0) wedgeName = "Bullseye";

            string result = String.Format("{0}: {1}: {2}, band: {3} -- throw points: {4}, Total Points: {5}<br/>",
                    player.Name.ToUpper(), wedgeName, dart.Hit, dart.Band, Score.ThrowScore, player.Points);

            return result;
        }

        public string DisplayFinal()
        {
            //Set player1 as default Winner. Change as needed when displaying final results.
            string Winner = player1.Name.ToString();

            string GameResult = String.Format("{0} has {1} points. {2} has {3} points<br/>",
                player1.Name, player1.Points, player2.Name, player2.Points);
            if (player2.Points > player1.Points)
                Winner = player2.Name.ToString();
            GameResult += String.Format("<p>{0} Wins!</p>", Winner).ToUpper();

            return GameResult;
        }
    }
}