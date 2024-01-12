using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Exam__System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            wrongLablel.Visible = false;

        }

        private void texSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (texSelectUser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;

            }
            else if (texSelectUser.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void checkBoxShowpaswordHide_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            {
              
                Teacher oo= new Teacher();
                oo.Show();
                this.Hide();
            }
            
           
              
          
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
           
            StudentLogin hh = new StudentLogin();
            hh.Show();
            this.Hide();
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
