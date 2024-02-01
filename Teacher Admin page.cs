using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam__System
{
    public partial class Teacher_Admin_page : Form
    {
        public Teacher_Admin_page()
        {
            InitializeComponent();
        }

        private void adQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion ad = new AddQuestion();
            ad.ShowDialog();
        }
    }
}
