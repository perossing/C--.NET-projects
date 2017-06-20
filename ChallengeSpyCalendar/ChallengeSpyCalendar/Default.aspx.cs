using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSpyCalendar
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CalendarEndPrevious.SelectedDate = DateTime.Today;
                CalendarStartNew.SelectedDate = DateTime.Today.AddDays(14);
                CalendarProjectedEnd.SelectedDate = CalendarStartNew.SelectedDate.AddDays(21);
                CalendarProjectedEnd.VisibleDate = CalendarStartNew.SelectedDate.AddDays(21);
            }
            Page.MaintainScrollPositionOnPostBack = true;
            /*  To maintain scroll for all pages in site, put
                < pages maintainScrollPositionOnPostBack = "true" />
                in Web.config file.                
            */
        }

        protected void ButtonAssign_Click(object sender, EventArgs e)
        {
            int downTime = (int)CalendarStartNew.SelectedDate.Subtract(CalendarEndPrevious.SelectedDate).TotalDays;
            int assignmentLength = (int)CalendarProjectedEnd.SelectedDate.Subtract(CalendarStartNew.SelectedDate).TotalDays;
            string codeName = TextBoxCodeName.Text;
            string assignmentName = TextBoxAssignmentName.Text;
            int budget = assignmentLength * 500;

            if (assignmentLength > 21)
                budget += 1000;

            if (downTime < 14)
            {
                LabelMessage.Text = "Error:  Must allow two weeks between previous assingment and new assignment.";
                CalendarStartNew.SelectedDate = CalendarEndPrevious.SelectedDate.AddDays(14);
            }
            else if (assignmentLength < 0)
            {
                LabelMessage.Text = "Error:  Projected End Date must be after Start Date.";
                CalendarProjectedEnd.SelectedDate = CalendarStartNew.SelectedDate.AddDays(21);
                CalendarProjectedEnd.VisibleDate = CalendarStartNew.SelectedDate.AddDays(21);
            }
            else
                //LabelMessage.Text = "Assignment of " + codeName + " to assignment, " + assignmentName + " is authorized. Budget total: $" + budget;
                LabelMessage.Text = String.Format("Assignment of {0} to assignment, {1} is authorized. Budget total: {2:C}", codeName, assignmentName, budget);

        }
    }
}