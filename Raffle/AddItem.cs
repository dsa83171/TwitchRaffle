using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Raffle
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Form1 MainForm = (Form1)this.Owner;
            string[] s = Regex.Split(textBox1.Text,Environment.NewLine);
            var ItemList = s.Where(x => x != "").ToArray();
            MainForm.AddNewItem(ItemList);
            this.Dispose();
            this.Close();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
