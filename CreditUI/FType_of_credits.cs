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

namespace CreditUI
{
    public partial class FType_of_credits : Form
    {
        CreditContext db;
        public FType_of_credits()
        {
            InitializeComponent();
            db = new CreditContext();
            db.Type_Of_Credits.Load();
            dataGridView1.DataSource = db.Type_Of_Credits.Local.ToBindingList();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Type_of_credit type_Of_Credit = db.Type_Of_Credits.Find(id);
                db.Type_Of_Credits.Remove(type_Of_Credit);
                db.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Type_of_credit type_Of_Credit = db.Type_Of_Credits.Find(id);

                CreateType crForm = new CreateType();

                crForm.textBox1.Text = type_Of_Credit.Name_of_type;
                crForm.numericUpDown1.Value = type_Of_Credit.Rate;
                crForm.numericUpDown2.Value = type_Of_Credit.Days;
                DialogResult result = crForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                type_Of_Credit.Name_of_type = crForm.textBox1.Text;
                type_Of_Credit.Rate = crForm.numericUpDown1.Value;
                type_Of_Credit.Days = (int)crForm.numericUpDown2.Value;


                db.SaveChanges();
                dataGridView1.Refresh(); // обновляем грид
                MessageBox.Show("Список обновлен");

            }
        }
    }
}
