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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 11)
            {
                imageNumber = 1;

            }
            pictureBox.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete Health Check Up Desktop Application Made by:-\nSameerSrivastava\nSuraj Bohra ", "Read More");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\ProjectDB.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from [Login] where Username=@Username and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome User","Login Success");
                this.Hide();
                Sign_In Si = new Sign_In();
                Si.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please check your user and password","Error");
            }
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

   
        
    }
}
