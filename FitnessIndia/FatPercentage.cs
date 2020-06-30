using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FitnessIndia
{
    public partial class FatPercentage : Form
    {
        public FatPercentage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float age = float.Parse(textBox1.Text);
            float Weight = float.Parse(textBox2.Text);
            float Height = float.Parse(textBox3.Text);
            if (radioButton1.Checked)
            {
                double Fat=(977.17*Weight)/(Height*Height)+(.16*age)-19.34;
                MessageBox.Show("YOUR FAT PERECENTAGE="+Fat+"%","Calculated Value");
            }
            else if(radioButton2.Checked)
            {
                MessageBox.Show("Coding Incomplete. -_-","Sorry Box!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FatPercentage_Load(object sender, EventArgs e)
        {

        }

       
    }
}
