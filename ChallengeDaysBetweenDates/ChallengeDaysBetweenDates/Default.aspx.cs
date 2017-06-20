using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void buttonDates_Click(object sender, EventArgs e)
        {
            DateTime firstDate = calendar1.SelectedDate;
            DateTime secondDate = calendar2.SelectedDate;
            TimeSpan timeSpanDays = firstDate - secondDate;
            double daysBetween = timeSpanDays.TotalDays;

            if (daysBetween < 0)
                daysBetween = (-1 * daysBetween);

            labelResult.Text = "There are " + daysBetween + " days between the selected dates.";


            // OR:
            // labelResult.Text = calendar1.SelectedDate.Subtract(calendar2.SelectedDate).TotalDays.ToString();
            // w if else to compare greater date
        }

    }
}