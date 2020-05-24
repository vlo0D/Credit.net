namespace CreditUI
{
    public partial class CreateCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ChooseType = new System.Windows.Forms.ComboBox();
            this.typeofcreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditConnectionDataSet = new CreditUI.CreditConnectionDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.AmountNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.type_of_creditTableAdapter = new CreditUI.CreditConnectionDataSetTableAdapters.Type_of_creditTableAdapter();
            this.ChooseEmployee = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditConnectionDataSet1 = new CreditUI.CreditConnectionDataSet1();
            this.employeesTableAdapter = new CreditUI.CreditConnectionDataSet1TableAdapters.EmployeesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseClient = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditConnectionDataSet2 = new CreditUI.CreditConnectionDataSet2();
            this.label5 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new CreditUI.CreditConnectionDataSet2TableAdapters.ClientsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typeofcreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseType
            // 
            this.ChooseType.DataSource = this.typeofcreditBindingSource;
            this.ChooseType.DisplayMember = "Name_of_type";
            this.ChooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseType.FormattingEnabled = true;
            this.ChooseType.Location = new System.Drawing.Point(151, 118);
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(188, 24);
            this.ChooseType.TabIndex = 2;
            this.ChooseType.ValueMember = "Type_id";
            // 
            // typeofcreditBindingSource
            // 
            this.typeofcreditBindingSource.DataMember = "Type_of_credit";
            this.typeofcreditBindingSource.DataSource = this.creditConnectionDataSet;
            // 
            // creditConnectionDataSet
            // 
            this.creditConnectionDataSet.DataSetName = "CreditConnectionDataSet";
            this.creditConnectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(619, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Создать кредит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AmountNumericUpDown1
            // 
            this.AmountNumericUpDown1.Location = new System.Drawing.Point(575, 285);
            this.AmountNumericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AmountNumericUpDown1.Name = "AmountNumericUpDown1";
            this.AmountNumericUpDown1.Size = new System.Drawing.Size(206, 22);
            this.AmountNumericUpDown1.TabIndex = 12;
            this.AmountNumericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сумма";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Тип кредита";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.BlueViolet;
            this.label11.Font = new System.Drawing.Font("Ink Free", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 31);
            this.label11.TabIndex = 25;
            this.label11.Text = "Credita.NET";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(519, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // type_of_creditTableAdapter
            // 
            this.type_of_creditTableAdapter.ClearBeforeFill = true;
            // 
            // ChooseEmployee
            // 
            this.ChooseEmployee.DataSource = this.employeesBindingSource;
            this.ChooseEmployee.DisplayMember = "LastName";
            this.ChooseEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseEmployee.FormattingEnabled = true;
            this.ChooseEmployee.Location = new System.Drawing.Point(79, 372);
            this.ChooseEmployee.Name = "ChooseEmployee";
            this.ChooseEmployee.Size = new System.Drawing.Size(160, 24);
            this.ChooseEmployee.TabIndex = 28;
            this.ChooseEmployee.ValueMember = "Employee_id";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.creditConnectionDataSet1;
            // 
            // creditConnectionDataSet1
            // 
            this.creditConnectionDataSet1.DataSetName = "CreditConnectionDataSet1";
            this.creditConnectionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Сумма к выплате:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Работник, составляющий кредит:";
            // 
            // chooseClient
            // 
            this.chooseClient.DataSource = this.clientsBindingSource;
            this.chooseClient.DisplayMember = "Last_Name";
            this.chooseClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseClient.FormattingEnabled = true;
            this.chooseClient.Location = new System.Drawing.Point(151, 187);
            this.chooseClient.Name = "chooseClient";
            this.chooseClient.Size = new System.Drawing.Size(188, 24);
            this.chooseClient.TabIndex = 32;
            this.chooseClient.ValueMember = "Client_id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.creditConnectionDataSet2;
            // 
            // creditConnectionDataSet2
            // 
            this.creditConnectionDataSet2.DataSetName = "CreditConnectionDataSet2";
            this.creditConnectionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Выберите клиента:";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 45);
            this.button3.TabIndex = 34;
            this.button3.Text = "Добавить клиента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CreateCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chooseClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseEmployee);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountNumericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChooseType);
            this.Name = "CreateCredit";
            this.Text = "CreateCredit";
            this.Load += new System.EventHandler(this.CreateCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeofcreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox ChooseType;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown AmountNumericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private CreditConnectionDataSet creditConnectionDataSet;
        private System.Windows.Forms.BindingSource typeofcreditBindingSource;
        private CreditConnectionDataSetTableAdapters.Type_of_creditTableAdapter type_of_creditTableAdapter;
        public System.Windows.Forms.ComboBox ChooseEmployee;
        private CreditConnectionDataSet1 creditConnectionDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private CreditConnectionDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox chooseClient;
        private System.Windows.Forms.Label label5;
        private CreditConnectionDataSet2 creditConnectionDataSet2;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private CreditConnectionDataSet2TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}