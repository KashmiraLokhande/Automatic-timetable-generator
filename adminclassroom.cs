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
    public partial class adminclassroom : Form
    {
        public adminclassroom()
        {
            InitializeComponent();
            loadgrid();
        }
        string year;
        void loadgrid()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from classroom";
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
            cmd1.CommandText = "select * from classroom where year='S.E.'";
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
            cmd1.CommandText = "select * from classroom where year='T.E.'";
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
            cmd1.CommandText = "select * from classroom where year='B.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridcourse.DataSource = bs;
            da1.Update(dt1);
        }
        private void gridcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btninsertcourse_Click(object sender, EventArgs e)
        {
            string cnum = txtclassnum.Text;
            string numofseat = txtnumofseat.Text;
            string type = combotype.Text;
            if(rdnse.Checked)
            {
                year = "S.E.";
            }
            if(rdnte.Checked)
            {
                year = "T.E.";
            }
            if(rdnbe.Checked)
            {
                year = "B.E.";
            }
            
            if(rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String insertquery = "insert into classroom values('" + cnum + "','" + numofseat + "','" + type + "','" + year + "','free')";
                SqlCommand cmd = new SqlCommand(insertquery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }
            }
            if (rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String insertquery = "insert into classroom values('" + cnum + "','" + numofseat + "','" + type + "','" + year + "','free')";
                SqlCommand cmd = new SqlCommand(insertquery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }
            }
            if (rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String insertquery = "insert into classroom values('" + cnum + "','" + numofseat + "','" + type + "','" + year + "','free')";
                SqlCommand cmd = new SqlCommand(insertquery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }
            }
        }

        private void btnupdatecourse_Click(object sender, EventArgs e)
        {
            string cnum = txtclassnum.Text;
            string numofseat = txtnumofseat.Text;
            string type = combotype.Text;
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
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update classroom set classnum = '" + cnum + "', numofseat = '" + numofseat + "',type='" + type + "', year='" + year + "','free' where classnum = '" + cnum + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }
            }
            if (rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update classroom set classnum = '" + cnum + "', numofseat = '" + numofseat + "',type='" + type + "', year='" + year + "','free' where classnum = '" + cnum + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }
            }
            if (rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String updatequery = "update classroom set classnum = '" + cnum + "', numofseat = '" + numofseat + "',type='" + type + "', year='" + year + "','free' where classnum = '" + cnum + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }
            }
        }

        private void btndeletecourse_Click(object sender, EventArgs e)
        {
            string cnum = txtclassnum.Text;
            string numofseat = txtnumofseat.Text;
            string type = combotype.Text;
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
            if (rdnse.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from classroom where classnum = '" + cnum + "' AND year='S.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }
                
            }
            if (rdnte.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from classroom where classnum = '" + cnum + "' AND year='T.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridte();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
                }

            }
            if (rdnbe.Checked)
            {
                String path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                String deletequery = "delete from classroom where classnum = '" + cnum + "' AND year='B.E.'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridbe();
                if (c >= 1)
                {
                    txtclassnum.Text = " ";
                    txtnumofseat.Text = " ";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    combotype.Text = "";
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

        private void adminclassroom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbttDataSet16.classroom' table. You can move, or remove it, as needed.
            this.classroomTableAdapter.Fill(this.dbttDataSet16.classroom);


        }

        private void rdnse_CheckedChanged(object sender, EventArgs e)
        {
            loadgridse();
        }

        private void rdnte_CheckedChanged(object sender, EventArgs e)
        {
            loadgridte();
        }

        private void rdnbe_CheckedChanged(object sender, EventArgs e)
        {
            loadgridbe();
        }
    }
}
