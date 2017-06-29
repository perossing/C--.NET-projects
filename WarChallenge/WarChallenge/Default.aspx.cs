using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WarChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button_DealCards_Click1(object sender, EventArgs e)
        {
            Game game = new Game();

            Label_Battles.Text = "";
            Label_Deal.Text = "Deal...";

            while (game.deck.Cards.Count > 0)
            {
                game.Deal(game.player1);
                game.Deal(game.player2);
             }

            Label_Hand1.Text = game.DisplayDeal(game.player1);
            Label_Hand2.Text = game.DisplayDeal(game.player2);

            bool endGame = false;
            
            for (int i = 1; i <= 100; i++)
            {
                if (game.player1.Hand.Count > 1 && game.player2.Hand.Count > 1 && endGame == false) 
                {
                  Label_Battles.Text += "<h4>Battle " + i + ":</h4>" + game.battle.StageBattle(game.player1, game.player2, out endGame);
                }
                else
                {
                    Label_Battles.Text += FinishGame(game.player1, game.player2);
                    break;
                }
            }            

            Label_Score.Text = game.CalcScore(game.player1,game.player2);
        }


        public string FinishGame(Player player1, Player player2)
        {
            string loser;
            Deck fullDeck = new Deck();
            player1.Hand.Clear();
            player2.Hand.Clear();
            if (player1.Hand.Count > player2.Hand.Count)
            {
                player1.Hand.AddRange(fullDeck.Cards);
                loser = player2.Name;
            }
            else
            {
                player2.Hand.AddRange(fullDeck.Cards);
                loser = player1.Name;
            }
            return "<br/>" + loser + " is out of Cards";
        }

    }
}
