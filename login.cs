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

namespace timetable2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuserid.Text=="")
            {
                MessageBox.Show("enter username");
            }
            if(txtpassword.Text=="")
            {
                MessageBox.Show("enter password");
            }
            if (comboBoxcategory.Text == "Admin")
            {

                if (txtuserid.Text == "admin" && txtpassword.Text == "123")
                {
                    adminmainpage frm = new adminmainpage();
                    frm.Tag = this;
                    frm.Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Enter valid username");
                }
            }
            else if (comboBoxcategory.Text == "Student")
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True");
                con.Open();
                string str1 = "select * from student where sid='" + txtuserid.Text + "' and pass='" + txtpassword.Text + "'";
                SqlCommand cmd = new SqlCommand(str1, con);
                /*SqlDataAdapter da = new SqlDataAdapter(str1, con);
                DataTable dt = new DataTable();
                da.Fill(dt);*/
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                   generateyearwisett frm = new generateyearwisett();
                    frm.Tag = this;
                    frm.Show(this);
                    Hide();

                }
                else
                {
                    MessageBox.Show("Enter valid username");
                }
            }
            else if (comboBoxcategory.Text == "Teacher")
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True");
                con.Open();
                string str2 = "select * from teacher where tid='" + txtuserid.Text + "' and password='" + txtpassword.Text + "'";
                SqlCommand cmd1 = new SqlCommand(str2, con);
                /*SqlDataAdapter da1 = new SqlDataAdapter(str1, con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);*/
                SqlDataReader dr1;
                dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    teacherpage frm = new teacherpage();
                    frm.Tag = this;
                    frm.Show(this);
                    Hide();

                }
                else
                {
                    MessageBox.Show("Enter valid username");
                }
            }





                
          
           
            
             
            
        }

        private void studtechlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelteacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabelstudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabelregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabelback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
