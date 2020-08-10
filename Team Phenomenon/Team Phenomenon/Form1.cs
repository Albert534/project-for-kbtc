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
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            userControl12.BringToFront();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            userControl12.BringToFront();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            userControl31.BringToFront();


        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            Form2 gg = new Form2();
            gg.Show();
            this.Hide();
        }

        private void burger1_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {
          
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void userControl41_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            bill1.BringToFront();
        }
    }
}
