using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name

            string name = "Donut Monkey";
            resultLabel.Text = name;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel0.Text += name[i];
            }

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            resultLabel1.Text = names;

            string[] namesArray = names.Split(',');
            string reversedNames = "";
            for (int i = namesArray.Length - 1; i >= 0; i--)
            {
                reversedNames += namesArray[i] + ",";
            }
            reversedNames = reversedNames.Remove(reversedNames.Length - 1, 1);
            resultLabel2.Text = reversedNames;



            // 3. Use the sequence to create ascii art:
            // *****Luke*****
            // *****Leia*****
            // *****Han******
            // **Chewbacca***

            string newLine = "";
            for (int i = 0; i < namesArray.Length; i++)
            {
                int leftPad = (14 - namesArray[i].Length) / 2;
                string leftSide = namesArray[i].PadLeft(namesArray[i].Length + leftPad, '*');
                newLine += leftSide.PadRight(14, '*') + "<br />";
            }
            resultLabel3.Text = newLine;



            // 4. Solve this puzzle:
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            string remove = "remove-me";
            puzzle = puzzle.Remove(puzzle.IndexOf(remove), remove.Length);
            puzzle = puzzle.Replace('Z', 't');
            puzzle = puzzle.ToLower();
            puzzle = puzzle[0].ToString().ToUpper() + puzzle.Substring(1);
            resultLabel4.Text = puzzle;
        }
    }
}