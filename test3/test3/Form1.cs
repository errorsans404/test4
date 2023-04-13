using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2 || textBox1.Text.Length > 25)
            {
                button1.Text = "город";
                return;
            }

            if (textBox2.Text.Length < 10 || textBox2.Text.Length > 50)
            {
                button1.Text = "улица";
                return;
            }

            if (textBox3.Text.Length != 6)
            {
                button1.Text = "почт индекс";
                return;
            }

            try
            {
                int x = Int32.Parse(textBox3.Text);
            }

            catch(Exception ex)
            {
                button1.Text = "-почт индекс";
                return;
            }

        }
    }
}
