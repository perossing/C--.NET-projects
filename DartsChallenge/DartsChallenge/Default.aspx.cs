using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace DartsChallenge
{
    public partial class Default : System.Web.UI.Page
    {
    // Game, Player, and Score classes saved in separater files
    // Dart class saved in Darts library

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonResults_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            string RoundResult = game.Play();
            LabelFullGame.Text = RoundResult;
            string FinalResult = game.DisplayFinal();
            LabelFinal.Text += FinalResult;
        }     

    }
}