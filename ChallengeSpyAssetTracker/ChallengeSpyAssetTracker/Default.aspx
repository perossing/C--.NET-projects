<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSpyAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style2 {
            width: 150px;
            height: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="epic spies logo" class="auto-style2" src="epic-spies-logo.jpg" /><h1 class="auto-style1">Asset Performance Tracker</h1>
            <br />
            Asset Name:&nbsp;
            <asp:TextBox ID="TextBox_Assets" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged:&nbsp; <asp:TextBox ID="TextBox_Elections" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Acts" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button" runat="server" OnClick="Button_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="Label_Results" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
