using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrovserÇalışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser3.ScriptErrorsSuppressed = true;
        }
        string link;

        private void button1_Click(object sender, EventArgs e)
        {
            link = "https://www.google.com/search?q=" + textBox1.Text;
            webBrowser3.Navigate(link); //linkte gezin anlamında burası
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser3.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser3.DocumentText = "";
            textBox1.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            link = "https://yandex.com.tr/search/?text=" + textBox1.Text;
            webBrowser3.Navigate(link);
        }
    }
}
