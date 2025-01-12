namespace Event_Management_System_edp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Reset = new Label();
            Uname = new TextBox();
            password = new TextBox();
            LoginBtn = new Button();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 25F);
            label1.Location = new Point(117, 359);
            label1.Name = "label1";
            label1.Size = new Size(626, 67);
            label1.TabIndex = 0;
            label1.Text = "Event Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.Location = new Point(324, 487);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 12F);
            label3.Location = new Point(324, 582);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // Reset
            // 
            Reset.AutoSize = true;
            Reset.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Underline);
            Reset.ForeColor = Color.Navy;
            Reset.Location = new Point(373, 782);
            Reset.Name = "Reset";
            Reset.Size = new Size(71, 32);
            Reset.TabIndex = 3;
            Reset.Text = "Reset";
            Reset.Click += Reset_Click;
            // 
            // Uname
            // 
            Uname.BackColor = Color.FromArgb(245, 239, 255);
            Uname.Location = new Point(324, 532);
            Uname.Name = "Uname";
            Uname.Size = new Size(304, 31);
            Uname.TabIndex = 4;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(245, 239, 255);
            password.Location = new Point(324, 631);
            password.Name = "password";
            password.Size = new Size(304, 31);
            password.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(67, 53, 167);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            LoginBtn.ForeColor = SystemColors.ButtonFace;
            LoginBtn.Location = new Point(186, 710);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(442, 50);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.task_management;
            pictureBox5.Location = new Point(261, 100);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(292, 266);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(186, 478);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.padlock;
            pictureBox2.Location = new Point(186, 582);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(162, 148, 249);
            ClientSize = new Size(831, 1021);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(LoginBtn);
            Controls.Add(password);
            Controls.Add(Uname);
            Controls.Add(Reset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Reset;
        private TextBox Uname;
        private TextBox password;
        private Button LoginBtn;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
