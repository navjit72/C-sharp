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
    public partial class FrmFileHandling : Form
    {
        string path;
        public FrmFileHandling()
        {
            InitializeComponent();
        }

        private bool checkPath()
        {
            if (path == null)
            {
                if (txtCreateFile.Text != "")
                {
                    path = txtCreateFile.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("Path must be defined.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCreateFile.Focus();
                    return false;
                }
            }
            else
                return true;
            
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (checkPath())
            {
                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    lbStatus.Text = "File Created Successfully";
                    txtCreateFile.Text = "";
                    fs.Close();
                }
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if (checkPath())
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(rtxtAddContent.Text);
                    lbStatus.Text = "Data Added Successfully";
                    rtxtAddContent.Text = "";
                }
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (checkPath())
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    rtxtReadContent.Text = sr.ReadToEnd();
                    lbStatus.Text = "Data Retrieved Successfully";
                }
            }
        }
    }
}
