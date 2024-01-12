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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8EPR46S\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into regg values(@id,@name,@age,@gender,@phone", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@name", (txtName.Text));
            cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@gender", (txtGender.Text));
            cmd.Parameters.AddWithValue("@phone", (txtPhone.Text));
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Reigistration Successfully");

            AddQuestion ed = new AddQuestion();
            ed.ShowDialog();

        }
    }
}
