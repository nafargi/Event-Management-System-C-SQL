namespace Event_Management_System_edp
{
    partial class ManageCustomer
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
            CustPhoneTb = new TextBox();
            label3 = new Label();
            CustNameTb = new TextBox();
            label2 = new Label();
            CustomerDGV = new DataGridView();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
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
            DeleteBtn.Location = new Point(960, 727);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(174, 46);
            DeleteBtn.TabIndex = 44;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(106, 66, 194);
            EditBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            EditBtn.ForeColor = SystemColors.ButtonFace;
            EditBtn.Location = new Point(733, 727);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(174, 46);
            EditBtn.TabIndex = 43;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(106, 66, 194);
            SaveBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            SaveBtn.ForeColor = SystemColors.ButtonFace;
            SaveBtn.Location = new Point(504, 727);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(174, 46);
            SaveBtn.TabIndex = 42;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CustPhoneTb
            // 
            CustPhoneTb.BackColor = Color.FromArgb(205, 193, 255);
            CustPhoneTb.Location = new Point(1046, 614);
            CustPhoneTb.Name = "CustPhoneTb";
            CustPhoneTb.Size = new Size(344, 31);
            CustPhoneTb.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 12F);
            label3.Location = new Point(874, 613);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 40;
            label3.Text = "Phone No";
            // 
            // CustNameTb
            // 
            CustNameTb.BackColor = Color.FromArgb(205, 193, 255);
            CustNameTb.Location = new Point(412, 618);
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(303, 31);
            CustNameTb.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.Location = new Point(213, 617);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 38;
            label2.Text = "Customer Name";
            // 
            // CustomerDGV
            // 
            CustomerDGV.BackgroundColor = Color.White;
            CustomerDGV.BorderStyle = BorderStyle.None;
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDGV.Location = new Point(65, 171);
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.RowHeadersWidth = 62;
            CustomerDGV.Size = new Size(1556, 334);
            CustomerDGV.TabIndex = 37;
            CustomerDGV.CellContentClick += CustomerDGV_CellContentClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(139, 93, 255);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1687, 115);
            panel6.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(782, 39);
            label1.Name = "label1";
            label1.Size = new Size(343, 48);
            label1.TabIndex = 3;
            label1.Text = "Manage Customers";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user;
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
            panel7.Location = new Point(0, 890);
            panel7.Name = "panel7";
            panel7.Size = new Size(1687, 123);
            panel7.TabIndex = 55;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.feedback;
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
            pictureBox9.Image = Properties.Resources.placeholder;
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
            pictureBox8.Location = new Point(782, 34);
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
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 255);
            ClientSize = new Size(1687, 1013);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(CustPhoneTb);
            Controls.Add(label3);
            Controls.Add(CustNameTb);
            Controls.Add(label2);
            Controls.Add(CustomerDGV);
            Name = "ManageCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomer";
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
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
        private TextBox CustPhoneTb;
        private Label label3;
        private TextBox CustNameTb;
        private Label label2;
        private DataGridView CustomerDGV;
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