<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSpyCalendar.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
            height: 239px;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
        }
        .auto-style4 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="epic spies logo" class="auto-style1" src="epic-spies-logo.jpg" /></div>
        <h1 class="auto-style3"><strong>Spy New Assignment Form</strong></h1>
        <p>
            <span class="auto-style4">Spy Code Name: </span>&nbsp;<asp:TextBox ID="TextBoxCodeName" runat="server"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style4">New Assignment Name:</span>&nbsp;
            <asp:TextBox ID="TextBoxAssignmentName" runat="server"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style4">End Date of Previous Assignment:</span><asp:Calendar ID="CalendarEndPrevious" runat="server"></asp:Calendar>
        </p>
        <p>
            <span class="auto-style4">Start Date of New Assignment:</span><asp:Calendar ID="CalendarStartNew" runat="server"></asp:Calendar>
        </p>
        <p>
            <span class="auto-style4">Projected End Date of New Assignment:</span><asp:Calendar ID="CalendarProjectedEnd" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="ButtonAssign" runat="server" BackColor="#333333" ForeColor="White" OnClick="ButtonAssign_Click" style="font-size: medium; font-weight: 700" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="LabelMessage" runat="server" style="font-size: large"></asp:Label>
        </p>
    </form>
</body>
</html>
