<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DartsChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 261px;
            height: 193px;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            width: 81%;
        }
        .auto-style4 {
            width: 577px;
        }
        .auto-style5 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style2"><strong>Two-Player Dart Game</strong></span><br />
            <br />
            <img alt="dart board scoring" class="auto-style1" src="dartboard.jpg" /><br />
            <br />
            <asp:Button ID="ButtonResults" runat="server" OnClick="ButtonResults_Click" Text="Play Game" Width="170px" />
            <br />
            <br />
            <table class="auto-style3">
                <tr>
                    <td valign="top" class="auto-style4">
                        <span class="auto-style5"><strong>ROUNDS:<br />
                        </strong></span>
                        <br />
                        <asp:Label ID="LabelFullGame" runat="server"></asp:Label>
                    </td>
                    <td valign="top">
                        <span class="auto-style5"><strong>FINAL:</strong></span><br />
                        <br />
                        <asp:Label ID="LabelFinal" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
