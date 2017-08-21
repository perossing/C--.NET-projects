using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge13
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioPencil.Checked)
                imageResult.ImageUrl = "pencil.png";
            else if (radioPen.Checked)
                imageResult.ImageUrl = "pen.png";
            else if (radioPhone.Checked)
                imageResult.ImageUrl = "phone.png";
            else if (radioTablet.Checked)
                imageResult.ImageUrl = "tablet.png";
            else
                labelMessage.Text = "please make a selection";

        }
    }
}