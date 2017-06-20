using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculator
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void handleEntries(object sender, EventArgs e)
        {
            if (!validateEntries())
                return;

            int volume;
            if (!checkVolume(out volume))
                return;

            double postageRate = getRate();
            double cost = volume * postageRate;

            LabelResult.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);
        }

        private bool validateEntries()
        {
            if (!RadioAir.Checked && !RadioGround.Checked && !RadioNextDay.Checked)
                return false;

            if (TextBoxWidth.Text.Trim().Length == 0 || TextBoxHeight.Text.Trim().Length == 0) // Trim method removes leading and trailing white space
                return false;

            return true;
        }

        private bool checkVolume(out int volume)
        {
            volume = 0;
            int width = 0, height = 0, length = 0;

            if (!int.TryParse(TextBoxWidth.Text.Trim(), out width))
                return false;
            if (!int.TryParse(TextBoxHeight.Text.Trim(), out height))
                return false;
            if (!int.TryParse(TextBoxLength.Text.Trim(), out length))
                length = 1;  // for flat pieces

            volume = width * height * length;
            return true;
        }

        private double getRate()
        {
            if (RadioGround.Checked)
                return 0.15;
            else if (RadioAir.Checked)
                return 0.25;
            else if (RadioNextDay.Checked)
                return 0.45;
            else return 0;
        }

    }

}