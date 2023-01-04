using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetable2
{
    public partial class teacherpage : Form
    {
        public teacherpage()
        {
            InitializeComponent();
        }

        private void btnregisterstudent_Click(object sender, EventArgs e)
        {
            regstu frm = new regstu();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            generatefacultywisett frm = new generatefacultywisett();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }
    }
}
