using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_Lab_Csharp.Utilities
{
    public class TextboxValidator
    {
        public static bool IsTextboxEmpty(TextBox textbox)
        {
            if(textbox.Text == "")
            {
                MessageBox.Show(textbox.Tag + " is a required field.", "Entry Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textbox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsDecimal(TextBox textbox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textbox.Text, out number))
                return true;
            else
            {
                MessageBox.Show(textbox.Tag + " should be a decimal value.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Focus();
                return false;
            }
        }
    }
}
