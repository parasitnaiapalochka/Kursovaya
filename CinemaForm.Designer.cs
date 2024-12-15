namespace LAB_movies.v2_
{
    partial class CinemaForm
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
            button1 = new Button();
            label5 = new Label();
            txtSeatCount = new TextBox();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            txtCinemaName = new TextBox();
            label1 = new Label();
            cmbDirector = new ComboBox();
            cmbOwner = new ComboBox();
            label6 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(87, 329);
            button1.Name = "button1";
            button1.Size = new Size(191, 49);
            button1.TabIndex = 21;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 226);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 19;
            label5.Text = "Человек";
            // 
            // txtSeatCount
            // 
            txtSeatCount.Location = new Point(87, 194);
            txtSeatCount.Name = "txtSeatCount";
            txtSeatCount.Size = new Size(191, 23);
            txtSeatCount.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 176);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 17;
            label4.Text = "Кол-во мест";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(87, 150);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(191, 23);
            txtPhoneNumber.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 132);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 15;
            label3.Text = "Номер телефона";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(87, 106);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(191, 23);
            txtAddress.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 88);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Адрес";
            // 
            // txtCinemaName
            // 
            txtCinemaName.Location = new Point(87, 62);
            txtCinemaName.Name = "txtCinemaName";
            txtCinemaName.Size = new Size(191, 23);
            txtCinemaName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 11;
            label1.Text = "Имя кинотеатра";
            // 
            // cmbDirector
            // 
            cmbDirector.FormattingEnabled = true;
            cmbDirector.Location = new Point(87, 244);
            cmbDirector.Name = "cmbDirector";
            cmbDirector.Size = new Size(191, 23);
            cmbDirector.TabIndex = 22;
            // 
            // cmbOwner
            // 
            cmbOwner.FormattingEnabled = true;
            cmbOwner.Location = new Point(87, 290);
            cmbOwner.Name = "cmbOwner";
            cmbOwner.Size = new Size(191, 23);
            cmbOwner.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 272);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 23;
            label6.Text = "Юридическое лицо";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(428, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 199);
            listBox1.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(443, 329);
            button2.Name = "button2";
            button2.Size = new Size(191, 49);
            button2.TabIndex = 26;
            button2.Text = "Отобразить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CinemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(cmbOwner);
            Controls.Add(label6);
            Controls.Add(cmbDirector);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtSeatCount);
            Controls.Add(label4);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtCinemaName);
            Controls.Add(label1);
            Name = "CinemaForm";
            Text = "CinemaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox txtSeatCount;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label3;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtCinemaName;
        private Label label1;
        private ComboBox cmbDirector;
        private ComboBox cmbOwner;
        private Label label6;
        private ListBox listBox1;
        private Button button2;
    }
}