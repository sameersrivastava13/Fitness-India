using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace FitnessIndia
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\ProjectDB.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into [Login] values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("Thankyou for Registration!!","Go back to Login Page");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Fill Again!");
            }
       

           

      
          
        }
    }
}
