using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {

        Cashier cashier;
        frmPurchaseDiscountedItem Form = new frmPurchaseDiscountedItem();
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            cashier = new Cashier("Clarisa Castro", "Finance", "cashier101", "password");
            bool Valid = cashier.ValidatingLogin(txtUsername.Text, txtPassword.Text);
            if (Valid == true)
            {
                this.Hide();
                string WelcomeMessage = ("Welcome " + cashier.getFullName().ToString() + " of " + cashier.getDepartent().ToString());

                MessageBox.Show(WelcomeMessage, "Login sucessfully", MessageBoxButtons.OK);
                Form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password.\nPlease try again.", "Login unsucessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoginAccount_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void frmLoginAccount_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

