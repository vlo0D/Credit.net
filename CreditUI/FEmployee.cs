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
    public partial class FEmployee : Form
    {
        CreditContext db;

        public FEmployee()
        {
            InitializeComponent();
            db = new CreditContext();

            db.Employees.Load();
            dataGridView1.DataSource = db.Employees.Local.ToBindingList();
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

                Employee employee = db.Employees.Find(id);
                db.Employees.Remove(employee);
                db.SaveChanges();

                MessageBox.Show("Сотрудник удален");
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

                Employee employee = db.Employees.Find(id);

                CreateEmployee crForm = new CreateEmployee();

                crForm.EmployeeName.Text = employee.FirstName;
                crForm.EmployeeLastName.Text = employee.LastName;

                DialogResult result = crForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                employee.FirstName = crForm.EmployeeName.Text;
                employee.LastName = crForm.EmployeeLastName.Text;

                db.SaveChanges();
                dataGridView1.Refresh(); // обновляем грид
                MessageBox.Show("Список обновлен");

            }
        }
    }
}
