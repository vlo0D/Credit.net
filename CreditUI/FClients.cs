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
    public partial class FClients : Form
    {
        CreditContext db;
        public FClients()
        {
            InitializeComponent();
            db = new CreditContext();
            db.Clients.Load();
            dataGridView1.DataSource = db.Clients.Local.ToBindingList();
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

                Client client = db.Clients.Find(id);
                db.Clients.Remove(client);
                db.SaveChanges();

                MessageBox.Show("Клиент удален");
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

                Client client = db.Clients.Find(id);

                CreateClient crForm = new CreateClient();

                crForm.FirstName.Text = client.First_Name;
                crForm.LastName.Text = client.Last_Name;
                crForm.PhoneNumber.Text = client.Phone_number;
                crForm.Address.Text = client.Address;
                crForm.PassportId.Text = client.Passport_id;


                DialogResult result = crForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                client.First_Name = crForm.FirstName.Text;
                client.Last_Name = crForm.LastName.Text;
                client.Phone_number = crForm.PhoneNumber.Text;
                client.Address = crForm.Address.Text;
                client.Passport_id = crForm.PassportId.Text;

                db.SaveChanges();
                dataGridView1.Refresh(); // обновляем грид
                MessageBox.Show("Список обновлен");

            }
        }
    }
}
