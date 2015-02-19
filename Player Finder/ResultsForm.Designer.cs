namespace Player_Finder
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IDBox = new System.Windows.Forms.ListBox();
            this.NameBox = new System.Windows.Forms.ListBox();
            this.HourBox = new System.Windows.Forms.ListBox();
            this.DateBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.SteamID64Label = new System.Windows.Forms.Label();
            this.AccountCreationLabel = new System.Windows.Forms.Label();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.FriendButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.21685F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.34945F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.07644F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.66927F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.IDBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NameBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HourBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateBox, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.IDBox.FormattingEnabled = true;
            this.IDBox.Location = new System.Drawing.Point(3, 3);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(129, 459);
            this.IDBox.TabIndex = 0;
            this.IDBox.SelectedIndexChanged += new System.EventHandler(this.IDBox_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(138, 3);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(226, 459);
            this.NameBox.TabIndex = 1;
            this.NameBox.SelectedIndexChanged += new System.EventHandler(this.NameBox_SelectedIndexChanged);
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HourBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Location = new System.Drawing.Point(370, 3);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(64, 459);
            this.HourBox.TabIndex = 2;
            this.HourBox.SelectedIndexChanged += new System.EventHandler(this.HourBox_SelectedIndexChanged);
            // 
            // DateBox
            // 
            this.DateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DateBox.FormattingEnabled = true;
            this.DateBox.Location = new System.Drawing.Point(440, 3);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(198, 459);
            this.DateBox.TabIndex = 4;
            this.DateBox.SelectedIndexChanged += new System.EventHandler(this.DateBox_SelectedIndexChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NameLabel.Location = new System.Drawing.Point(142, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HoursLabel.Location = new System.Drawing.Point(376, 9);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(45, 15);
            this.HoursLabel.TabIndex = 3;
            this.HoursLabel.Text = "Hours";
            this.HoursLabel.Click += new System.EventHandler(this.HoursLabel_Click);
            // 
            // SteamID64Label
            // 
            this.SteamID64Label.AutoSize = true;
            this.SteamID64Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamID64Label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SteamID64Label.Location = new System.Drawing.Point(15, 9);
            this.SteamID64Label.Name = "SteamID64Label";
            this.SteamID64Label.Size = new System.Drawing.Size(78, 15);
            this.SteamID64Label.TabIndex = 7;
            this.SteamID64Label.Text = "SteamID64";
            this.SteamID64Label.Click += new System.EventHandler(this.SteamID64Label_Click);
            // 
            // AccountCreationLabel
            // 
            this.AccountCreationLabel.AutoSize = true;
            this.AccountCreationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountCreationLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AccountCreationLabel.Location = new System.Drawing.Point(494, 9);
            this.AccountCreationLabel.Name = "AccountCreationLabel";
            this.AccountCreationLabel.Size = new System.Drawing.Size(100, 15);
            this.AccountCreationLabel.TabIndex = 5;
            this.AccountCreationLabel.Text = "Member Since";
            this.AccountCreationLabel.Click += new System.EventHandler(this.AccountCreationLabel_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Silver;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.Black;
            this.ProfileButton.Location = new System.Drawing.Point(153, 503);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(144, 47);
            this.ProfileButton.TabIndex = 8;
            this.ProfileButton.Text = "View Profile";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // FriendButton
            // 
            this.FriendButton.BackColor = System.Drawing.Color.Silver;
            this.FriendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendButton.ForeColor = System.Drawing.Color.Black;
            this.FriendButton.Location = new System.Drawing.Point(379, 503);
            this.FriendButton.Name = "FriendButton";
            this.FriendButton.Size = new System.Drawing.Size(144, 47);
            this.FriendButton.TabIndex = 9;
            this.FriendButton.Text = "Add Friend";
            this.FriendButton.UseVisualStyleBackColor = false;
            this.FriendButton.Click += new System.EventHandler(this.FriendButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(671, 562);
            this.Controls.Add(this.FriendButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.SteamID64Label);
            this.Controls.Add(this.AccountCreationLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResultsForm";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label SteamID64Label;
        public System.Windows.Forms.ListBox IDBox;
        public System.Windows.Forms.ListBox NameBox;
        public System.Windows.Forms.ListBox HourBox;
        public System.Windows.Forms.ListBox DateBox;
        private System.Windows.Forms.Label AccountCreationLabel;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FriendButton;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;




    }
}