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
    public partial class course1 : Form
    {
        public course1()
        {
            InitializeComponent();
            loadgrid();
        }
        string year;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generateTimeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void course1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbttDataSet3.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.dbttDataSet3.course);
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd = conn1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from teacher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboteacher.Items.Add(dr["tname"].ToString());
            }

            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from course";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridcourse.DataSource = bs;
            da1.Update(dt1);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          
        }
        void loadgrid()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from course";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridcourse.DataSource = bs;
            da1.Update(dt1);
        }
        void loadgridse()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from course where year = 'S.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridcourse.DataSource = bs;
            da1.Update(dt1);
        }
        void loadgridte()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from course where year = 'T.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridcourse.DataSource = bs;
            da1.Update(dt1);
        }
        void loadgridbe()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from course where year = 'B.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridcourse.DataSource = bs;
            da1.Update(dt1);
        }
        private void btninsertcourse_Click(object sender, EventArgs e)
        {
            string cid = txtcourseid.Text;
            string cname = txtcoursename.Text;
            
            string teacher = comboteacher.Text;
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string checkcourse = "select * from course where cid='" + cid + "' AND year='" + year + "'";
            SqlCommand command = new SqlCommand(checkcourse, con);
            con.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("teacher already present");
            }

            else
            {
                rd.Close();
                if (rdnse.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into course values('" + cid + "','" + cname + "','" + year + "','" + teacher + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridse();
                    if (c >= 1)
                    {
                        txtcourseid.Text = " ";
                        txtcoursename.Text = " ";
                        comboteacher.Text = " ";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
                else if(rdnte.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into course values('" + cid + "','" + cname + "','" + year + "','" + teacher + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridte();
                    if (c >= 1)
                    {
                        txtcourseid.Text = " ";
                        txtcoursename.Text = " ";
                        comboteacher.Text = " ";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
                else if(rdnbe.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into course values('" + cid + "','" + cname + "','" + year + "','" + teacher + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridbe();
                    if (c >= 1)
                    {
                        txtcourseid.Text = " ";
                        txtcoursename.Text = " ";
                        comboteacher.Text = " ";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }

            }
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void rdnse_CheckedChanged(object sender, EventArgs e)
        {
            year = "S.E.";
            loadgridse();
            comboteacher.Items.Clear();
            string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn2 = new SqlConnection(dbpath1);
            conn2.Open();
            string addquery1 = "select * from teacher where year='" + year + "'";
            SqlCommand cmd2 = new SqlCommand(addquery1, conn2);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr1 in dt2.Rows)
            {
                comboteacher.Items.Add(dr1["tname"].ToString());

            }
            conn2.Close();
        }

        private void rdnbe_CheckedChanged(object sender, EventArgs e)
        {
            year = "T.E.";
            loadgridte();
            comboteacher.Items.Clear();
            string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn2 = new SqlConnection(dbpath1);
            conn2.Open();
            string addquery1 = "select * from teacher where year='" + year + "'";
            SqlCommand cmd2 = new SqlCommand(addquery1, conn2);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr1 in dt2.Rows)
            {
                comboteacher.Items.Add(dr1["tname"].ToString());

            }
            conn2.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            year = "B.E.";
            loadgridbe();
            comboteacher.Items.Clear();
            string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn2 = new SqlConnection(dbpath1);
            conn2.Open();
            string addquery1 = "select * from teacher where year='" + year + "'";
            SqlCommand cmd2 = new SqlCommand(addquery1, conn2);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr1 in dt2.Rows)
            {
                comboteacher.Items.Add(dr1["tname"].ToString());

            }
            conn2.Close();
        }

        private void btnupdatecourse_Click(object sender, EventArgs e)
        {
            string cid = txtcourseid.Text;
            string cname = txtcoursename.Text;

            string teacher = comboteacher.Text;
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update course set coursename = '" + cname + "', year = '" + year + "', teacher = '" + teacher + "' where cid = " + cid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txtcourseid.Text = " ";
                    txtcoursename.Text = " ";
                    comboteacher.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }

            }
            else if (rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update course set coursename = '" + cname + "', year = '" + year + "', teacher = '" + teacher + "' where cid = " + cid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txtcourseid.Text = " ";
                    txtcoursename.Text = " ";
                    comboteacher.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
            else if (rdnbe.Checked)
            {
                    String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con = new SqlConnection(path);
                    String updatequery = "update course set coursename = '" + cname + "', year = '" + year + "', teacher = '" + teacher + "' where cid = " + cid + "'";
                    SqlCommand cmd = new SqlCommand(updatequery, con);
                    con.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridbe();
                    if (c >= 1)
                    {
                        txtcourseid.Text = " ";
                        txtcoursename.Text = " ";
                        comboteacher.Text = " ";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
            }

        private void btndeletecourse_Click(object sender, EventArgs e)
        {
            string cid = txtcourseid.Text;
            string cname = txtcoursename.Text;

            string teacher = comboteacher.Text;
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from course where cid = " + cid;
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txtcourseid.Text = " ";
                    txtcoursename.Text = " ";
                    comboteacher.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
            else if(rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from course where cid = " + cid;
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txtcourseid.Text = " ";
                    txtcoursename.Text = " ";
                    comboteacher.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
            else if(rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from course where cid = " + cid;
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txtcourseid.Text = " ";
                    txtcoursename.Text = " ";
                    comboteacher.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminmainpage frm = new adminmainpage();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

        private void comboteacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcourseid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcourseid_Click(object sender, EventArgs e)
        {

        }

        private void txtcoursename_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblteacher_Click(object sender, EventArgs e)
        {

        }

        private void lblyear_Click(object sender, EventArgs e)
        {

        }

        private void lblcoursename_Click(object sender, EventArgs e)
        {

        }
    }
}
