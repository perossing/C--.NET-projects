<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            background-color: #99FF33;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            color: #6600FF;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style2">Simple Calculator</h2>
        </div>
        <p>
            <span class="auto-style3">First Value:&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="firstValueTextBox" runat="server" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style3">Second Value:&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="secondValueTextBox" runat="server" CssClass="auto-style1"></asp:TextBox>
        </p>
        <asp:Button ID="addButton" runat="server" BackColor="#FFFF66" Font-Bold="True" Font-Size="Medium" ForeColor="#990033" Height="25px" OnClick="addButton_Click" Text="+" Width="25px" />
&nbsp;
        <asp:Button ID="subtractButton" runat="server" BackColor="#FFFF66" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="#990033" Height="25px" OnClick="subtractButton_Click" Text="-" Width="25px" />
&nbsp;
        <asp:Button ID="multiplyButton" runat="server" BackColor="#FFFF66" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="#990033" Height="25px" OnClick="multiplyButton_Click" Text="x" Width="25px" />
&nbsp;
        <asp:Button ID="divideButton" runat="server" BackColor="#FFFF66" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="#990033" Height="25px" OnClick="divideButton_Click" Text="/" Width="25px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="#FF99FF" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#000066"></asp:Label>
    </form>
</body>
</html>
