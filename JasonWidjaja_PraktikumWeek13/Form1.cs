using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Input.Text == "HIDE")
            {
                label2.Visible = false;
            }

            else if (Input.Text == "SHOWN")
            {
                label2.Visible = true;
            }

            else if (Input.Text == "DELETE")
            {
                label2.Text = "[EMPTY]";
            }
            else if (Input.Text == "GREEN")
            {
                label2.ForeColor = Color.Green;
            }

            else if (Input.Text == "BLUE")
            {
                label2.ForeColor = Color.Blue;
            }

            else if (Input.Text == "RED")
            {
                label2.ForeColor = Color.Red;
            }

            else if (Input.Text != "HIDE" || Input.Text != "SHOWN")
            {
                label2.Text = Input.Text;
            }


            if (label2.Text == "[EMPTY]")
            {
                label2.ForeColor = Color.Black;
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
            
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
