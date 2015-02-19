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
using System.Threading;


namespace Player_Finder
{
    public partial class InputForm : Form
    {
        ArrayList idarray = new ArrayList();
        // Results window opened here.
        ResultsForm results = new ResultsForm();
        public InputForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            const int size = 50;
            Thread[] workers = new Thread[size];
            string data = "";

            int userpage = 1;
            bool diff = true;

            // This line takes the user's input into the group box and puts it into a string for the group's URL.
            string groupurl = "http://steamcommunity.com/groups/" + GroupBox.Text + "/memberslistxml/?xml=1&p=";

            // Web request sent to parse for all steamID64 numbers in the group.
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

            int liveThreads = 0;

            int idcounter = 0;

            // Web request sent for each Steam ID in the array.
            foreach (string id in idarray)
            {
                idcounter++;
                progressBar1.Value = (int)(((float)idcounter / idarray.Count) * 100);
                progressBar1.Refresh();
                if (liveThreads < size)
                {
                    workers[liveThreads] = new Thread(fetchInfo);
                    workers[liveThreads].Start(id);
                    liveThreads++;
                }

                else
                {
                    while (liveThreads >= size)
                    {
                        for (int i = 0; i < liveThreads; i++)
                        {
                            if (workers[i].Join(1))
                            {
                                workers[i] = workers[liveThreads - 1];
                                liveThreads--;
                                i--;
                            }
                        }
                    }
                }
            }
            results.Show();
            results.backgroundWorker1.RunWorkerAsync();
        }
        void fetchInfo(object id1)
        {
            string data = "";
            string data2 = "";
            string data3 = "";
            string id = (string)id1;

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

                // Copy of data unedited data string to use for displaying usernames of users that meet requirements.
                data2 = data;
                response.Close();
                readStream.Close();
            }
            int index = 0;
            // Index of the specified appID found here.  Then, the next time <hoursOnRecord> is seen, it will be for the correct appID.

            if (-1 != (index = data.IndexOf("<appID>" + AppIDBox.Text + "</appID>")))
            {
                data = data.Substring(index);
                index = data.IndexOf("<hoursOnRecord>");
                data = data.Substring(index + 15);
                index = data.IndexOf("<");
                double hours = Double.Parse(data.Substring(0, index));

                // Using the copied data2 from earlier, the user's name is parsed and displayed in the results window if they meet the desired hour filter.

                index = data2.IndexOf("<![CDATA[");
                data2 = data2.Substring(index + 9);
                index = data2.IndexOf("]]>");
                string username = data2.Substring(0, index);

                string profileurl = "http://steamcommunity.com/profiles/" + id + "/?xml=1";
                request = (HttpWebRequest)WebRequest.Create(profileurl);
                response = (HttpWebResponse)request.GetResponse();

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

                    data3 = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }

                index = data3.IndexOf("<memberSince>");
                data3 = data3.Substring(index + 13);
                index = data3.IndexOf("</memberSince>");
                string joindate = data3.Substring(0, index);

                // All users with the specified number of hours are filtered and added to the ID list box in the results window, 
                // along with their corresponding names and signup dates.
                if (HoursBox.SelectedIndex == 0)
                {
                    if (hours >= 1 && hours <= 100)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }

                else if (HoursBox.SelectedIndex == 1)
                {
                    if (hours >= 100)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }

                else if (HoursBox.SelectedIndex == 2)
                {
                    if (hours >= 200)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }

                else if (HoursBox.SelectedIndex == 3)
                {
                    if (hours >= 300)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }

                else if (HoursBox.SelectedIndex == 4)
                {
                    if (hours >= 400)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }

                else if (HoursBox.SelectedIndex == 5)
                {
                    if (hours >= 500)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }

                else if (HoursBox.SelectedIndex == 6)
                {
                    if (hours >= 750)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }

                else if (HoursBox.SelectedIndex == 7)
                {
                    if (hours >= 1000)
                    {
                        results.IDBox.Items.Add(id);
                        results.NameBox.Items.Add(username);
                        results.HourBox.Items.Add(hours);
                        results.DateBox.Items.Add(joindate);
                        results.IDBox.Refresh();
                        results.NameBox.Refresh();
                        results.HourBox.Refresh();
                        results.DateBox.Refresh();
                    }
                }
            }
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void SteamGroupLabel_Click(object sender, EventArgs e)
        {

        }

        private void GameLabel_Click(object sender, EventArgs e)
        {

        }

        private void HoursLabel_Click(object sender, EventArgs e)
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

        private void SearchProgressLabel_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
