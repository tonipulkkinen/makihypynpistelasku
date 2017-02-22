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
            Random r = new Random();
            Contender NextContender = new Contender(Convert.ToString(listBox1.SelectedItem), Convert.ToDecimal(r.Next(80, 146)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox13.Text);
        }
    }
}
