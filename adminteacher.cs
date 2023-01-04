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
   
    public partial class adminteacher : Form
    {
        public adminteacher()
        {
            InitializeComponent();
            loadgrid();
        }
        string year;
        private void adminteacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbttDataSet14.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dbttDataSet14.teacher);


        }
        void loadgrid()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from teacher";
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
            cmd1.CommandText = "select * from teacher where year= 'S.E.'";
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
            cmd1.CommandText = "select * from teacher where year='T.E.'";
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
            cmd1.CommandText = "select * from teacher where year='B.E.'";
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
            string tid = txttid.Text;
            string tname = txttname.Text;
            string pass = txtpass.Text;
            string post = combopost.Text;
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string checkteacher = "select * from teacher where tid='" + tid + "' AND year='" + year + "'";
            SqlCommand command = new SqlCommand(checkteacher, con);
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
                    String insertquery = "insert into teacher values('" + tid + "','" + tname + "','" + post + "','" + pass + "','" + year + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridse();
                    if (c >= 1)
                    {
                        txttid.Text = "";
                        txttname.Text = "";
                        txtpass.Text = "";
                        combopost.Text = "";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
                else if (rdnte.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into teacher values('" + tid + "','" + tname + "','" + post + "','" + pass + "','" + year + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridte();
                    if (c >= 1)
                    {
                        txttid.Text = "";
                        txttname.Text = "";
                        txtpass.Text = "";
                        combopost.Text = "";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
                else if (rdnbe.Checked)
                {
                    String path1 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                    SqlConnection con1 = new SqlConnection(path1);
                    String insertquery = "insert into teacher values('" + tid + "','" + tname + "','" + post + "','" + pass + "','" + year + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con1);
                    con1.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridbe();
                    if (c >= 1)
                    {
                        txttid.Text = "";
                        txttname.Text = "";
                        txtpass.Text = "";
                        combopost.Text = "";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                    }
                }
            }
        }
        private void btnupdatecourse_Click(object sender, EventArgs e)
        {
            string tid = txttid.Text;
            string tname = txttname.Text;
            string pass = txtpass.Text;
            string post = combopost.Text;
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update teacher set tid = '" + tid + "', tname = '" + tname + "', post = '" + post + "',password= '" + pass + "',year='" + year + "' where tid = '" + tid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txttname.Text = "";
                    txtpass.Text = "";
                    combopost.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
             
            }
            else if(rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update teacher set tid = '" + tid + "', tname = '" + tname + "', post = '" + post + "',password= '" + pass + "',year='" + year + "' where tid = '" + tid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txttname.Text = "";
                    txtpass.Text = "";
                    combopost.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
            else if(rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update teacher set tid = '" + tid + "', tname = '" + tname + "', post = '" + post + "',password= '" + pass + "',year='" + year + "' where tid = '" + tid + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txttname.Text = "";
                    txtpass.Text = "";
                    combopost.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
            }
        }

        private void btndeletecourse_Click(object sender, EventArgs e)
        {
            string tid = txttid.Text;
            string tname = txttname.Text;
            string pass = txtpass.Text;
            string post = combopost.Text;
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from teacher where tid ='" + tid + "' AND year='S.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txttname.Text = "";
                    txtpass.Text = "";
                    combopost.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }
               
            }
            else if(rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from teacher where tid ='" + tid + "' AND year='T.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txttname.Text = "";
                    txtpass.Text = "";
                    combopost.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                }

            }
            else if(rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from teacher where tid ='" + tid + "' AND year='B.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txttid.Text = "";
                    txttname.Text = "";
                    txtpass.Text = "";
                    combopost.Text = "";
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

        private void rdnse_CheckedChanged(object sender, EventArgs e)
        {
            year = "S.E.";
            loadgridse();
        }

        private void rdnte_CheckedChanged(object sender, EventArgs e)
        {
            year = "T.E.";
            loadgridte();
        }

        private void rdnbe_CheckedChanged(object sender, EventArgs e)
        {
            year = "B.E.";
            loadgridbe();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
