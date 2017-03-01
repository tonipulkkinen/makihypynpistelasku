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
            ListItemAdd(listBox1, listBox2, listBox3);
            Random r = new Random();
            Jump NextJump = new Jump(Convert.ToString(listBox1.SelectedItem), Math.Ceiling(Convert.ToDecimal(r.Next(100, 135) + r.NextDouble()) * 10) / 10, Convert.ToInt32(textBox11.Text),
                Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text),
                Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox10.Text));

            decimal PlatformChange = Convert.ToDecimal(textBox12.Text) * -1;

            NextJump.CriticalPointCheck();
            NextJump.WindEffectCheck();

            


            NextJump._pointsTotal += (PlatformChange * 5) * 1.8m;

            listBox2.Items[listBox1.SelectedIndex] = Convert.ToString(NextJump._jumpLenght);
            listBox3.Items[listBox1.SelectedIndex] = Convert.ToString(NextJump._pointsTotal);
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

            textBox12.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            float Half = 0;
            float[] array = new float[5];

            for(int i = 0; i < 5; i++)
            {
                int HalfCheck = r.Next(0, 2);
                if (HalfCheck == 1)
                {
                    Half = 0.5f;
                }
                else
                {
                    Half = 0f;
                }
                array[i] = Half;
            }
            textBox1.Text = Convert.ToString(r.Next(14, 21) + array[0]);
            if (textBox1.Text == "20,5")
            {
                textBox1.Text = "20";
            }
            textBox2.Text = Convert.ToString(r.Next(14, 21) + array[1]);
            if (textBox2.Text == "20,5")
            {
                textBox2.Text = "20";
            }
            textBox3.Text = Convert.ToString(r.Next(14, 21) + array[2]);
            if (textBox3.Text == "20,5")
            {
                textBox3.Text = "20";
            }
            textBox4.Text = Convert.ToString(r.Next(14, 21) + array[3]);
            if (textBox4.Text == "20,5")
            {
                textBox4.Text = "20";
            }
            textBox5.Text = Convert.ToString(r.Next(14, 21) + array[4]);
            if (textBox5.Text == "20,5")
            {
                textBox5.Text = "20";
            }
            textBox6.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox7.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox8.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox9.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox10.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
        }
        static void ListItemAdd(ListBox listbox1, ListBox listbox2, ListBox listbox3)
        {
            if (listbox2.Items.Count < listbox1.Items.Count)
            {
                int i;
                for (i = listbox1.Items.Count - listbox2.Items.Count; i > 0; i--)
                {
                    listbox2.Items.Add("");
                }
            }
            if (listbox3.Items.Count < listbox1.Items.Count)
            {
                int i;
                for (i = listbox1.Items.Count - listbox3.Items.Count; i > 0; i--)
                {
                    listbox3.Items.Add("");
                }
            }
        }
    }
}
