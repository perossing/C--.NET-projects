<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WarChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 42%;
        }
        .auto-style2 {
            font-size: medium;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body class="newStyle1">
    <form id="form1" runat="server">
        <div>
            <h3>War Card Game</h3>
            <p>One hundred Battles or until one player is out of cards.<br />
                <em>To limit number of battles, if a player does not have enough cards to play a War, all cards go to winner of previous Battle.</em></p>
            <br />
            <asp:Button ID="Button_DealCards" runat="server" OnClick="Button_DealCards_Click1" Text="Play War!" />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <strong>
            <asp:Label ID="Label_Deal" runat="server" CssClass="auto-style2"></asp:Label>
            </strong>
            <br />
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label_Hand1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label_Hand2" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label_Battles" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label_Score" runat="server"></asp:Label>
    </form>
</body>
</html>
