using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button1.BackColor = Color.Red;
            }

            if (radioButton2.Checked)
            {
                button1.BackColor = Color.Yellow;
            }

            if (radioButton3.Checked)
            {
                button1.BackColor = Color.Blue;
            }

            if (radioButton4.Checked)
            {
                button1.BackColor = Color.Green;
            }

            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.BackColor = Color.Red;
            }

            if (radioButton2.Checked)
            {
                button2.BackColor = Color.Yellow;
            }

            if (radioButton3.Checked)
            {
                button2.BackColor = Color.Blue;
            }

            if (radioButton4.Checked)
            {
                button2.BackColor = Color.Green;
            }

            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button4.BackColor = Color.Red;
            }

            if (radioButton2.Checked)
            {
                button4.BackColor = Color.Yellow;
            }

            if (radioButton3.Checked)
            {
                button4.BackColor = Color.Blue;
            }

            if (radioButton4.Checked)
            {
                button4.BackColor = Color.Green;
            }

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button3.BackColor = Color.Red;
            }

            if (radioButton2.Checked)
            {
                button3.BackColor = Color.Yellow;
            }

            if (radioButton3.Checked)
            {
                button3.BackColor = Color.Blue;
            }

            if (radioButton4.Checked)
            {
                button3.BackColor = Color.Green;
            }

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Text = "ELSŐ";
                button2.Text = "MÁSODIK";
                button3.Text = "NEGYEDIK";
                button4.Text = "HARMADIK";
            }

            else 
            {
                button1.Text = "első";
                button2.Text = "második";
                button3.Text = "negyedik";
                button4.Text = "harmadik";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith(".") || textBox1.Text.EndsWith("!") || textBox1.Text.EndsWith("?"))
            {
                label2.Text = "Oké!";
                label2.ForeColor = Color.Green;
                button5.Enabled = true;
            }

            else 
            {
                label2.Text = "nem jó!";
                label2.ForeColor = Color.Red;
                button5.Enabled = false;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += textBox1.Text + "\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int befogo1 = Convert.ToInt32(textBox2.Text);
                int befogo2 = Convert.ToInt32(textBox3.Text);

                double atfogo = Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2);

                label8.Text = atfogo.ToString("F");

                double kerulet = befogo1 + befogo2 + atfogo;

                label10.Text = kerulet.ToString("F");

                double terulet = befogo1 * befogo2 / 2;

                label9.Text = terulet.ToString("F");
                
            }

            catch 
            { 
                
            }
        
            
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
