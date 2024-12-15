namespace LAB_movies.v2_
{
    partial class MovieForm
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
            panel1 = new Panel();
            btnSaveMovie = new Button();
            label12 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            listBox1 = new ListBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnSaveMovie
            // 
            btnSaveMovie.Location = new Point(117, 355);
            btnSaveMovie.Name = "btnSaveMovie";
            btnSaveMovie.Size = new Size(170, 41);
            btnSaveMovie.TabIndex = 0;
            btnSaveMovie.Text = "Сохранить";
            btnSaveMovie.UseVisualStyleBackColor = true;
            btnSaveMovie.Click += btnSaveMovie_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(218, 51);
            label12.Name = "label12";
            label12.Size = new Size(111, 15);
            label12.TabIndex = 23;
            label12.Text = "Категории фильма";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ACTION,", "THRILLER,", "COMEDY,", "DRAMA,", "HORROR,", "OTHER" });
            comboBox1.Location = new Point(218, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 227);
            label11.Name = "label11";
            label11.Size = new Size(122, 15);
            label11.TabIndex = 21;
            label11.Text = "Год выпуска фильма";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(21, 245);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(170, 23);
            textBox11.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 183);
            label10.Name = "label10";
            label10.Size = new Size(118, 15);
            label10.TabIndex = 19;
            label10.Text = "Название компании";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(21, 201);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(170, 23);
            textBox10.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 139);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 17;
            label9.Text = "Имя режиссера";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(21, 157);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(170, 23);
            textBox9.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(218, 95);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 15;
            label8.Text = "Счет поставщика";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(218, 113);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(170, 23);
            textBox8.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 139);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 13;
            label7.Text = "ИНН";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(218, 157);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(170, 23);
            textBox7.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 227);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 11;
            label6.Text = "Название поставщика";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(219, 245);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(170, 23);
            textBox6.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 183);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 9;
            label5.Text = "Адрес поставщика";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(219, 201);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 23);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 271);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Имя поставщика";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(219, 289);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 271);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "Стоимость фильма";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 95);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Имя сценариста";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 51);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Название фильма";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(listBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(417, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 450);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSaveMovie);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox7);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 450);
            panel2.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(64, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(243, 139);
            listBox1.TabIndex = 0;            // 
            // button1
            // 
            button1.Location = new Point(97, 214);
            button1.Name = "button1";
            button1.Size = new Size(170, 41);
            button1.TabIndex = 1;
            button1.Text = "Отобразить";
            button1.UseVisualStyleBackColor = true;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MovieForm";
            Text = "MovieForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private TextBox textBox11;
        private Label label10;
        private TextBox textBox10;
        private Label label9;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel2;
        private Label label12;
        private ComboBox comboBox1;
        private Button btnSaveMovie;
        private Button button1;
        private ListBox listBox1;
    }
}