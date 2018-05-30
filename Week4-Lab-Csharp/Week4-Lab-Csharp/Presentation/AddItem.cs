using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week4_Lab_Csharp.Business;
using Week4_Lab_Csharp.Data;
using Week4_Lab_Csharp.Utilities;

namespace Week4_Lab_Csharp.Presentation
{
    public partial class FrmAddItem : Form
    {
        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidData()
        {
            if (TextboxValidator.IsTextboxEmpty(txtItemNo))
                if (TextboxValidator.IsTextboxEmpty(txtDesc))
                    if (TextboxValidator.IsTextboxEmpty(txtPrice))
                        if (TextboxValidator.IsDecimal(txtPrice))
                            return true;
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsValidData())
               {
                List<InventoryItem> list = ItemDB.GetData();
                InventoryItem item = new InventoryItem(txtItemNo.Text, txtDesc.Text, Convert.ToDecimal(txtPrice.Text));
                list.Add(item);
                ItemDB.SaveData(list);
                txtItemNo.Clear();
                txtDesc.Clear();
                txtPrice.Clear();
               }
        }
    }
}
