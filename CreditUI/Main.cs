
using CreditBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditUI
{
    public partial class Main : Form
    {
        CreditContext db;
        public Main()
        {
            InitializeComponent();

            db = new CreditContext();
            if (db.Status.Count() < 2)
            {
                Status inprocess = new Status
                {
                    Status_name = "In the process"
                };
                Status paidout = new Status
                {
                    Status_name = "Paid out"
                };
                db.Status.Add(inprocess);
                db.Status.Add(paidout);
                db.SaveChanges();
            }
            //if (db.Type_Of_Credits.Count()<2)
            //    {
            //    Type_of_credit standart = new Type_of_credit
            //    {
            //        Name_of_type = "Стандартный",
            //        Days = 30,
            //        Rate = 1.08M
            //    };
            //    Type_of_credit universal = new Type_of_credit
            //    {
            //        Name_of_type = "Универсальный", Days = 90, Rate=1.06M
                    
            //    };
            //    db.Type_Of_Credits.Add(standart);
            //    db.Type_Of_Credits.Add(universal);
            //    db.SaveChanges();


            //}
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CreateCredit newForm = new CreateCredit();
            DialogResult result = newForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            Credit credit = new Credit();
            credit.Type_id = (int?)newForm.ChooseType.SelectedValue;
            credit.Client_id = (int?)newForm.chooseClient.SelectedValue;
            credit.Employee_id = (int?)newForm.ChooseEmployee.SelectedValue;
            credit.Date_of_issue = DateTime.Now;
            credit.Amount = newForm.AmountNumericUpDown1.Value;

            Type_of_credit type_Of_Credit = db.Type_Of_Credits.Find(credit.Type_id);
            decimal Rate = type_Of_Credit.Rate;
            int Days = type_Of_Credit.Days;
            decimal amount = credit.Amount;
            credit.Date_of_repayment = credit.Date_of_issue.AddDays(Days);
            for (int i = 0; i < Days / 30; i++)
            {
                amount = amount * Rate;
            }
            credit.Amount_to_be_paid = amount;
            db.Credits.Add(credit);
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show newform= new Show();
            newform.Show();
            //db = new CreditContext();
            //var newform = new ShowCredits<Client>(db.Clients, db);
            //newform.Show();
            ////DialogResult result = newform.ShowDialog(this);
            ////if (result == DialogResult.Cancel)
            ////    return;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEmployee createemployee = new CreateEmployee();
            DialogResult result = createemployee.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            db = new CreditContext();
            Employee employee = new Employee();

            employee.FirstName = createemployee.EmployeeName.Text;
            employee.LastName = createemployee.EmployeeLastName.Text;
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient();
            DialogResult result = createClient.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            db = new CreditContext();
            Client client = new Client();
            client.First_Name = createClient.FirstName.Text;
            client.Last_Name = createClient.LastName.Text;
            client.Phone_number = createClient.PhoneNumber.Text;
            client.Address = createClient.Address.Text;
            client.Passport_id = createClient.PassportId.Text;
            if (createClient.FirstName.Text == "" || createClient.LastName.Text == "" || createClient.PhoneNumber.Text == "" || createClient.Address.Text == "" || createClient.PassportId.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;

            }
            else
            {
                db.Clients.Add(client);
                db.SaveChanges();
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClients fClients = new FClients();
            fClients.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEmployee fEmployee = new FEmployee();
            fEmployee.Show();

        }

        private void typeOfCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FType_of_credits newform = new FType_of_credits();
            newform.Show();
        }

        private void добавитьTypeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateType createType = new CreateType();
            DialogResult result = createType.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            db = new CreditContext();
            Type_of_credit type_Of_Credit = new Type_of_credit();
            type_Of_Credit.Name_of_type = createType.textBox1.Text;
            type_Of_Credit.Rate = createType.numericUpDown1.Value;
            type_Of_Credit.Days = (int)createType.numericUpDown2.Value;
            db.Type_Of_Credits.Add(type_Of_Credit);
            db.SaveChanges();

        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
