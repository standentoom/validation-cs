using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Validating(object sender, EventArgs e)
        {
            MessageBox.Show("Validating....");
        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Validated!!!");
        }

        private void textBox4_Validating(object sender, EventArgs e)
        {
            MessageBox.Show("Validating....");
        }
        private void textBox4_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Validated!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) & String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter your Name and Comment pls", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter Name pls", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter comment pls", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
