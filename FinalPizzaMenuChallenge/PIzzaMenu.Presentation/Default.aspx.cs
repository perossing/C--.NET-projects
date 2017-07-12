using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaMenu.DTO.Enums;

namespace PizzaMenu.Presentation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a name.";
                errorLabel.Visible = true;
                return;
            }

            if (addressTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter an address.";
                errorLabel.Visible = true;
                return;
            }

            if (zipTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a ZIP code";
                errorLabel.Visible = true;
                return;
            }

            if (phoneTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a phone number";
                errorLabel.Visible = true;
                return;
            }

            try
            {
                var order = buildOrder();
                Domain.OrderManager.CreateOrder(order);
                Response.Redirect("success.aspx");
            }
            catch (Exception ex)
            {
                errorLabel.Text = "";
                errorLabel.Visible = true;
                return;
            }
        }

        private DTO.Enums.SizeType determineSize()
        {
           DTO.Enums.SizeType size;
           if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Please select a pizza size");
            }
            return size;            
        }

        private DTO.Enums.CrustType determineCrust()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Please select a pizza crust");
            }
            return crust;
        }

        private DTO.Enums.PaymentType determinePaymentType()
        {
            DTO.Enums.PaymentType paymentType;
            if (cashRadioButton.Checked) { paymentType = DTO.Enums.PaymentType.Cash; }
            else if (creditRadioButton.Checked) { paymentType = DTO.Enums.PaymentType.Credit; }
            else
            {
                throw new Exception("Please select a method of payment");
            }
            return paymentType;
        }

        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == String.Empty) { return;  }
            if (crustDropDownList.SelectedValue == String.Empty) { return; }

            var order = buildOrder();

            try
            {
                totalLabel.Text = Domain.PriceManager.CalculateCost(order).ToString("C");
            }
            catch
            {
                // not handling error for now
            }

        }

        private DTO.OrderDTO buildOrder()
        {
            var order = new DTO.OrderDTO();
            order.Size = determineSize();
            order.Crust = determineCrust();
            order.Sausage = sausageCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = greenPeppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Phone = phoneTextBox.Text;
            order.Zip = zipTextBox.Text;
            order.PaymentType = determinePaymentType();

            return order;
        }
    }
}