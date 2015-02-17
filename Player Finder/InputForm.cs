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

        private void InputForm_Load(object sender, EventArgs e)
        {

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
            string data = "";
            int userpage = 1;
            bool diff = true;
            // This line takes the user's input into the group box and puts it into a string for the group's URL.
            string groupurl = "http://steamcommunity.com/groups/" + GroupBox.Text + "/memberslistxml/?xml=1&p=";


            while (diff == true)
            {
                diff = false;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(groupurl + userpage);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }
                userpage++;
                int index = 0;
                while (-1 != (index = data.IndexOf("<steamID64>")))
                {
                    string temp = data.Substring(index + 11, 17);
                    if (idarray.Contains(temp))
                    {

                    }
                    else
                    {
                        diff = true;
                        idarray.Add(temp);
                    }
                    data = data.Substring(index + 28);
                }
            }
            // Web request sent for each Steam ID in the array.
            foreach (string id in idarray)
            {
                string gameurl = "http://steamcommunity.com/profiles/" + id + "/games/?xml=1";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(gameurl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }
                int index = 0;
                // Index of the specified appID found here.  Then, the next time <hoursOnRecord> is seen, it will be for the correct appID.
                while (-1 != (index = data.IndexOf("<appID>"+AppIDBox.Text+"</appID>")))
                {
                    data = data.Substring(index);
                    index = data.IndexOf("<hoursOnRecord>");
                    data = data.Substring(index + 15);
                    index = data.IndexOf("<");
                    double hours = Double.Parse(data.Substring(0, index));

                }
            }
            // Results window opened here.
            ResultsForm results = new ResultsForm();
            results.Show();
        }
    }
}
