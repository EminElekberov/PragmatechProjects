﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TYpeDelete typeDelete = new TYpeDelete();
            typeDelete.ShowDialog();
        }

        private void bookLibraryAndTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookLibrary bookLibrary = new BookLibrary();
            bookLibrary.ShowDialog();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            //
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAndAddBook updateAndAddBook = new UpdateAndAddBook();
            updateAndAddBook.ShowDialog();
        }
    }
}
