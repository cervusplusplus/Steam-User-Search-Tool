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
            this.SteamGroupLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SearchProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Silver;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchButton.Location = new System.Drawing.Point(29, 125);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(229, 45);
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
            "1-100 hours",
            "100+ hours",
            "200+ hours",
            "300+ hours",
            "400+ hours",
            "500+ hours",
            "750+ hours",
            "1000+ hours"});
            this.HoursBox.Location = new System.Drawing.Point(140, 85);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(132, 24);
            this.HoursBox.TabIndex = 6;
            this.HoursBox.SelectedIndexChanged += new System.EventHandler(this.HoursBox_SelectedIndexChanged);
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
            this.SteamGroupLabel.Click += new System.EventHandler(this.SteamGroupLabel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 29);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // SearchProgressLabel
            // 
            this.SearchProgressLabel.AutoSize = true;
            this.SearchProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProgressLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SearchProgressLabel.Location = new System.Drawing.Point(67, 178);
            this.SearchProgressLabel.Name = "SearchProgressLabel";
            this.SearchProgressLabel.Size = new System.Drawing.Size(147, 20);
            this.SearchProgressLabel.TabIndex = 13;
            this.SearchProgressLabel.Text = "Search Progress:";
            this.SearchProgressLabel.Click += new System.EventHandler(this.SearchProgressLabel_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.SearchProgressLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SteamGroupLabel);
            this.Controls.Add(this.HoursBox);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.AppIDBox);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.SearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Label SteamGroupLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label SearchProgressLabel;
    }
}

