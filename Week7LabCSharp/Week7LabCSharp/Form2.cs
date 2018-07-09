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
    public partial class FrmStudentManagement : Form
    {
        string path;
        public FrmStudentManagement()
        {
            InitializeComponent();
        }

        private bool IsValidId()
        {
            if (txtId.Text == "")
                throw new Exception("Student Id is a required field.");
            else
            {
                foreach (char c in txtId.Text)
                {
                    if (!Char.IsDigit(c))
                        throw new Exception("Student Id can only contain digits.");
                }
                return true;
            }
        }

        private bool IsDataValid(TextBox txtbox)
        {
            if (txtbox.Text == "")
                throw new Exception(txtbox.Tag +" is a required field.");
            else
            {
                foreach (char c in txtbox.Text)
                {
                    if ((!Char.IsLetter(c)) && (!Char.IsWhiteSpace(c)))
                        throw new Exception(txtbox.Tag + " can only contain letters.");
                }
                return true;
            }
        }

        private bool IsDurationValid()
        {
            if (txtDuration.Text == "")
                throw new Exception("Duration is a required field.");
            else
            {
                foreach (char c in txtDuration.Text)
                {
                    if ((!Char.IsLetter(c)) && (!Char.IsDigit(c)) && (!Char.IsWhiteSpace(c)))
                        throw new Exception("Duration can only contain letters and digits.");
                }
                return true;
            }
        }


        private void RefreshData()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtCourse.Text = "";
            txtDuration.Text = "";
        }

        private void WriteData()
        {
            if (IsValidId())
                if (IsDataValid(txtName))
                    if (IsDataValid(txtCourse))
                        if (IsDurationValid())
                        {
                            using (StreamWriter sw = new StreamWriter(path))
                            {
                                sw.WriteLine(lblId.Text + " " + txtId.Text);
                                sw.WriteLine(lblName.Text + " " + txtName.Text);
                                sw.WriteLine(lblCourse.Text + " " + txtCourse.Text);
                                sw.WriteLine(lblDuration.Text + " " + txtDuration.Text);
                            }
                        }
        }

        private void ReadData(string tPath)
        {
            string[] userId,userName,userCourse,userDuration;
            string id="", name="", course="", duration="";
            using (StreamReader sr = new StreamReader(tPath))
            {
                userId = sr.ReadLine().Split(' ');
                userName = sr.ReadLine().Split(' ');
                userCourse = sr.ReadLine().Split(' ');
                userDuration = sr.ReadLine().Split(' ');
            }
            for (int i = 2; i < userId.Length; i++)
            {
                id += userId[i];
                if (i != userId.Length - 1)
                    id += " ";
            }

            for (int i = 1; i < userName.Length; i++)
            {
                name += userName[i];
                if (i != userName.Length - 1)
                    name += " ";
            }
            for (int i = 1; i < userCourse.Length; i++)
            {
                course += userCourse[i];
                if (i != userCourse.Length - 1)
                    course += " ";
            }
            for (int i = 1; i < userDuration.Length; i++)
            {
                duration += userDuration[i];
                if (i != userDuration.Length - 1)
                    duration += " ";
            }
            txtId.Text = id;
            txtName.Text = name;
            txtCourse.Text = course;
            txtDuration.Text = duration;
            lblStatus.Text = "Data Retrieved Successfully";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                path = @"D:\" + txtName.Text + "_" + txtId.Text + ".txt";
                if (File.Exists(path))
                {
                    if (MessageBox.Show("This file already exists. Do you want to overwrite the data?", "File present", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WriteData();
                        lblStatus.Text = "File overwritten successfully";
                        RefreshData();
                    }
                }
                else
                {
                    WriteData();
                    lblStatus.Text = "File Created Successfully";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Handled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter your name: ", "User Name");
            string id = Interaction.InputBox("Enter your student id: ", "User Id");
            string tempPath = @"D:\" + name + "_" + id + ".txt";
            if (File.Exists(tempPath))
                ReadData(tempPath);
            else
                MessageBox.Show("No file with provided data exists. Try again", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
