namespace LAB_movies.v2_
{
    partial class SupplierForm
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
            label1 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label2 = new Label();
            txtBankName = new TextBox();
            label3 = new Label();
            txtAccountNumber = new TextBox();
            label4 = new Label();
            txtTaxId = new TextBox();
            label5 = new Label();
            button1 = new Button();
            listBoxSuppliers = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 39);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Название компании";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(87, 101);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(191, 23);
            txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Адрес";
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(87, 145);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(191, 23);
            txtBankName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 127);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Банк";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(87, 189);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(191, 23);
            txtAccountNumber.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 171);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 6;
            label4.Text = "Номер счета";
            // 
            // txtTaxId
            // 
            txtTaxId.Location = new Point(87, 239);
            txtTaxId.Name = "txtTaxId";
            txtTaxId.Size = new Size(191, 23);
            txtTaxId.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 221);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 8;
            label5.Text = "ИНН";
            // 
            // button1
            // 
            button1.Location = new Point(87, 292);
            button1.Name = "button1";
            button1.Size = new Size(191, 49);
            button1.TabIndex = 10;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxSuppliers
            // 
            listBoxSuppliers.FormattingEnabled = true;
            listBoxSuppliers.ItemHeight = 15;
            listBoxSuppliers.Location = new Point(364, 39);
            listBoxSuppliers.Name = "listBoxSuppliers";
            listBoxSuppliers.Size = new Size(371, 229);
            listBoxSuppliers.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(364, 292);
            button2.Name = "button2";
            button2.Size = new Size(191, 49);
            button2.TabIndex = 12;
            button2.Text = "Отобразить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBoxSuppliers);
            Controls.Add(button1);
            Controls.Add(txtTaxId);
            Controls.Add(label5);
            Controls.Add(txtAccountNumber);
            Controls.Add(label4);
            Controls.Add(txtBankName);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "SupplierForm";
            Text = "SupplierForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtBankName;
        private TextBox textBox3;
        private Label label3;
        private TextBox txtAccountNumber;
        private TextBox textBox4;
        private Label label4;
        private TextBox txtTaxId;
        private Label label5;
        private Button button1;
        private ListBox listBoxSuppliers;
        private Button button2;
    }
}