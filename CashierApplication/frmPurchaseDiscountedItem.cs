using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        DiscountedItem discountItem;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void yoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            discountItem = new DiscountedItem(txtItem.Text, Convert.ToDouble(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtDiscount.Text));

            lblTotalAmountValue.Text = discountItem.GetTotalPrice().ToString();
        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalAmountValue_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            discountItem.SetPayment(Convert.ToDouble(txtPaymentReceived.Text));
            lblChangeAmount.Text = discountItem.GetChange().ToString();
        }

        private void frmPurchaseDiscountedItem_FormClosing(object sender, FormClosingEventArgs e)
        {



        }

        private void frmPurchaseDiscountedItem_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount Form = new frmLoginAccount();
            this.Hide();
            Form.ShowDialog();
        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection Form = Application.OpenForms;
            if (Form != null && Form.Count > 0)
            {

                for (int i = 0; i < Form.Count; i++)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}