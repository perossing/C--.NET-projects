using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSpyAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // When page is first loaded/reloaded, creates new empty arrays and adds them to ViewStates 
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);
            }
        }

        protected void Button_Click(object sender, EventArgs e)

        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] acts = (int[])ViewState["Acts"];

            // Length is the same in all three arrays, so length of one can be used for all three (crappy way to do it)
            int newLength = assets.Length + 1;

            Array.Resize(ref assets, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref acts, newLength);

            int newIndex = assets.GetUpperBound(0);

            assets[newIndex] = TextBox_Assets.Text;
            elections[newIndex] = int.Parse(TextBox_Elections.Text);
            acts[newIndex] = int.Parse(TextBox_Acts.Text);

            // Puts arrays w new values back into ViewState
            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            Label_Results.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset:{1:N2}<br />Last Asset Added: {2}<br />Total Number of Assets: {3}",
                elections.Sum(),
                acts.Average(),
                assets[newIndex],
                assets.Length );

            TextBox_Assets.Text = "";
            TextBox_Elections.Text = "";
            TextBox_Acts.Text = "";

        }
    }
}