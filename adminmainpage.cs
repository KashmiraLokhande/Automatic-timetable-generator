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
    public partial class adminmainpage : Form
    {
        public adminmainpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            course1 frm = new course1();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminteacher frm = new adminteacher();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminclassroom frm = new adminclassroom();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void btnlecture_Click(object sender, EventArgs e)
        {
            adminslot1 frm = new adminslot1();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admingeneratett frm = new admingeneratett();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }
    }
}
