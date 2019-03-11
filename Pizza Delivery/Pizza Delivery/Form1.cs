/*Programmer: Matthew Moore
   Description: Pizza Delivery Co.
   Date: 12-12-18
*/
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Pizza_Delivery
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Set default values of Size, Crust, and Sauce. Also set all comboBoxes to appear as DropDownLists so users can't mess with them
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            comboSize.Text = comboSize.Items[1].ToString();
            comboCrust.Text = comboCrust.Items[0].ToString();
            comboSauce.Text = comboSauce.Items[0].ToString();
            this.comboSize.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboSauce.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboPizza.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboOther.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Will reset all values back to how the form started
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            comboSize.Text = comboSize.Items[1].ToString();
            comboCrust.Text = comboCrust.Items[0].ToString();
            comboSauce.Text = comboSauce.Items[0].ToString();
            comboPizza.Text = "";
            comboOther.Text = "";
            txtSoda.Text = "0";
            txtWater.Text = "0";
            txtName.Text = "";
            txtDelivery.Text = "";
            listToppings.ClearSelected();
        }

        /// <summary>
        /// Validates the form and also will display information if user input is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == " " || txtDelivery.Text == "" || txtDelivery.Text == " ")
            {
                MessageBox.Show("Please provide customer info for delivery.");
            }
            else if(!Regex.IsMatch(txtSoda.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please make sure the amount of sodas you order is a positive whole number.");
            }
            else if(!Regex.IsMatch(txtWater.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please make sure the amount of water you order is a positive whole number.");
            }
            else
            {
                double sodas = Convert.ToInt32(txtSoda.Text) * 1.75;
                int water = Convert.ToInt32(txtWater.Text);
                double size = Convert.ToDouble(comboSize.Text.Split('$')[1]);
                string sizeText = comboSize.Text;
                string crust = comboCrust.Text;
                string sauce = comboSauce.Text;
                string specialty = comboPizza.Text;
                List<string> toppings = listToppings.SelectedItems.Cast<string>().ToList(); //Puts all selected items into a list
                double toppingCost = 1.5 * toppings.Count;
                double otherItems = 0;
                string otherText = comboOther.Text;
                double pizzaTotal = size + toppingCost;
                string name = txtName.Text;
                string address = txtDelivery.Text;
                
                if(specialty != "")
                {
                    pizzaTotal += 18.95;
                }

                if(comboOther.Text != "")
                {
                    otherItems = Convert.ToDouble(comboOther.Text.Split('$')[1]);
                }

                double totalAmount = pizzaTotal + sodas + otherItems;

                MessageBox.Show($"{crust} - {sizeText}\nSauce: {sauce}\nToppings ($1.50 each):\n{string.Join(Environment.NewLine, toppings)}\n\nSpecialty Pizza - Large $18.95 - {specialty}\n\nPizza Total: ${pizzaTotal:n2}\n\nDrink Selection:\n{Convert.ToDouble(txtSoda.Text)} Soda(s)\n{water} Water(s)\nDrink Total: ${sodas:n2}\n\nSpecialty Items:\n{otherText}\n\nAmount Due: ${totalAmount:n2}\n\n\nDeliver to: {name}, {address}");
            }
        }
    }
}
