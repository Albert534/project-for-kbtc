using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Phenomenon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 gg = new Form1();
            gg.Show();
            this.Hide();

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
