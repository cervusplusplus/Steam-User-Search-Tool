﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Player_Finder
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://url/SteamIDPage/" + IDBox.SelectedItem);
        }

        private void FriendButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://friends/add/" + IDBox.SelectedItem);
        }

        private void SteamID64Label_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void HoursLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccountCreationLabel_Click(object sender, EventArgs e)
        {

        }

        private void IDBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HourBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
