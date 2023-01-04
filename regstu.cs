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
    public partial class regstu : Form
    {
        string year;
        public regstu()
        {
            InitializeComponent();
        }

        private void regstu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbttDataSet19.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dbttDataSet19.student);


        }
        void loadgrid()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from student";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridstud.DataSource = bs;
            da1.Update(dt1);
        }
        void loadgridse()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from student where year= 'S.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridstud.DataSource = bs;
            da1.Update(dt1);
        }
        void loadgridte()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from student where year='T.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridstud.DataSource = bs;
            da1.Update(dt1);
        }
        void loadgridbe()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from student where year='B.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridstud.DataSource = bs;
            da1.Update(dt1);
        }

        private void btninsertcourse_Click(object sender, EventArgs e)
        {
            string sid = txttid.Text;
            string sname = txtsname.Text;
            string pass = txtpass.Text;
            string cpass = txtcpass.Text;
            if (rdnse.Checked)
            {
                year = "S.E.";
            }
            if (rdnte.Checked)
            {
                year = "T.E.";
            }
            if (rdnbe.Checked)
            {
                year = "B.E.";
            }
            if(txtpass.Text!=txtcpass.Text)
            {
                MessageBox.Show("password doesn't match");
            }
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string checkteacher = "select * from student where sid='" + sid + "' AND year='" + year + "'";
            SqlCommand command = new SqlCommand(checkteacher, con);
            con.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("student already present");
            }

            else
            {
                rd.Close();
                if (rdnse.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into student values('" + sid + "','" + pass + "','" + cpass + "','" + year + "','" + sname + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridse();
                    if (c >= 1)
                    {
                        txttid.Text = "";
                        txtsname.Text = "";
                        txtpass.Text = "";
                        txtcpass.Text = "";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
                else if (rdnte.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into student values('" + sid + "','" + pass + "','" + cpass + "','" + year + "','" + sname + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridte();
                    if (c >= 1)
                    {
                        txttid.Text = "";
                        txtsname.Text = "";
                        txtpass.Text = "";
                        txtcpass.Text = "";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
                else if (rdnbe.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into student values('" + sid + "','" + pass + "','" + cpass + "','" + year + "','" + sname + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridbe();
                    if (c >= 1)
                    {
                        txttid.Text = "";
                        txtsname.Text = "";
                        txtpass.Text = "";
                        txtcpass.Text = "";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
            }
        }

        private void btnupdatecourse_Click(object sender, EventArgs e)
        {
            string sid = txttid.Text;
            string sname = txtsname.Text;
            string pass = txtpass.Text;
            string cpass = txtcpass.Text;
            if (rdnse.Checked)
            {
                year = "S.E.";
            }
            if (rdnte.Checked)
            {
                year = "T.E.";
            }
            if (rdnbe.Checked)
            {
                year = "B.E.";
            }
            if (txtpass.Text != txtcpass.Text)
            {
                MessageBox.Show("password doesn't match");
            }
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update student set sid = '" + sid + "', sname = '" + sname + "', cpass = '" + cpass + "',pass = '" + pass + "',year='" + year + "' where sid = '" + sid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txtsname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }

            if (rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update student set sid = '" + sid + "', sname = '" + sname + "', cpass = '" + cpass + "',pass = '" + pass + "',year='" + year + "' where sid = '" + sid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txtsname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }

            }
            if (rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update student set sid = '" + sid + "', sname = '" + sname + "', cpass = '" + cpass + "',pass = '" + pass + "',year='" + year + "' where sid = '" + sid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txtsname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }

            }


        }

        private void btndeletecourse_Click(object sender, EventArgs e)
        {
            string sid = txttid.Text;
            string sname = txtsname.Text;
            string pass = txtpass.Text;
            string cpass = txtcpass.Text;
            if (rdnse.Checked)
            {
                year = "S.E.";
            }
            if (rdnte.Checked)
            {
                year = "T.E.";
            }
            if (rdnbe.Checked)
            {
                year = "B.E.";
            }
            if (txtpass.Text != txtcpass.Text)
            {
                MessageBox.Show("password doesn't match");
            }
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from student where sid ='" + sid + "' AND year='S.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txtsname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
            if (rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from student where sid ='" + sid + "' AND year='T.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txtsname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
            if (rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from student where sid ='" + sid + "' AND year='B.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txtsname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           teacherpage frm = new teacherpage();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }
    }
}
 

