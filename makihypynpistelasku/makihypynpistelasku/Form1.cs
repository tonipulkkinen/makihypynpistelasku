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
        public List<Jump> Results = new List<Jump>();
        //List<Jump> Results = new List<Jump>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            
            Jump NextJump = new Jump(Convert.ToString(textBox13.Text), Math.Ceiling(Convert.ToDecimal(r.Next(100, 135) + r.NextDouble()) * 10) / 10, Convert.ToInt32(textBox11.Text), Convert.ToDecimal(textBox12.Text),
                Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text),
                Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox10.Text));

            NextJump.CriticalPointCheck();
            NextJump.WindEffectCheck();
            NextJump.PlatformChangeCheck();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            Results.Add(NextJump);
            var results = Results.OrderByDescending(jump => jump.PointsTotal);
            foreach (Jump jump in results)
            {
                listBox1.Items.Add(jump.Name);
                listBox2.Items.Add(jump.JumpLenght);
                listBox3.Items.Add(jump.PointsTotal);
            }
            textBox13.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            textBox6.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox7.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox8.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox9.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
            textBox10.Text = Convert.ToString(Math.Ceiling((r.Next(-5, 5) + r.NextDouble()) * 10) / 10);
        }
    }
}
