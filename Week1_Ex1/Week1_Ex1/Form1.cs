using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_Ex1
{
    public partial class frmFinancialCalculator : Form
    {
        public frmFinancialCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the application...");
            Application.Exit();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            decimal subTotal = Convert.ToDecimal(txtSubTotal.Text);
            decimal discountPercent = 0m;
            if (subTotal>=500)
            {
                discountPercent = .2m;
            }
            else if (subTotal>=250 && subTotal<500)
            {
                discountPercent = .15m;
            }
            else if (subTotal>=100 && subTotal<250)
            {
                discountPercent = .1m;
            }
            decimal discountAmount = subTotal * discountPercent;
            decimal invoiceTotal = subTotal - discountAmount;
            txtDiscount.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
            txtSubTotal.Focus();
            txtSubTotal.ReadOnly = true;
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            txtDiscount.Text = "";
            txtDiscountAmount.Text = "";
            txtTotal.Text = "";

            if(txtSubTotal.TextLength>0)
            {
                btnCompute.Enabled = true;
            }
            else
            {
                btnCompute.Enabled = false;
            }
        }
    }
}
