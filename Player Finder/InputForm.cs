using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Net;

namespace Player_Finder
{
    public partial class InputForm : Form
    {
        ArrayList idarray = new ArrayList();

        public InputForm()
        {
            InitializeComponent();
        }

        private void SteamGroupLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void GameLabel_Click(object sender, EventArgs e)
        {

        }

        private void HoursLabel_Click(object sender, EventArgs e)
        {

        }

        private void LevelLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoursBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LevelBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            int userpage = 1;

            // This line takes the user's input into the group box and puts it into a string for the group's URL.
            string groupurl = "http://steamcommunity.com/groups/" + GroupBox.Text + "/memberslistxml/?xml=1&p=";
            
            

            // Results window opened here.
            ResultsForm results = new ResultsForm();
            results.Show();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
