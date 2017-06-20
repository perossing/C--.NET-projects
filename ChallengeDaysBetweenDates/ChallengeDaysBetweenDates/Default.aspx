<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeDaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            How many days are there between the two selected dates?<br />
            <br />
            <br />
            <asp:Label ID="labelResult" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Choose a date:<br />
            <asp:Calendar ID="calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            Choose another date:<br />
            <asp:Calendar ID="calendar2" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="buttonDates" runat="server" OnClick="buttonDates_Click" Text="OK" />
        </div>
    </form>
</body>
</html>
