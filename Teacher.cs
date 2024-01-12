using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam__System
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void tchBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("Enter your user name");

            }
            else if (password.Text == "")
            {
                MessageBox.Show("Enter your password");

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-8EPR46S\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");
                    SqlCommand cmd = new SqlCommand("select * from techer_login where username = @username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully");

                        Teacher_Admin_page ed = new Teacher_Admin_page();
                        ed.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login is Invalid");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                
            }

        }
    

        private void Teacher_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

