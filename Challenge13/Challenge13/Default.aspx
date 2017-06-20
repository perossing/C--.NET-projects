<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge13.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note-Taking Preference<br />
            <br />
            <asp:RadioButton ID="radioPencil" runat="server" GroupName="noteTaking" Text="pencil" />
            <br />
            <asp:RadioButton ID="radioPen" runat="server" GroupName="noteTaking" Text="pen" />
            <br />
            <asp:RadioButton ID="radioPhone" runat="server" GroupName="noteTaking" Text="phone" />
            <br />
            <asp:RadioButton ID="radioTablet" runat="server" GroupName="noteTaking" Text="tablet" />
            <br />
            <br />
            <asp:Button ID="buttonOK" runat="server" OnClick="buttonOK_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="labelMessage" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Image ID="imageResult" runat="server" />
        </div>
    </form>
</body>
</html>
