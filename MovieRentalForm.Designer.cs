namespace LAB_movies.v2_
{
    partial class MovieRentalForm
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
            txtRentalFee = new TextBox();
            txtDeposit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cmbCinema = new ComboBox();
            cmbMovie = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btnSaveRental = new Button();
            listBox1 = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtRentalFee
            // 
            txtRentalFee.Location = new Point(71, 70);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.RightToLeft = RightToLeft.No;
            txtRentalFee.Size = new Size(196, 23);
            txtRentalFee.TabIndex = 0;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(71, 114);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.RightToLeft = RightToLeft.No;
            txtDeposit.Size = new Size(196, 23);
            txtDeposit.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 52);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Стоимость аренды";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 96);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Депозит";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(71, 158);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.RightToLeft = RightToLeft.No;
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(71, 204);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.RightToLeft = RightToLeft.No;
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 140);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(74, 15);
            label3.TabIndex = 6;
            label3.Text = "Дата начала";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 184);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "Дата окончания";
            // 
            // cmbCinema
            // 
            cmbCinema.FormattingEnabled = true;
            cmbCinema.Location = new Point(71, 247);
            cmbCinema.Name = "cmbCinema";
            cmbCinema.RightToLeft = RightToLeft.No;
            cmbCinema.Size = new Size(200, 23);
            cmbCinema.TabIndex = 8;
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(71, 292);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.RightToLeft = RightToLeft.No;
            cmbMovie.Size = new Size(200, 23);
            cmbMovie.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 230);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(120, 15);
            label5.TabIndex = 10;
            label5.Text = "Выберите кинотеатр";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 273);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(102, 15);
            label6.TabIndex = 11;
            label6.Text = "Выберите фильм";
            // 
            // btnSaveRental
            // 
            btnSaveRental.Location = new Point(71, 335);
            btnSaveRental.Name = "btnSaveRental";
            btnSaveRental.Size = new Size(196, 37);
            btnSaveRental.TabIndex = 12;
            btnSaveRental.Text = "Сохранить";
            btnSaveRental.UseVisualStyleBackColor = true;
            btnSaveRental.Click += btnSaveRental_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(358, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 214);
            listBox1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(358, 335);
            button2.Name = "button2";
            button2.Size = new Size(196, 37);
            button2.TabIndex = 14;
            button2.Text = "Отобразить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MovieRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(btnSaveRental);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbMovie);
            Controls.Add(cmbCinema);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDeposit);
            Controls.Add(txtRentalFee);
            Name = "MovieRentalForm";
            Text = "MovieRentalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRentalFee;
        private TextBox txtDeposit;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private Label label4;
        private ComboBox cmbCinema;
        private ComboBox cmbMovie;
        private Label label5;
        private Label label6;
        private Button btnSaveRental;
        private ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
    }
}