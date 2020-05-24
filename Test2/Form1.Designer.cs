namespace Test2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.creditConnectionDataSet1 = new Test2.CreditConnectionDataSet1();
            this.typeofcreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_of_creditTableAdapter = new Test2.CreditConnectionDataSet1TableAdapters.Type_of_creditTableAdapter();
            this.typeofcreditBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofcreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofcreditBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.creditConnectionDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // creditConnectionDataSet1
            // 
            this.creditConnectionDataSet1.DataSetName = "CreditConnectionDataSet1";
            this.creditConnectionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeofcreditBindingSource
            // 
            this.typeofcreditBindingSource.DataMember = "Type_of_credit";
            this.typeofcreditBindingSource.DataSource = this.bindingSource1;
            // 
            // type_of_creditTableAdapter
            // 
            this.type_of_creditTableAdapter.ClearBeforeFill = true;
            // 
            // typeofcreditBindingSource1
            // 
            this.typeofcreditBindingSource1.DataMember = "Type_of_credit";
            this.typeofcreditBindingSource1.DataSource = this.bindingSource1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditConnectionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofcreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofcreditBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private CreditConnectionDataSet1 creditConnectionDataSet1;
        private System.Windows.Forms.BindingSource typeofcreditBindingSource;
        private CreditConnectionDataSet1TableAdapters.Type_of_creditTableAdapter type_of_creditTableAdapter;
        private System.Windows.Forms.BindingSource typeofcreditBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}

