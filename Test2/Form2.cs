using CreditBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form2 : Form
    {
        CreditContext db;
        public Form2()
        {
            InitializeComponent();
            db = new CreditContext();
            db.Clients.Load();
            dataGridView1.DataSource = db.Clients.Local.ToBindingList();
            db.Type_Of_Credits.Load();
            dataGridView2.DataSource = db.Type_Of_Credits.Local.ToBindingList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
