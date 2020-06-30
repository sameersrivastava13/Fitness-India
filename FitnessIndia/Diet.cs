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
    public partial class Diet : Form
    {
        public Diet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietChat dc = new DietChat();
            dc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietChat dc = new DietChat();
            dc.ShowDialog();

        }
    }
}
