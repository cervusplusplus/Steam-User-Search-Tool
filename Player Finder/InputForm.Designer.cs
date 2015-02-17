namespace Player_Finder
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.SearchButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.AppIDBox = new System.Windows.Forms.TextBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursBox = new System.Windows.Forms.ComboBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LevelBox = new System.Windows.Forms.ComboBox();
            this.AgeBox = new System.Windows.Forms.ComboBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SteamGroupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchButton.Location = new System.Drawing.Point(0, 320);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(284, 42);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(140, 26);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(132, 23);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TextChanged += new System.EventHandler(this.GroupBox_TextChanged);
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.GameLabel.Location = new System.Drawing.Point(16, 55);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(118, 20);
            this.GameLabel.TabIndex = 3;
            this.GameLabel.Text = "Game AppID:";
            this.GameLabel.Click += new System.EventHandler(this.GameLabel_Click);
            // 
            // AppIDBox
            // 
            this.AppIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppIDBox.Location = new System.Drawing.Point(140, 55);
            this.AppIDBox.Name = "AppIDBox";
            this.AppIDBox.Size = new System.Drawing.Size(132, 23);
            this.AppIDBox.TabIndex = 4;
            this.AppIDBox.TextChanged += new System.EventHandler(this.AppIDBox_TextChanged);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HoursLabel.Location = new System.Drawing.Point(14, 85);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(120, 20);
            this.HoursLabel.TabIndex = 5;
            this.HoursLabel.Text = "Hours Played:";
            this.HoursLabel.Click += new System.EventHandler(this.HoursLabel_Click);
            // 
            // HoursBox
            // 
            this.HoursBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursBox.FormattingEnabled = true;
            this.HoursBox.Items.AddRange(new object[] {
            "1-10 hours",
            "10-25 hours",
            "25-50 hours",
            "50-100 hours",
            "100-250 hours",
            "250-500 hours",
            "500-1000 hours",
            "1000+ hours"});
            this.HoursBox.Location = new System.Drawing.Point(140, 85);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(132, 24);
            this.HoursBox.TabIndex = 6;
            this.HoursBox.SelectedIndexChanged += new System.EventHandler(this.HoursBox_SelectedIndexChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LevelLabel.Location = new System.Drawing.Point(21, 115);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(113, 20);
            this.LevelLabel.TabIndex = 7;
            this.LevelLabel.Text = "Steam Level:";
            this.LevelLabel.Click += new System.EventHandler(this.LevelLabel_Click);
            // 
            // LevelBox
            // 
            this.LevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelBox.FormattingEnabled = true;
            this.LevelBox.Items.AddRange(new object[] {
            "No Filter",
            "1-10",
            "11-20",
            "21-30",
            "31-40",
            "41-50",
            "51-100",
            "101+"});
            this.LevelBox.Location = new System.Drawing.Point(140, 115);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(132, 24);
            this.LevelBox.TabIndex = 8;
            this.LevelBox.SelectedIndexChanged += new System.EventHandler(this.LevelBox_SelectedIndexChanged);
            // 
            // AgeBox
            // 
            this.AgeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeBox.FormattingEnabled = true;
            this.AgeBox.Items.AddRange(new object[] {
            "No Filter",
            "0-1 Years",
            "1-2 Years",
            "2-3 Years",
            "3-4 Years",
            "4-5 Years",
            "5+ Years"});
            this.AgeBox.Location = new System.Drawing.Point(140, 145);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(132, 24);
            this.AgeBox.TabIndex = 9;
            this.AgeBox.SelectedIndexChanged += new System.EventHandler(this.AgeBox_SelectedIndexChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AgeLabel.Location = new System.Drawing.Point(17, 145);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(117, 20);
            this.AgeLabel.TabIndex = 10;
            this.AgeLabel.Text = "Account Age:";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // SteamGroupLabel
            // 
            this.SteamGroupLabel.AutoSize = true;
            this.SteamGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamGroupLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SteamGroupLabel.Location = new System.Drawing.Point(13, 26);
            this.SteamGroupLabel.Name = "SteamGroupLabel";
            this.SteamGroupLabel.Size = new System.Drawing.Size(121, 20);
            this.SteamGroupLabel.TabIndex = 11;
            this.SteamGroupLabel.Text = "Steam Group:";
            this.SteamGroupLabel.Click += new System.EventHandler(this.SteamGroupLabel_Click_1);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.SteamGroupLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.LevelBox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.HoursBox);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.AppIDBox);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.SearchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.Text = "Steam User Search Tool";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox GroupBox;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.TextBox AppIDBox;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.ComboBox HoursBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.ComboBox LevelBox;
        private System.Windows.Forms.ComboBox AgeBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SteamGroupLabel;
    }
}

