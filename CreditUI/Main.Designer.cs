namespace CreditUI
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьTypeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Credit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Credits";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.BlueViolet;
            this.label11.Font = new System.Drawing.Font("Ink Free", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(364, 75);
            this.label11.TabIndex = 26;
            this.label11.Text = "Credita.NET";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 35);
            this.button3.TabIndex = 27;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.typeOfCreditToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр данных";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // добавитьEmployeeToolStripMenuItem
            // 
            this.добавитьEmployeeToolStripMenuItem.Name = "добавитьEmployeeToolStripMenuItem";
            this.добавитьEmployeeToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.добавитьEmployeeToolStripMenuItem.Text = "Добавить";
            this.добавитьEmployeeToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // typeOfCreditToolStripMenuItem
            // 
            this.typeOfCreditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьTypeToolStripMenuItem2});
            this.typeOfCreditToolStripMenuItem.Name = "typeOfCreditToolStripMenuItem";
            this.typeOfCreditToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.typeOfCreditToolStripMenuItem.Text = "Type of  credit";
            this.typeOfCreditToolStripMenuItem.Click += new System.EventHandler(this.typeOfCreditToolStripMenuItem_Click);
            // 
            // добавитьTypeToolStripMenuItem2
            // 
            this.добавитьTypeToolStripMenuItem2.Name = "добавитьTypeToolStripMenuItem2";
            this.добавитьTypeToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.добавитьTypeToolStripMenuItem2.Text = "Добавить";
            this.добавитьTypeToolStripMenuItem2.Click += new System.EventHandler(this.добавитьTypeToolStripMenuItem2_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьClientToolStripMenuItem1});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // добавитьClientToolStripMenuItem1
            // 
            this.добавитьClientToolStripMenuItem1.Name = "добавитьClientToolStripMenuItem1";
            this.добавитьClientToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.добавитьClientToolStripMenuItem1.Text = "Добавить";
            this.добавитьClientToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Credita.net";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem typeOfCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьTypeToolStripMenuItem2;
    }
}