using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace String_v_StringBuilder
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string word1 = TextBox1.Text.ToString();
            string word2 = TextBox2.Text.ToString();
            string word3 = TextBox3.Text.ToString();
            string newWord = word1 + word2 + word3;

            StringBuilder appendWords = new StringBuilder().Append(word1);
            StringBuilder insertWords = new StringBuilder().Append(word1);

            Label1.Text = word1;
            Label2.Text = word2;
            Label3.Text = word3;
            Label4.Text = newWord;

            Label5.Text = appendWords.Append(word2).Append(word3).ToString();
            Label6.Text = insertWords.Insert(word1.Length / 2, word2).Insert(insertWords.Length / 2, word3).ToString();
            StringBuilder replaceVowels = appendWords;
            Label7.Text = replaceVowels.Replace("a", "*").Replace("e", "*").Replace("i", "*").Replace("o", "*").Replace("u", "*").ToString();
        }
    }
}