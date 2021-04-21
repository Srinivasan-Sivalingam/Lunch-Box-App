using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is a Lunch Order application calculates the order subtotal, tax and total
//Application created on April 20 2021 by Srinivasan Sivalingam

namespace Lunch_Order
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        /*User can select the main course and add on based on that the subtotal, tax and total 
        will be calculated and displayed in cureency format*/
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (btnHamburger.Checked == true)
            {
                double btnHamburger = 6.95;
                double HamburgerAddon = 0.75;
                double AddOn = 0;
                if (LTObtn.Checked) AddOn += HamburgerAddon;
                if (KMMbtn.Checked) AddOn += HamburgerAddon;
                if (FFbtn.Checked) AddOn += HamburgerAddon;

                double Subtotal = btnHamburger + AddOn;
                double Tax = 5.00 / 100;
                double OrderTotal = (Subtotal*Tax) + Subtotal;

                txtSubtotal.Text = (Subtotal).ToString("c");
                txtTax.Text = (Tax*Subtotal).ToString("c");
                txtOrderTotal.Text = (OrderTotal).ToString("c");
            }
            else if(btnPizza.Checked == true)
            {
                double btnPizza = 5.95;
                double PizzaAddon = 0.50;
                double AddOn = 0;
                if (LTObtn.Checked) AddOn += PizzaAddon;
                if (KMMbtn.Checked) AddOn += PizzaAddon;
                if (FFbtn.Checked) AddOn += PizzaAddon;

                double Subtotal = btnPizza + AddOn;
                double Tax = 5.0 / 100;
                double OrderTotal = (Tax * Subtotal) + Subtotal;

                txtSubtotal.Text = (Subtotal).ToString("c");
                txtTax.Text = (Tax * Subtotal).ToString("c");
                txtOrderTotal.Text = (OrderTotal).ToString("c");
            }
            else if (btnSalad.Checked == true)
            {
                double btnSalad = 4.95;
                double SaladAddon = 0.25;
                double AddOn = 0;
                if (LTObtn.Checked) AddOn += SaladAddon;
                if (KMMbtn.Checked) AddOn += SaladAddon;
                if (FFbtn.Checked) AddOn += SaladAddon;

                double Subtotal = btnSalad + AddOn;
                double Tax = 5.0 / 100;
                double OrderTotal = (Tax * Subtotal) + Subtotal;

                txtSubtotal.Text = (Subtotal).ToString("c");
                txtTax.Text = (Tax * Subtotal).ToString("c");
                txtOrderTotal.Text = (OrderTotal).ToString("c");
            }
        }

        //This exits the application when pressing on Exit button   
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // When pressing on Reset button resets the check boxes and text boxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            LTObtn.Checked = false;
            KMMbtn.Checked = false;
            FFbtn.Checked = false;
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtOrderTotal.Text = "";
        }

        //This will display the add-on option for Hamburger main course
        private void btnHamburger_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Text = "Add-on items $0.75/each";
            LTObtn.Text = "Lettuce, tomato, and onion";
            KMMbtn.Text = "Ketchup, mustard, and mayo";
            FFbtn.Text = "French fries";
        }

        //This will display the add-on option for Pizza main course
        private void btnPizza_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Text = "Add-on items $0.50/each";
            LTObtn.Text = "Pepperoni";
            KMMbtn.Text = "Sasuage";
            FFbtn.Text = "Olives";
        }

        //This will display the add-on option for Salad main course
        private void btnSalad_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Text = "Add-on items $0.25/each";
            LTObtn.Text = "Croutons";
            KMMbtn.Text = "Bacon bits";
            FFbtn.Text = "Bread Sticks";
        }
    }
}
