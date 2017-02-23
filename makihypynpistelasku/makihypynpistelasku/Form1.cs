using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makihypynpistelasku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count < listBox1.Items.Count)
            {
                int i;
                for (i = listBox1.Items.Count - listBox2.Items.Count; i > 0; i--)
                {
                    listBox2.Items.Add("");
                }
            }
            if (listBox3.Items.Count < listBox1.Items.Count)
            {
                int i;
                for (i = listBox1.Items.Count - listBox3.Items.Count; i > 0; i--)
                {
                    listBox3.Items.Add("");
                }
            }
            Random r = new Random();
            Contender NextContender = new Contender(Convert.ToString(listBox1.SelectedItem), Math.Ceiling(Convert.ToDecimal(r.Next(80, 146) + r.NextDouble()) * 10) / 10);
            listBox2.Items[listBox1.SelectedIndex] = Convert.ToString(NextContender.jumpLenght);

            Points NextPoints = new Points(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text));

            Wind NextWind = new Wind(Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox10.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox13.Text);
            textBox13.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;           
        }
    }
}
