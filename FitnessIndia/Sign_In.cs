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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            bunifuTransition6.HideSync(uC61);
            bunifuTransition5.HideSync(uC51);
            bunifuTransition4.HideSync(uC41);
            bunifuTransition3.HideSync(uC31);
            bunifuTransition2.HideSync(uC21);
            bunifuTransition1.ShowSync(uC11);
          
            
            BMI bmi = new BMI();
            bmi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bunifuTransition6.HideSync(uC61);
            bunifuTransition5.HideSync(uC51);
            bunifuTransition4.HideSync(uC41);
            bunifuTransition3.HideSync(uC31);
            bunifuTransition2.ShowSync(uC21);
            bunifuTransition1.HideSync(uC11);



            FatPercentage fp = new FatPercentage();
            fp.ShowDialog();
        }
  

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuTransition6.HideSync(uC61);
            bunifuTransition5.HideSync(uC51);
            bunifuTransition4.ShowSync(uC41);
            bunifuTransition3.HideSync(uC31);
            bunifuTransition2.HideSync(uC21);
            bunifuTransition1.HideSync(uC11);

            Diet D = new Diet();
            D.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuTransition6.HideSync(uC61);
            bunifuTransition5.HideSync(uC51);
            bunifuTransition4.HideSync(uC41);
            bunifuTransition3.ShowSync(uC31);
            bunifuTransition2.HideSync(uC21);
            bunifuTransition1.HideSync(uC11);

            BloodPressure bp = new BloodPressure();
            bp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lifestyle l = new Lifestyle();
            l.ShowDialog();

            bunifuTransition6.HideSync(uC61);
            bunifuTransition5.ShowSync(uC51);
            bunifuTransition4.HideSync(uC41);
            bunifuTransition3.HideSync(uC31);
            bunifuTransition2.HideSync(uC21);
            bunifuTransition1.HideSync(uC11);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            bunifuTransition6.ShowSync(uC61);
            bunifuTransition5.HideSync(uC51);
            bunifuTransition4.HideSync(uC41);
            bunifuTransition3.HideSync(uC31);
            bunifuTransition2.HideSync(uC21);
            bunifuTransition1.HideSync(uC11);

            
            LifeE le = new LifeE();
            le.ShowDialog();
        }

        

        
    }
}
