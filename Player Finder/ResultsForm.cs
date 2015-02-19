using System;
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

        // This method synchronizes all list box scroll bars in the results window.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int IDBoxScrollInt = 0;
            int NameBoxScrollInt = 0;
            int HourBoxScrollInt = 0;
            int DateBoxScrollInt = 0;
            int LevelBoxScrollInt = 0;

            while (true)
            {
                if (IDBox.TopIndex != IDBoxScrollInt)
                {
                    NameBox.TopIndex = IDBox.TopIndex;
                    HourBox.TopIndex = IDBox.TopIndex;
                    DateBox.TopIndex = IDBox.TopIndex;
                    LevelBox.TopIndex = IDBox.TopIndex;

                    IDBoxScrollInt = IDBox.TopIndex;
                    NameBoxScrollInt = NameBox.TopIndex;
                    HourBoxScrollInt = HourBox.TopIndex;
                    DateBoxScrollInt = DateBox.TopIndex;
                    LevelBoxScrollInt = LevelBox.TopIndex;
                }

                if (NameBox.TopIndex != NameBoxScrollInt)
                {
                    IDBox.TopIndex = NameBox.TopIndex;
                    HourBox.TopIndex = NameBox.TopIndex;
                    DateBox.TopIndex = NameBox.TopIndex;
                    LevelBox.TopIndex = NameBox.TopIndex;

                    IDBoxScrollInt = IDBox.TopIndex;
                    NameBoxScrollInt = NameBox.TopIndex;
                    HourBoxScrollInt = HourBox.TopIndex;
                    DateBoxScrollInt = DateBox.TopIndex;
                    LevelBoxScrollInt = LevelBox.TopIndex;
                }

                if (HourBox.TopIndex != HourBoxScrollInt)
                {
                    IDBox.TopIndex = HourBox.TopIndex;
                    NameBox.TopIndex = HourBox.TopIndex;
                    DateBox.TopIndex = HourBox.TopIndex;
                    LevelBox.TopIndex = HourBox.TopIndex;

                    IDBoxScrollInt = IDBox.TopIndex;
                    NameBoxScrollInt = NameBox.TopIndex;
                    HourBoxScrollInt = HourBox.TopIndex;
                    DateBoxScrollInt = DateBox.TopIndex;
                    LevelBoxScrollInt = LevelBox.TopIndex;
                }

                if (DateBox.TopIndex != DateBoxScrollInt)
                {
                    IDBox.TopIndex = DateBox.TopIndex;
                    NameBox.TopIndex = DateBox.TopIndex;
                    HourBox.TopIndex = DateBox.TopIndex;
                    LevelBox.TopIndex = DateBox.TopIndex;

                    IDBoxScrollInt = IDBox.TopIndex;
                    NameBoxScrollInt = NameBox.TopIndex;
                    HourBoxScrollInt = HourBox.TopIndex;
                    DateBoxScrollInt = DateBox.TopIndex;
                    LevelBoxScrollInt = LevelBox.TopIndex;
                }

                if (LevelBox.TopIndex != LevelBoxScrollInt)
                {
                    IDBox.TopIndex = LevelBox.TopIndex;
                    NameBox.TopIndex = LevelBox.TopIndex;
                    HourBox.TopIndex = LevelBox.TopIndex;
                    DateBox.TopIndex = LevelBox.TopIndex;

                    IDBoxScrollInt = IDBox.TopIndex;
                    NameBoxScrollInt = NameBox.TopIndex;
                    HourBoxScrollInt = HourBox.TopIndex;
                    DateBoxScrollInt = DateBox.TopIndex;
                    LevelBoxScrollInt = LevelBox.TopIndex;
                }
            }
        }
    }
}
