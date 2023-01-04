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
    public partial class admingeneratett : Form
    {
        public admingeneratett()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminmainpage frm = new adminmainpage();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void btnyearwise_Click(object sender, EventArgs e)
        {
            generateyearwisett frm = new generateyearwisett();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void btnfacultywise_Click(object sender, EventArgs e)
        {
            generatefacultywisett frm = new generatefacultywisett();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }
    }
}
