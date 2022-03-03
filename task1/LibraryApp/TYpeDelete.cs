
using LibraryApp.Helper;
using LibraryApp.Model;
using System;
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
    public partial class TYpeDelete : Form
    {
        private readonly LibraryDbEntities2 _db;

        public TYpeDelete()
        {
            InitializeComponent();
            _db = new LibraryDbEntities2();
        }

        private void TYpeDelete_Load(object sender, EventArgs e)
        {
            cmbDeleteType.DataSource = _db.Typesses.Where(t => t.Deleted == false).Select(t => new Cb_Type
            {
                Id = t.Id,
                Name = t.FullName
            }).ToArray();
        }

        private void BtnTypeDelete_Click(object sender, EventArgs e)
        {
            int id = ((Cb_Type)cmbDeleteType.SelectedItem).Id;
            LibraryApp.Model.Typess typess = _db.Typesses.Find(id);
            typess.Deleted = true;
            _db.SaveChanges();
            MessageBox.Show("Succesfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
