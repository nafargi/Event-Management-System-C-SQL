namespace Event_Management_System_edp
{
    partial class ManageVenue
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
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            label7 = new Label();
            VNameTb = new TextBox();
            label3 = new Label();
            VManagerTb = new TextBox();
            label2 = new Label();
            VenueDGV = new DataGridView();
            VAddressTb = new TextBox();
            label4 = new Label();
            VPhoneTb = new TextBox();
            VCapacityTb = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)VenueDGV).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(106, 66, 194);
            DeleteBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ButtonFace;
            DeleteBtn.Location = new Point(944, 827);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(174, 46);
            DeleteBtn.TabIndex = 35;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(106, 66, 194);
            EditBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            EditBtn.ForeColor = SystemColors.ButtonFace;
            EditBtn.Location = new Point(732, 827);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(174, 46);
            EditBtn.TabIndex = 34;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(106, 66, 194);
            SaveBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            SaveBtn.ForeColor = SystemColors.ButtonFace;
            SaveBtn.Location = new Point(490, 827);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(174, 46);
            SaveBtn.TabIndex = 33;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 12F);
            label7.Location = new Point(153, 693);
            label7.Name = "label7";
            label7.Size = new Size(104, 32);
            label7.TabIndex = 31;
            label7.Text = "Capacity";
            // 
            // VNameTb
            // 
            VNameTb.BackColor = Color.FromArgb(205, 193, 255);
            VNameTb.Location = new Point(603, 645);
            VNameTb.Name = "VNameTb";
            VNameTb.Size = new Size(344, 31);
            VNameTb.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 12F);
            label3.Location = new Point(603, 600);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 28;
            label3.Text = "Venue Name";
            label3.Click += label3_Click;
            // 
            // VManagerTb
            // 
            VManagerTb.BackColor = Color.FromArgb(205, 193, 255);
            VManagerTb.ForeColor = Color.Gold;
            VManagerTb.Location = new Point(153, 645);
            VManagerTb.Name = "VManagerTb";
            VManagerTb.Size = new Size(303, 31);
            VManagerTb.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.Location = new Point(153, 600);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 26;
            label2.Text = "Venue Manager";
            label2.Click += label2_Click;
            // 
            // VenueDGV
            // 
            VenueDGV.BackgroundColor = Color.White;
            VenueDGV.BorderStyle = BorderStyle.None;
            VenueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VenueDGV.Location = new Point(27, 221);
            VenueDGV.Name = "VenueDGV";
            VenueDGV.RowHeadersWidth = 62;
            VenueDGV.Size = new Size(1556, 334);
            VenueDGV.TabIndex = 25;
            VenueDGV.CellContentClick += VenueDGV_CellContentClick;
            // 
            // VAddressTb
            // 
            VAddressTb.Location = new Point(1113, 645);
            VAddressTb.Multiline = true;
            VAddressTb.Name = "VAddressTb";
            VAddressTb.Size = new Size(349, 124);
            VAddressTb.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 12F);
            label4.Location = new Point(1113, 600);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 37;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // VPhoneTb
            // 
            VPhoneTb.BackColor = Color.FromArgb(205, 193, 255);
            VPhoneTb.Location = new Point(603, 728);
            VPhoneTb.Name = "VPhoneTb";
            VPhoneTb.Size = new Size(344, 31);
            VPhoneTb.TabIndex = 38;
            // 
            // VCapacityTb
            // 
            VCapacityTb.BackColor = Color.FromArgb(205, 193, 255);
            VCapacityTb.Location = new Point(153, 738);
            VCapacityTb.Name = "VCapacityTb";
            VCapacityTb.Size = new Size(303, 31);
            VCapacityTb.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 12F);
            label5.Location = new Point(603, 693);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 40;
            label5.Text = "Phone No";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(139, 93, 255);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1612, 115);
            panel6.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(782, 39);
            label1.Name = "label1";
            label1.Size = new Size(295, 48);
            label1.TabIndex = 3;
            label1.Text = "Manage  Venues";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.placeholder;
            pictureBox5.Location = new Point(680, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(96, 85);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(139, 93, 255);
            panel7.Controls.Add(pictureBox10);
            panel7.Controls.Add(pictureBox9);
            panel7.Controls.Add(pictureBox8);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(pictureBox6);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 927);
            panel7.Name = "panel7";
            panel7.Size = new Size(1612, 123);
            panel7.TabIndex = 55;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.user;
            pictureBox10.Location = new Point(542, 34);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(66, 65);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.feedback;
            pictureBox9.Location = new Point(1034, 34);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(66, 65);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 7;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.power_button;
            pictureBox8.Location = new Point(792, 34);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(66, 65);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.speedometer;
            pictureBox7.Location = new Point(666, 34);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(66, 65);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.calendar__1_;
            pictureBox6.Location = new Point(916, 34);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // ManageVenue
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 255);
            ClientSize = new Size(1612, 1050);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(label5);
            Controls.Add(VCapacityTb);
            Controls.Add(VPhoneTb);
            Controls.Add(label4);
            Controls.Add(VAddressTb);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label7);
            Controls.Add(VNameTb);
            Controls.Add(label3);
            Controls.Add(VManagerTb);
            Controls.Add(label2);
            Controls.Add(VenueDGV);
            Name = "ManageVenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageVenue";
            ((System.ComponentModel.ISupportInitialize)VenueDGV).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private Label label7;
        private TextBox VNameTb;
        private Label label3;
        private TextBox VManagerTb;
        private Label label2;
        private DataGridView VenueDGV;
        private TextBox VAddressTb;
        private Label label4;
        private TextBox VPhoneTb;
        private TextBox VCapacityTb;
        private Label label5;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox5;
        private Panel panel7;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}