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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Weight = float.Parse(textBox1.Text);
            float height = float.Parse(textBox2.Text);
            if (textBox1.Text == null || textBox2.Text == null)
            {
                MessageBox.Show("enter the respective values", "error");
            }
            float calculate = Weight / ((height)*(height));
            MessageBox.Show("Your BODY MASS INDEX=" + calculate+" kg/(m)^2" , "BMI CALCULATOR");

            if (calculate<= 18.50)
            {
                label6.Text = "UnderWeight";
            }
            if (calculate > 18.50 && calculate <= 23.00)
            {
                label6.Text = "Healthy Range";
            }
            if (calculate > 23.00&&calculate<=27.50)
            {
                label6.Text = "Over Weight";
            }
            if (calculate >27.50)
            {
                label6.Text = "Obese";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

       
     
        
    }
}
