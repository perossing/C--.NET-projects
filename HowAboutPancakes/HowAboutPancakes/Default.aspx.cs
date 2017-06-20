using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowAboutPancakes
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonPurchase_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (radioSmall.Checked)
                total += 4;
            else if (radioMedium.Checked)
                total += 6;
            else if (radioLarge.Checked)
                total += 8;

            if (radioBuckwheat.Checked)
                total += 2;

            if (checkBlueberries.Checked)
                total += 1;
            if (checkStrawberries.Checked)
                total += 1;
            if (checkWhippedCream.Checked)
                total += 0.75;
            if (checkChocolateChips.Checked)
                total += 0.5;
            if (checkPeanutButter.Checked)
                total += 0.5;

            if ((checkBlueberries.Checked && checkStrawberries.Checked && checkWhippedCream.Checked) || (checkChocolateChips.Checked && checkPeanutButter.Checked && checkWhippedCream.Checked))
                total -= 1.5;

            labelTotal.Text = "Total:  $" + total.ToString();
        }
    }
}