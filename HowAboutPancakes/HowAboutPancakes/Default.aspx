<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HowAboutPancakes.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: xx-large;
            color: #CC6600;
        }
        .auto-style2 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: large;
            color: #FF0066;
        }
        .auto-style4 {
            color: #FF3399;
        }
        .auto-style6 {
            color: #0066FF;
        }
        .auto-style7 {
            width: 183px;
            height: 131px;
            float: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="stack of pancakes" class="auto-style7" src="pancakeStack.jpg" />&nbsp;<h1 class="auto-style1">&nbsp; Full Stack Pancakes</h1>
            <p class="auto-style1">&nbsp;</p>
        </div>
        <asp:RadioButton ID="radioSmall" runat="server" GroupName="size" Text="Small Stack (3) - $4" />
        <br />
        <asp:RadioButton ID="radioMedium" runat="server" Checked="True" GroupName="size" Text="Medium Stack (6) - $6" />
        <br />
        <asp:RadioButton ID="radioLarge" runat="server" GroupName="size" Text="Large Stack (9) - $8" />
        <br />
        <br />
        <asp:RadioButton ID="radioButtermilk" runat="server" Checked="True" GroupName="type" Text="Buttermilk" />
        <br />
        <asp:RadioButton ID="radioBuckwheat" runat="server" GroupName="type" Text="Buckwheat  (+$1)" />
        <br />
        <br />
        <asp:CheckBox ID="checkBlueberries" runat="server" Text="Blueberries (+$1)" />
        <br />
        <asp:CheckBox ID="checkStrawberries" runat="server" Text="Strawberries (+$1)" />
        <br />
        <asp:CheckBox ID="checkWhippedCream" runat="server" Text="Whipped Cream (+$0.75)" />
        <br />
        <asp:CheckBox ID="checkChocolateChips" runat="server" Text="Chocolate Chips (+$0.50)" />
        <br />
        <asp:CheckBox ID="checkPeanutButter" runat="server" Text="Peanut Butter (+$0.50)" />
        <br />
        <br />
        <br />
        <span class="auto-style2"><strong><em>Special Deal:</em></strong></span><br />
        <br />
        <em>Save $1.50 when you add:<br />
        </em><span class="auto-style4">&nbsp;&nbsp;&nbsp; </span><span class="auto-style6">Blueberries, Strawberries, and Whipped Cream</span><span class="auto-style4"> </span>&nbsp; <em>or</em><br />
        <span class="auto-style4">&nbsp;&nbsp;&nbsp; </span><span class="auto-style6">Chocolate Chips, Peanut Butter, and Whipped Cream</span><br />
        <br />
        <asp:Button ID="buttonPurchase" runat="server" BackColor="Yellow" Font-Bold="True" Font-Names="Cambria" OnClick="buttonPurchase_Click" Text="PURCHASE" />
        <br />
        <br />
        <asp:Label ID="labelTotal" runat="server" Text="Total: "></asp:Label>
    </form>
</body>
</html>
