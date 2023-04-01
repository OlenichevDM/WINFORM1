using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            second1 second1 = new second1();
            second1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            second2 second2 = new second2();
            second2.Show();
        }
    }
}
