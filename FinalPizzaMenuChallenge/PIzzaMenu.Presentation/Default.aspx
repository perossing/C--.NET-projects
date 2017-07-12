<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaMenu.Presentation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>pizza menu</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="page-header">
                <h1>ASPizza</h1>
                <p class="lead">another pizza menu!</p>
            </div>

            <div class="form-group">
                <label>Size:</label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                    <asp:ListItem Text="select a size..." Value="" Selected="True" />
                    <asp:ListItem Text="Small (12 inch - $12)" Value="Small" />
                    <asp:ListItem Text="Medium (14 inch - $14)" Value="Medium" />
                    <asp:ListItem Text="Large (16 inch - $16)" Value="Large" />
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Crust:</label>
                <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                    <asp:ListItem Text="select your crust..." Value="" Selected="True" />
                    <asp:ListItem Text="Regular" Value="Regular" />
                    <asp:ListItem Text="Thin" Value="Thin" />
                    <asp:ListItem Text="Thick (+ $2)" Value="Thick" />
                </asp:DropDownList>
            </div>


            <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"></asp:CheckBox> Sausage (+ $2.00)</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"></asp:CheckBox> Pepperoni (+ $1.50)</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"></asp:CheckBox> Onions (+ $1.00</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"></asp:CheckBox> Green Peppers (+ $1.00</label></div> 


            <h3>Deliver to:</h3>
            <div class="form-group">
                <label>Name:</label>
                <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Address:</label>
                <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Zip:</label>
                <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Phone:</label>
                <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <h3>Payment:</h3>
                <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" Checked="true" GroupName="PaymentGroup"></asp:RadioButton> Cash</label></div>
                <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="PaymentGroup"></asp:RadioButton> Credit</label></div>

            <asp:Button ID="orderButton" runat="server" Text="Order" OnClick="OrderButton_Click" CssClass="btn btn-lg btn-primary"/>
            <br />
            <br />
            <h5></h5><asp:Label ID="errorLabel" runat="server" Text="" Visible="false" CssClass="bg-danger"></asp:Label></h5>
            <h3>Total Cost:<asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>


        </div>
    </form>

    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
