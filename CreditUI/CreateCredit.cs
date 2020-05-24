using CreditBL.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditUI
{
    public partial class CreateCredit : Form
    {
        CreditContext db;
        decimal Rate;
        int Days;
        //CreditContext db;
        public Client Client { get; set; }
        public Employee Employee { get; set; }
        public Type_of_credit Type_Of_Credit { get; set; }
        public CreateCredit()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //
        {
            decimal amount = AmountNumericUpDown1.Value;
            if (ChooseType.Text == "Стандартный")
            {
                Rate = 1.08M;
                Days = 30;
            }
            else if (ChooseType.Text == "Универсальный")
            {
                Rate = 1.06M;
                Days = 90;
            }
            else
            {
                Days = 60;
                Rate = 1.1M;
            }
            for (int i = 0; i < Days / 30; i++)
            {
                amount = amount * Rate;
            }
            amount = Math.Round(amount, 2);
;            NumericUpDown tb = sender as NumericUpDown; label1.Text = amount.ToString();
        }

        private void CreateCredit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "creditConnectionDataSet2.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.creditConnectionDataSet2.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "creditConnectionDataSet1.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.creditConnectionDataSet1.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "creditConnectionDataSet.Type_of_credit". При необходимости она может быть перемещена или удалена.
            this.type_of_creditTableAdapter.Fill(this.creditConnectionDataSet.Type_of_credit);

        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
