using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Lab_CSharp
{
    public partial class frmFVForm : Form
    {
        public frmFVForm()
        {
            InitializeComponent();
        }

        private bool IsDataPresent(TextBox txtbox, string name)
        {
            if (txtbox.Text != "")
                return true;
            else
            {
                throw new CustomException(name + " must have a value.");
                txtbox.Focus();
                return false;
            }
        }

        private bool IsDataFormatValid(TextBox txtbox, string name)
        {
            decimal num = 0m;
            if (Decimal.TryParse(txtbox.Text, out num))
                return true;
            else
            {
                throw new CustomException(name + " should have a number.");
                //MessageBox.Show(name + " should have a number.", "Entry Error");
                txtbox.Focus();
                return false;
            }
        }

        private bool IsDataInRange(TextBox txtbox, string name, double min, double max)
        {
            double num = Convert.ToDouble(txtbox.Text);
            if (num >= min && num <= max)
                return true;
            else
            {
                throw new CustomException(name + " should be in (" + min + "-" + max + ") range.");
               // MessageBox.Show(name + " should be in ("+min+"-"+max+") range.","Entry Error");
                txtbox.Focus();
                return false;
            }
        }

        private bool IsDataValid()
        {
            if (IsDataPresent(txtMonInvest, "Monthly Investment") && IsDataFormatValid(txtMonInvest, "Monthly Investment") && IsDataInRange(txtMonInvest, "Monthly Investment", 0, 1000))
                if (IsDataPresent(txtYearlyIntRate, "Yearly Interest Rate") && IsDataFormatValid(txtYearlyIntRate, "Yearly Interest Rate") && IsDataInRange(txtYearlyIntRate, "Yearly Interest Rate", 1, 20))
                    if (IsDataPresent(txtNumOfYears, "Number of Years") && IsDataFormatValid(txtNumOfYears, "Number of Years") && IsDataInRange(txtNumOfYears, "Number of Years", 1, 10))
                        return true;
            return false;
        }

        private decimal CalculateValue(decimal monInvest, decimal monRate, int months)
        {
            decimal futureVal = 0m;
            for(int i=0;i<months;i++)
            {
                futureVal = (futureVal + monInvest) * (1 + monRate);
            }
            return futureVal;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsDataValid())
                {
                    decimal monInvest = Convert.ToDecimal(txtMonInvest.Text);
                    decimal yearlyIntRate = Convert.ToDecimal(txtYearlyIntRate.Text);
                    int years = Convert.ToInt32(txtNumOfYears.Text);
                    int months = years * 12;
                    decimal monIntRate = yearlyIntRate / 12 / 100;
                    decimal futureValue = CalculateValue(monInvest, monIntRate, months);
                    txtFutureValue.Text = futureValue.ToString("c");

                }
            }
            catch(CustomException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message + " " + exp.StackTrace.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
