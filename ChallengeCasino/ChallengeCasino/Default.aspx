<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeCasino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 164px;
            text-align: center;
        }
        .auto-style4 {
            width: 46px;
            height: 49px;
        }
        .auto-style5 {
            width: 45px;
            height: 36px;
        }
        .auto-style7 {
            width: 56px;
            height: 55px;
        }
        .auto-style8 {
            width: 32px;
            text-align: center;
        }
        .auto-style9 {
            text-align: center;
            height: 3px;
        }
        .auto-style12 {
            font-size: small;
        }
        .auto-style13 {
            font-size: medium;
        }
        .auto-style14 {
            font-size: large;
        }
        .auto-style15 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div dir="auto">
            <asp:Image ID="slotPic1" runat="server" Height="200px" Width="200px" BorderColor="White" BorderWidth="10px" />
            <asp:Image ID="slotPic2" runat="server" Height="200px" Width="200px" CssClass="auto-style1" BorderColor="White" BorderWidth="10px" />
            <asp:Image ID="slotPic3" runat="server" Height="200px" Width="200px" CssClass="auto-style1" BorderColor="White" BorderWidth="10px" />
            <br class="auto-style1" />
            <asp:Label ID="LabelTestOutput" runat="server"></asp:Label>
            <br />
            <br class="auto-style1" />
            <span class="auto-style1"><span class="auto-style12">YOUR BET:</span> </span>&nbsp;<asp:TextBox ID="TextBoxBet" runat="server" CssClass="auto-style13"></asp:TextBox>
            <br />
            <br />
            <strong>
            <asp:Button ID="ButtonLever" runat="server" BackColor="#009933" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="PULL THE LEVER!" OnClick="ButtonLever_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="ButtonPlayAgain" runat="server" BackColor="#666666" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="new game" OnClick="ButtonPlayAgain_Click" />
            <br />
            </strong>
            <br />
            <br />
            <asp:Label ID="LabelWinnings" runat="server" CssClass="auto-style14"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelMoney" runat="server" CssClass="auto-style14"></asp:Label>
            <br />
            <br />
            <hr />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <img alt="" class="auto-style4" src="Images/Cherry.png" /></td>
                    <td class="auto-style8">=</td>
                    <td>your bet x2</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <img alt="" class="auto-style4" src="Images/Cherry.png" /><img alt="" class="auto-style4" src="Images/Cherry.png" /></td>
                    <td class="auto-style8">=</td>
                    <td>your bet x3</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <img alt="" class="auto-style4" src="Images/Cherry.png" /><img alt="" class="auto-style4" src="Images/Cherry.png" /><img alt="" class="auto-style4" src="Images/Cherry.png" /></td>
                    <td class="auto-style8">=</td>
                    <td>your bet x4</td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <img alt="" class="auto-style5" src="Images/Seven.png" /><img alt="" class="auto-style5" src="Images/Seven.png" /><img alt="" class="auto-style5" src="Images/Seven.png" /></td>
                    <td class="auto-style8">=</td>
                    <td>JACKPOT:&nbsp; your bet x100 !</td>
                </tr>
                <tr>
                    <td class="auto-style9" colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <img alt="" class="auto-style7" src="Images/Bar.png" /></td>
                    <td class="auto-style8">=</td>
                    <td>no win</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
