namespace Event_Management_System_edp
{
    partial class ManageFeedback
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
            SaveBtn = new Button();
            label3 = new Label();
            EvNameTb = new TextBox();
            FeedbackDGV = new DataGridView();
            label9 = new Label();
            EvIdCb = new ComboBox();
            label8 = new Label();
            HospitalityCb = new ComboBox();
            label7 = new Label();
            PunctualityCb = new ComboBox();
            label4 = new Label();
            VenueCb = new ComboBox();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)FeedbackDGV).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(106, 66, 194);
            DeleteBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ButtonHighlight;
            DeleteBtn.Location = new Point(913, 654);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(174, 46);
            DeleteBtn.TabIndex = 44;
            DeleteBtn.Text = "Reset";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(106, 66, 194);
            SaveBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(680, 654);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(174, 46);
            SaveBtn.TabIndex = 42;
            SaveBtn.Text = "Submit";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 12F);
            label3.Location = new Point(1057, 507);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 40;
            label3.Text = "Hospitality";
            // 
            // EvNameTb
            // 
            EvNameTb.BackColor = Color.FromArgb(205, 193, 255);
            EvNameTb.Enabled = false;
            EvNameTb.Location = new Point(69, 554);
            EvNameTb.Name = "EvNameTb";
            EvNameTb.Size = new Size(220, 31);
            EvNameTb.TabIndex = 39;
            // 
            // FeedbackDGV
            // 
            FeedbackDGV.BackgroundColor = Color.White;
            FeedbackDGV.BorderStyle = BorderStyle.None;
            FeedbackDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FeedbackDGV.Location = new Point(69, 148);
            FeedbackDGV.Name = "FeedbackDGV";
            FeedbackDGV.RowHeadersWidth = 62;
            FeedbackDGV.Size = new Size(1556, 334);
            FeedbackDGV.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text", 12F);
            label9.Location = new Point(709, 507);
            label9.Name = "label9";
            label9.Size = new Size(81, 32);
            label9.TabIndex = 50;
            label9.Text = "Venue";
            // 
            // EvIdCb
            // 
            EvIdCb.BackColor = Color.FromArgb(205, 193, 255);
            EvIdCb.FormattingEnabled = true;
            EvIdCb.Location = new Point(394, 553);
            EvIdCb.Name = "EvIdCb";
            EvIdCb.Size = new Size(216, 32);
            EvIdCb.TabIndex = 49;
            EvIdCb.SelectionChangeCommitted += EvIdCb_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 12F);
            label8.Location = new Point(1409, 507);
            label8.Name = "label8";
            label8.Size = new Size(132, 32);
            label8.TabIndex = 48;
            label8.Text = "Punctuality";
            // 
            // HospitalityCb
            // 
            HospitalityCb.BackColor = Color.FromArgb(205, 193, 255);
            HospitalityCb.FormattingEnabled = true;
            HospitalityCb.Location = new Point(1057, 554);
            HospitalityCb.Name = "HospitalityCb";
            HospitalityCb.Size = new Size(216, 32);
            HospitalityCb.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 12F);
            label7.Location = new Point(394, 507);
            label7.Name = "label7";
            label7.Size = new Size(102, 32);
            label7.TabIndex = 46;
            label7.Text = "Event ID";
            // 
            // PunctualityCb
            // 
            PunctualityCb.BackColor = Color.FromArgb(205, 193, 255);
            PunctualityCb.FormattingEnabled = true;
            PunctualityCb.Location = new Point(1409, 554);
            PunctualityCb.Name = "PunctualityCb";
            PunctualityCb.Size = new Size(216, 32);
            PunctualityCb.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 12F);
            label4.Location = new Point(69, 507);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 51;
            label4.Text = "Event Name";
            // 
            // VenueCb
            // 
            VenueCb.BackColor = Color.FromArgb(205, 193, 255);
            VenueCb.FormattingEnabled = true;
            VenueCb.Location = new Point(709, 554);
            VenueCb.Name = "VenueCb";
            VenueCb.Size = new Size(216, 32);
            VenueCb.TabIndex = 52;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(139, 93, 255);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1686, 115);
            panel6.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(782, 39);
            label1.Name = "label1";
            label1.Size = new Size(338, 48);
            label1.TabIndex = 3;
            label1.Text = "Manage Feedbacks";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.feedback;
            pictureBox5.Location = new Point(680, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(96, 85);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
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
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(139, 93, 255);
            panel7.Controls.Add(pictureBox10);
            panel7.Controls.Add(pictureBox9);
            panel7.Controls.Add(pictureBox8);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(pictureBox6);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 901);
            panel7.Name = "panel7";
            panel7.Size = new Size(1686, 123);
            panel7.TabIndex = 54;
            // 
            // ManageFeedback
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 255);
            ClientSize = new Size(1686, 1024);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(VenueCb);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(EvIdCb);
            Controls.Add(label8);
            Controls.Add(HospitalityCb);
            Controls.Add(label7);
            Controls.Add(PunctualityCb);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label3);
            Controls.Add(EvNameTb);
            Controls.Add(FeedbackDGV);
            Name = "ManageFeedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageFeedback";
            ((System.ComponentModel.ISupportInitialize)FeedbackDGV).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button SaveBtn;
        private Label label3;
        private TextBox EvNameTb;
        private DataGridView FeedbackDGV;
        private Label label9;
        private ComboBox EvIdCb;
        private Label label8;
        private ComboBox HospitalityCb;
        private Label label7;
        private ComboBox PunctualityCb;
        private Label label4;
        private ComboBox VenueCb;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Panel panel7;
    }
}