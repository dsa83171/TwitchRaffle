using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using Newtonsoft.Json.Linq;

namespace Raffle
{

    public partial class Form1 : Form
    {
        AddItem addItem;
        public Form1()
        {
            addItem = new AddItem();
            InitializeComponent();
        }

        private void jsonToObj()
        {

            listBox1.Items.Clear();
            var url = "https://tmi.twitch.tv/group/user/" + ChannelName.Text.ToLower() + "/chatters";
            string j = new WebClient().DownloadString(url);

            var a = JObject.Parse(j);
            JObject chatters = a.GetValue("chatters") as JObject;
            JArray broadcaster = chatters.GetValue("broadcaster") as JArray;
            JArray mod = chatters.GetValue("moderators") as JArray;
            JArray vip = chatters.GetValue("vips") as JArray;
            JArray viewers = chatters.GetValue("viewers") as JArray;

            JArrayToItem(broadcaster);
            JArrayToItem(mod);
            JArrayToItem(vip);
            JArrayToItem(viewers);

            ViewCont.Text = listBox1.Items.Count.ToString();

        }

        private void JArrayToItem (JArray array)
        {
            foreach (var dataItem in array)
            {
                listBox1.Items.Add(dataItem.ToString());
            }
        }



        private void ChannelName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //GetViewerList();
                jsonToObj();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            for (int i = this.listBox1.Items.Count - 1; i >= 0; i--)
            {
                this.listBox1.Items.Remove(this.listBox1.SelectedItem);
            }
            ViewCont.Text = listBox1.Items.Count.ToString();
        }
        private void DelBtn2_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("確定要流放這個中獎者嗎?", "你確定??", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = this.listBox2.Items.Count - 1; i >= 0; i--)
                {
                    this.listBox2.Items.Remove(this.listBox2.SelectedItem);
                }
            }
            labBingo.Text = listBox2.Items.Count.ToString();
        }


        private void AddItemBtn_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<AddItem>().Any())
            {
                addItem.TopMost = true;
                addItem.TopMost = false;
            }
            else
            {
                addItem.Close();
                addItem.Dispose();
                addItem = new AddItem();
                addItem.Owner = this;
                addItem.ShowDialog(this);
            }

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            string[] arr = listBox1.Items.Cast<string>().ToArray();
            var filterList = arr.Except(Bot.bot_list).ToArray();

            listBox1.Items.Clear();
            AddNewItem(filterList);

        }


        public void AddNewItem(string[] str)
        {
            System.Object[] ItemObject = new System.Object[str.Length];
            for (int j = 0; j < str.Length; j++)
            {
                ItemObject[j] = str[j];
            }
            listBox1.Items.AddRange(ItemObject);
            ViewCont.Text = listBox1.Items.Count.ToString();
        }

        private void RuffleBtn_Click(object sender, EventArgs e)
        {
            Random R = new Random(Guid.NewGuid().GetHashCode());
            if(listBox1.Items.Count<= 0)
            {
                MessageBox.Show("請先輸入名單再進行抽獎" , "Error");
            }
            else
            {
                int index = R.Next(0, listBox1.Items.Count);
                listBox2.Items.Add(listBox1.Items[index].ToString());
                listBox1.Items.Remove(this.listBox1.Items[index]);
            }
            ViewCont.Text = listBox1.Items.Count.ToString();
            labBingo.Text = listBox2.Items.Count.ToString();
        }




        [DllImport("user32.dll")]
        //視窗動畫
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        private void listBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            ViewCont.Text = listBox1.Items.Count.ToString();

        }


        Boolean textboxHasText = false;
        private void ChannelName_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                ChannelName.Text = "";

            ChannelName.ForeColor = Color.Black;
        }

        private void ChannelName_Leave(object sender, EventArgs e)
        {
            if (ChannelName.Text == "")
            {
                ChannelName.Text = "輸入後按Enter";
                ChannelName.ForeColor = Color.DarkGray;
                textboxHasText = false;
            }
            else
                textboxHasText = true;
        }
    }
}
