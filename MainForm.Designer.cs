namespace LAB_movies.v2_
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMovieForm = new Button();
            btnSupplierForm = new Button();
            btnMovieRentalForm = new Button();
            btnCinemaForm = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnMovieForm);
            flowLayoutPanel1.Controls.Add(btnSupplierForm);
            flowLayoutPanel1.Controls.Add(btnMovieRentalForm);
            flowLayoutPanel1.Controls.Add(btnCinemaForm);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMovieForm
            // 
            btnMovieForm.Location = new Point(3, 3);
            btnMovieForm.Name = "btnMovieForm";
            btnMovieForm.Size = new Size(197, 52);
            btnMovieForm.TabIndex = 1;
            btnMovieForm.Text = "Фильмы";
            btnMovieForm.UseVisualStyleBackColor = true;
            btnMovieForm.Click += btnMovieForm_Click;
            // 
            // btnSupplierForm
            // 
            btnSupplierForm.Location = new Point(3, 61);
            btnSupplierForm.Name = "btnSupplierForm";
            btnSupplierForm.Size = new Size(197, 52);
            btnSupplierForm.TabIndex = 2;
            btnSupplierForm.Text = "Поставщики";
            btnSupplierForm.UseVisualStyleBackColor = true;
            btnSupplierForm.Click += btnSupplierForm_Click;
            // 
            // btnMovieRentalForm
            // 
            btnMovieRentalForm.Location = new Point(3, 119);
            btnMovieRentalForm.Name = "btnMovieRentalForm";
            btnMovieRentalForm.Size = new Size(197, 52);
            btnMovieRentalForm.TabIndex = 3;
            btnMovieRentalForm.Text = "Аренда Фильма";
            btnMovieRentalForm.UseVisualStyleBackColor = true;
            btnMovieRentalForm.Click += btnMovieRentalForm_Click;
            // 
            // btnCinemaForm
            // 
            btnCinemaForm.Location = new Point(3, 177);
            btnCinemaForm.Name = "btnCinemaForm";
            btnCinemaForm.Size = new Size(197, 52);
            btnCinemaForm.TabIndex = 4;
            btnCinemaForm.Text = "Кинотеатр";
            btnCinemaForm.UseVisualStyleBackColor = true;
            btnCinemaForm.Click += btnCinemaForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_12_13_164942;
            pictureBox1.Location = new Point(253, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 312);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMovieForm;
        private Button btnSupplierForm;
        private Button btnMovieRentalForm;
        private Button btnCinemaForm;
        private PictureBox pictureBox1;
    }
}
