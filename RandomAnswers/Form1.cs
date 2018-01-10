using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomAnswers
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)

        {
            Random rand = new Random();
            int combo_temp = Convert.ToInt32(comboBox1.SelectedItem);
            int temp = rand.Next(combo_temp);
            textBox1.Text = temp.ToString();
            string s = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            textBox2.Text = s;
            counter += 1;
            double ans = Convert.ToDouble(s)/counter;
            textBox3.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                Random rand = new Random();
                int combo_temp = Convert.ToInt32(comboBox1.SelectedItem);
                int temp = rand.Next(combo_temp);
                textBox1.Text = temp.ToString();
                string s = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                textBox2.Text = s;
                counter += 1;
                double ans = Convert.ToDouble(s) / counter;
                textBox3.Text = ans.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 1000; i++)
            {
                Random rand = new Random();
                int combo_temp = Convert.ToInt32(comboBox1.SelectedItem);
                int temp = rand.Next(combo_temp);
                textBox1.Text = temp.ToString();
                string s = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                textBox2.Text = s;
                counter += 1;
                double ans = Convert.ToDouble(s) / counter;
                textBox3.Text = ans.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вийти з програми?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            System.Windows.Forms.Application.Exit();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            counter = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(textBox4.Text);
            for (int i = 1; i <= X; i++)
            {
                Random rand = new Random();
                int combo_temp = Convert.ToInt32(comboBox1.SelectedItem);
                int temp = rand.Next(combo_temp);
                textBox1.Text = temp.ToString();
                string s = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                textBox2.Text = s;
                counter += 1;
                double ans = Convert.ToDouble(s) / counter;
                textBox3.Text = ans.ToString();
            }
        }

        /*private void pictureBox1_Paint(object sender, PaintEventArgs e)
            {
                pictureBox1.Image.
            }*/
    }
}
