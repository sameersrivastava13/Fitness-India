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
    public partial class BloodPressure : Form
    {
        public BloodPressure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float One = float.Parse(textBox1.Text);
            float Two = float.Parse(textBox2.Text);

            if (One < 120 && Two < 80)
            {
                label4.Text = "Normal";
            }
            if ((One >= 120 &&One<=129)&&Two<80)
            {
                label4.Text = "Elevated";
            }
            if ((One >= 130 && One <= 139) || (Two >= 80&&Two<=89))
            {
                label4.Text = "HIGH BLOOD PRESSURE\n(Hypertension)STAGE 1";
            }
            if (One >= 140 ||Two >= 90)
            {
                label4.Text = "HIGH BLOOD PRESSURE\n(Hypertension)STAGE 2";
            }
            if (One >= 180 || Two >= 120)
            {
                label4.Text = "HYPERTENSIVE CRISES\n(consult your doctor immediately)";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
