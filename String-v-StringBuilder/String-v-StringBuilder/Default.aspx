<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="String_v_StringBuilder.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2 class="auto-style1">
            Stings and StringBuilder:&nbsp;</h2>
        <p class="auto-style1">
            What is one of your favorite words?</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="237px" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p class="auto-style1">
            What is another one of your favorite words?</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Width="237px" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p class="auto-style1">
            One more favorite word, please!</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Width="235px" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" BackColor="#FFCC00" OnClick="Button1_Click" Text="show demo" />
        </p>
        <p class="auto-style1">
            Your words are:</p>
        <p>
            <span class="auto-style1">1:&nbsp; </span> <asp:Label ID="Label1" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p>
            <span class="auto-style1">2:&nbsp;
            </span>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p>
            <span class="auto-style1">3:&nbsp;
            </span>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <span class="auto-style1">Your words can be concatenated into a new STRING:&nbsp; </span>
            <asp:Label ID="Label4" runat="server" CssClass="auto-style1"></asp:Label>
        &nbsp;. . . &nbsp;</p>
        <p class="auto-style1">
            . . . or they can be combined in a STRINGBUILDER in various ways:</p>
        <p>
            <span class="auto-style1">append:&nbsp;
            </span>
            <asp:Label ID="Label5" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p>
            <span class="auto-style1">insert:&nbsp;
            </span>
            <asp:Label ID="Label6" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p>
            <span class="auto-style1">replace:&nbsp;
            </span>
            <asp:Label ID="Label7" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
    </form>
</body>
</html>
