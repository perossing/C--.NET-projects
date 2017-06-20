<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Postal Calculator</h2>
            Width:&nbsp;
            <asp:TextBox ID="TextBoxWidth" runat="server" OnTextChanged="handleEntries"></asp:TextBox>
            <br />
            Height:&nbsp;
            <asp:TextBox ID="TextBoxHeight" runat="server" OnTextChanged="handleEntries"></asp:TextBox>
            <br />
            Length:&nbsp;
            <asp:TextBox ID="TextBoxLength" runat="server" OnTextChanged="handleEntries"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="RadioGround" runat="server" AutoPostBack="True" GroupName="postMethods" OnCheckedChanged="handleEntries" Text="Ground" />
            <br />
            <asp:RadioButton ID="RadioAir" runat="server" AutoPostBack="True" GroupName="postMethods" OnCheckedChanged="handleEntries" Text="Air" />
            <br />
            <asp:RadioButton ID="RadioNextDay" runat="server" AutoPostBack="True" GroupName="postMethods" OnCheckedChanged="handleEntries" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
