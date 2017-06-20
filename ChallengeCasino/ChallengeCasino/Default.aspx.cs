using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        int money;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                resetGame();
            }
        }

        protected void ButtonLever_Click(object sender, EventArgs e)
        {
            int bet = 0;
            money = int.Parse(ViewState["money"].ToString());
            validateBet(out bet);
            if (bet > money) { restrictBet(bet); return; }
            loadImages();
            processSpin(bet, money);
        }

        private void loadImages()
        {
            string[] slotPics = { "Images/Bar.png", "Images/Bell.png", "Images/Cherry.png", "Images/Clover.png", "Images/Diamond.png", "Images/HorseShoe.png", "Images/Lemon.png", "Images/Orange.png", "Images/Plum.png", "Images/Seven.png", "Images/Strawberry.png", "Images/Watermelon.png" };
            Random rnd = new Random();
            ///*
            slotPic1.ImageUrl = slotPics[rnd.Next(11)];
            slotPic2.ImageUrl = slotPics[rnd.Next(11)];
            slotPic3.ImageUrl = slotPics[rnd.Next(11)];
            //*/
            /*
            //FOR TESTING:
            slotPic1.ImageUrl = slotPics[2];
            slotPic2.ImageUrl = slotPics[2];
            slotPic3.ImageUrl = slotPics[2];
            */
        }

        private void processSpin(int bet, int money)
        {
            int winnings = 0;
            calculateWinnings(bet, out winnings);
            money += winnings;
            if (money <= 0) { endPlay(); return; }
            ViewState["money"] = money;
            showWinnings(bet, winnings, money);
        }

        private void calculateWinnings(int bet, out int winnings)
        {
            winnings = 0;
            string[] imageUrls = { slotPic1.ImageUrl, slotPic2.ImageUrl, slotPic3.ImageUrl };

            if (imageUrls[0].Contains("Bar") || imageUrls[1].Contains("Bar") || imageUrls[2].Contains("Bar"))
                winnings = -bet;
            else if (imageUrls[0].Contains("Seven") && imageUrls[1].Contains("Seven") && imageUrls[2].Contains("Seven"))
                winnings = bet * 100;
            else if (imageUrls[0].Contains("Cherry") || imageUrls[1].Contains("Cherry") || imageUrls[2].Contains("Cherry"))
                winnings = countCherries(imageUrls, bet, out winnings);
            else winnings = -bet;
        }

        private int countCherries(string[] imageUrls, int bet, out int winnings)
        {
            int cherryCount = 0;
            if (imageUrls[0].Contains("Cherry")) cherryCount++;
            if (imageUrls[1].Contains("Cherry")) cherryCount++;
            if (imageUrls[2].Contains("Cherry")) cherryCount++;
            winnings = bet * (cherryCount + 1);
            return winnings;
        }

        private bool validateBet(out int bet)
        {
            bet = 0;
            if ((TextBoxBet.Text.Trim().Length == 0) || (!int.TryParse(TextBoxBet.Text.Trim(), out bet)))
                return false;
            else {
                bet = int.Parse(TextBoxBet.Text.Trim());
                return true;
            }
        }

        private void restrictBet(int bet)
        {
            LabelWinnings.Text = String.Format("You do not have {0} to bet! Please enter a lower number.", bet);
            return;
        }

        private void showWinnings(int bet, int winnings, int money)
        {
            if (bet == 0)
                LabelWinnings.Text = String.Format("Please place a bet.");
            else if (winnings > 0)
                LabelWinnings.Text = String.Format("You bet {0:C} and won {1:C}", bet, winnings);
            else
                LabelWinnings.Text = String.Format("Sorry, you lost {0:C}. Try again!", bet);

            showMoney(money);
        }

        private void showMoney(int money)
        {
            TextBoxBet.Text = "";
            LabelMoney.Text = String.Format("player's money {0:C}", ViewState["money"]);
        }

        private void endPlay()
        {
            TextBoxBet.Text = "";
            LabelWinnings.Text = "";
            LabelMoney.Text = "You are out of money. It's time to quit!";
            TextBoxBet.Enabled = false;
            ButtonLever.Enabled = false;
        }

        protected void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            TextBoxBet.Enabled = true;
            ButtonLever.Enabled = true;
            ViewState.Add("money", 100);
            loadImages();
            showMoney(money);
            LabelWinnings.Text = "";
        }

    }
}