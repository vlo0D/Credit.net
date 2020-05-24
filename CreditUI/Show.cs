using CreditBL.Model;
using System;
using System.CodeDom;
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
    public partial class Show : Form
    {
        CreditContext db;
        public Show()
        {
            InitializeComponent();
            //db = new CreditContext();
            //db.Credits.Load();
            //dataGridView1.DataSource = db.Credits.Local.ToBindingList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                db = new CreditContext();
                Credit credit = db.Credits.Find(id);
                db.Credits.Remove(credit);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 )
            {
                int index1 = dataGridView1.SelectedRows[0].Index;


                int id = 0;
                bool converted1 = Int32.TryParse(dataGridView1[0, index1].Value.ToString(), out id);
                if (converted1 == false)
                    return;

                db = new CreditContext();
                Credit credit = db.Credits.Find(id);
                //Type_of_credit type_of_credit = db.Type_Of_Credits.Find(id);
                //Employee employee = db.Employees.Find(id);
                CreateCredit crForm = new CreateCredit();

                crForm.AmountNumericUpDown1.Value = credit.Amount;
                //crForm.chooseClient.Text = credit.Client.Last_Name;
                //crForm.ChooseEmployee.Text = credit.Employee.LastName;
                //crForm.ChooseType.Text = credit.Type_Of_Credit.Name_of_type;

                DialogResult result = crForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                credit.Type_id = (int?)crForm.ChooseType.SelectedValue;
                credit.Client_id = (int?)crForm.chooseClient.SelectedValue;
                credit.Employee_id = (int?)crForm.ChooseEmployee.SelectedValue;
                credit.Date_of_issue = DateTime.Now;
                credit.Amount = crForm.AmountNumericUpDown1.Value;

                Type_of_credit type_Of_Credit = db.Type_Of_Credits.Find(credit.Type_id);
                decimal Rate = type_Of_Credit.Rate;
                int Days = type_Of_Credit.Days;
                decimal amount = credit.Amount;
                for (int i = 0; i < Days / 30; i++)
                {
                    amount = amount * Rate;
                }

                credit.Date_of_repayment = credit.Date_of_issue.AddDays(Days);
                credit.Amount_to_be_paid = amount;
                //client.First_Name = crForm.FirstName.Text;
                //client.Last_Name = crForm.LastName.Text;
                //client.Phone_number = crForm.PhoneNumber.Text;
                //client.Address = crForm.Address.Text;
                //client.Passport_id = crForm.PassportId.Text;
                db.SaveChanges();
                dataGridView1.Refresh(); // обновляем грид
                MessageBox.Show("Данные успешно обновились");
            }



        }

        private void Show_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "creditConnectionDataSet4.Credits". При необходимости она может быть перемещена или удалена.
            this.creditsTableAdapter.Fill(this.creditConnectionDataSet4.Credits);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
