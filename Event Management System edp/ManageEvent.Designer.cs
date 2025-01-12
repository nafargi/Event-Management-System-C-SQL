namespace Event_Management_System_edp
{
    partial class ManageEvent
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
            EventDGV = new DataGridView();
            EvNameTb = new TextBox();
            label2 = new Label();
            VenueNameTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            EvDate = new DateTimePicker();
            EvDateLb = new Label();
            EvDuration = new TextBox();
            label6 = new Label();
            StatusCb = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            EVIdCb = new ComboBox();
            label9 = new Label();
            CustIdCb = new ComboBox();
            SaveBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            CustNameTb = new TextBox();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EventDGV).BeginInit();
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
            // EventDGV
            // 
            EventDGV.BackgroundColor = Color.White;
            EventDGV.BorderStyle = BorderStyle.None;
            EventDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventDGV.Location = new Point(30, 155);
            EventDGV.Name = "EventDGV";
            EventDGV.RowHeadersWidth = 62;
            EventDGV.Size = new Size(1556, 334);
            EventDGV.TabIndex = 2;
            EventDGV.CellContentClick += EventDGV_CellContentClick;
            // 
            // EvNameTb
            // 
            EvNameTb.BackColor = Color.FromArgb(205, 193, 255);
            EvNameTb.Location = new Point(39, 581);
            EvNameTb.Name = "EvNameTb";
            EvNameTb.Size = new Size(303, 31);
            EvNameTb.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.Location = new Point(39, 546);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 5;
            label2.Text = "Event Name";
            // 
            // VenueNameTb
            // 
            VenueNameTb.BackColor = Color.FromArgb(205, 193, 255);
            VenueNameTb.Enabled = false;
            VenueNameTb.Location = new Point(421, 587);
            VenueNameTb.Name = "VenueNameTb";
            VenueNameTb.Size = new Size(344, 31);
            VenueNameTb.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 12F);
            label3.Location = new Point(421, 546);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 7;
            label3.Text = "Venue Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 12F);
            label4.Location = new Point(873, 546);
            label4.Name = "label4";
            label4.Size = new Size(188, 32);
            label4.TabIndex = 9;
            label4.Text = "Customer Name";
            label4.Click += label4_Click;
            // 
            // EvDate
            // 
            EvDate.CalendarForeColor = Color.FromArgb(192, 192, 255);
            EvDate.CalendarMonthBackground = Color.FromArgb(205, 193, 255);
            EvDate.CalendarTrailingForeColor = Color.GhostWhite;
            EvDate.Location = new Point(1270, 587);
            EvDate.Name = "EvDate";
            EvDate.Size = new Size(304, 31);
            EvDate.TabIndex = 11;
            // 
            // EvDateLb
            // 
            EvDateLb.AutoSize = true;
            EvDateLb.Font = new Font("Segoe UI Variable Text", 12F);
            EvDateLb.Location = new Point(1270, 546);
            EvDateLb.Name = "EvDateLb";
            EvDateLb.Size = new Size(129, 32);
            EvDateLb.TabIndex = 12;
            EvDateLb.Text = "Event Date";
            // 
            // EvDuration
            // 
            EvDuration.BackColor = Color.FromArgb(205, 193, 255);
            EvDuration.Location = new Point(1270, 672);
            EvDuration.Name = "EvDuration";
            EvDuration.Size = new Size(304, 31);
            EvDuration.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 12F);
            label6.Location = new Point(1271, 637);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 13;
            label6.Text = "Duration";
            // 
            // StatusCb
            // 
            StatusCb.BackColor = Color.FromArgb(205, 193, 255);
            StatusCb.FormattingEnabled = true;
            StatusCb.Items.AddRange(new object[] { "Waiting", "Pending", "Done" });
            StatusCb.Location = new Point(39, 672);
            StatusCb.Name = "StatusCb";
            StatusCb.Size = new Size(303, 32);
            StatusCb.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 12F);
            label7.Location = new Point(39, 637);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 12F);
            label8.Location = new Point(421, 637);
            label8.Name = "label8";
            label8.Size = new Size(111, 32);
            label8.TabIndex = 18;
            label8.Text = "Venue ID";
            // 
            // EVIdCb
            // 
            EVIdCb.BackColor = Color.FromArgb(205, 193, 255);
            EVIdCb.FormattingEnabled = true;
            EVIdCb.Location = new Point(421, 672);
            EVIdCb.Name = "EVIdCb";
            EVIdCb.Size = new Size(344, 32);
            EVIdCb.TabIndex = 17;
            EVIdCb.SelectionChangeCommitted += EVIdCb_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text", 12F);
            label9.Location = new Point(873, 637);
            label9.Name = "label9";
            label9.Size = new Size(147, 32);
            label9.TabIndex = 20;
            label9.Text = "Customer ID";
            // 
            // CustIdCb
            // 
            CustIdCb.BackColor = Color.FromArgb(205, 193, 255);
            CustIdCb.FormattingEnabled = true;
            CustIdCb.Location = new Point(873, 672);
            CustIdCb.Name = "CustIdCb";
            CustIdCb.Size = new Size(303, 32);
            CustIdCb.TabIndex = 19;
            CustIdCb.SelectionChangeCommitted += CustIdCb_SelectionChangeCommitted;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(106, 66, 194);
            SaveBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            SaveBtn.ForeColor = SystemColors.ButtonHighlight;
            SaveBtn.Location = new Point(441, 772);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(174, 46);
            SaveBtn.TabIndex = 21;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(106, 66, 194);
            EditBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            EditBtn.ForeColor = SystemColors.ButtonHighlight;
            EditBtn.Location = new Point(683, 772);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(174, 46);
            EditBtn.TabIndex = 22;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(106, 66, 194);
            DeleteBtn.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ButtonFace;
            DeleteBtn.Location = new Point(899, 772);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(174, 46);
            DeleteBtn.TabIndex = 23;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CustNameTb
            // 
            CustNameTb.BackColor = Color.FromArgb(205, 193, 255);
            CustNameTb.Enabled = false;
            CustNameTb.Location = new Point(872, 589);
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(304, 31);
            CustNameTb.TabIndex = 24;
            CustNameTb.TextChanged += CustNameTb_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(139, 93, 255);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1626, 115);
            panel6.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(782, 39);
            label1.Name = "label1";
            label1.Size = new Size(275, 48);
            label1.TabIndex = 3;
            label1.Text = "Manage Events";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.calendar__1_;
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
            panel7.Location = new Point(0, 925);
            panel7.Name = "panel7";
            panel7.Size = new Size(1626, 123);
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
            pictureBox6.Image = Properties.Resources.feedback;
            pictureBox6.Location = new Point(916, 34);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // ManageEvent
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 255);
            ClientSize = new Size(1626, 1048);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(CustNameTb);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label9);
            Controls.Add(CustIdCb);
            Controls.Add(label8);
            Controls.Add(EVIdCb);
            Controls.Add(label7);
            Controls.Add(StatusCb);
            Controls.Add(EvDuration);
            Controls.Add(label6);
            Controls.Add(EvDateLb);
            Controls.Add(EvDate);
            Controls.Add(label4);
            Controls.Add(VenueNameTb);
            Controls.Add(label3);
            Controls.Add(EvNameTb);
            Controls.Add(label2);
            Controls.Add(EventDGV);
            Name = "ManageEvent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)EventDGV).EndInit();
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
        private DataGridView EventDGV;
        private TextBox EvNameTb;
        private Label label2;
        private TextBox VenueNameTb;
        private Label label3;
        private Label label4;
        private DateTimePicker EvDate;
        private Label EvDateLb;
        private TextBox EvDuration;
        private Label label6;
        private ComboBox StatusCb;
        private Label label7;
        private Label label8;
        private ComboBox EVIdCb;
        private Label label9;
        private ComboBox CustIdCb;
        private Button SaveBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private TextBox CustNameTb;
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