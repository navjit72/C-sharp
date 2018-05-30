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
using Week4_Lab_Csharp.Presentation;

namespace Week4_Lab_Csharp
{
    public partial class FrmInvntMain : Form
    {
        private List<InventoryItem> list = null;
        public FrmInvntMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillData()
        {
            DisplayArea.Items.Clear();
            foreach (InventoryItem item in list)
            {
                DisplayArea.Items.Add(item.DisplayData("\t"));
            }
        }

        private void FrmInvntMain_Load(object sender, EventArgs e)
        {
            list = ItemDB.GetData();
            FillData();
        }

        private void RemoveItem()
        {
            int index = DisplayArea.SelectedIndex;
            if(index !=-1)
            { 
            InventoryItem item = list[index];
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete "+ item.Description+ " ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialog == DialogResult.Yes)
                {
                    list.Remove(item);
                    ItemDB.SaveData(list);
                    FillData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddItem form = new FrmAddItem();
            form.ShowDialog();
            FillData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }
    }
}
