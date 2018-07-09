using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7LabCSharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"D:\";
            sfd.FileName = "untitled.txt";
            sfd.DefaultExt = "*.txt";
            sfd.Filter = "text files (*.txt)|(*.txt)";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                Stream str = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(str);
                sw.Write(rtxtData.Text);
                sw.Close();
                str.Close();
                rtxtData.Text = "";
                MessageBox.Show("Data saved successfully");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            ofd.DefaultExt = "*.txt";
           // string path = @"D:\" + file + ".txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream str = ofd.OpenFile();
                StreamReader sr = new StreamReader(str);
                rtxtData.Text = sr.ReadToEnd();
                sr.Close();
                str.Close();
                
            }
        }
    }
}
