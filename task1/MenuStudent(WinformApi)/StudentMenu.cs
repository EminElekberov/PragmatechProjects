﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStudent_WinformApi_
{
    public partial class StudentMenu : Form
    {
        List<Student> _st;
        public StudentMenu(List<Student> st)
        {
            this._st = st;
            InitializeComponent();
            cmbAllShowStudent.Items.AddRange(st.ToArray());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selected_group = cmbAllShowStudent.SelectedItem as Student;
            listBox1.Items.Clear();
            foreach (var item in _st)
            {
                listBox1.Items.Add(item.ToString());
            }
            txtName.Text = selected_group.Name;
            txtSurname.Text = selected_group.Surname;
            txtEmail.Text = selected_group.Email;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(selected_group.Img_Location);

        }
        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbAllShowStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
    }
}
