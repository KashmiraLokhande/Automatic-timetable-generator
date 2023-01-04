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
    public partial class adminslot : Form
    {
        public adminslot()
        {
            InitializeComponent();
            loadgrid();
        }
        string year;
        private void comboteacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void loadgrid()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from slot";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridslot.DataSource = bs;
            da1.Update(dt1);
        }
        private void adminslot_Load(object sender, EventArgs e)
        {
            

            string dbpath2 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath2);
            conn1.Open();
            SqlCommand cmd2 = conn1.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from teacher";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                comboteacher.Items.Add(dr2["tname"].ToString());

            }
            conn1.Close();

            string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn2 = new SqlConnection(dbpath1);
            conn2.Open();
            SqlCommand cmd1 = conn2.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from classroom";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboclassnum.Items.Add(dr1["classnum"].ToString());

            }
            conn2.Close();
        }

        private void rdnse_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void rdnbe_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void btninsertcourse_Click(object sender, EventArgs e)
        {
            string slotid  = txtslotid.Text;
            string cname = combocoursename.Text;
            string tname = comboteacher.Text;
            string cnum  = comboclassnum.Text;
            string time =  combotime.Text;
            string day = comboday.Text;
            string type = combotype.Text;
            string batch = combobatch.Text;
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string insertquery = "insert into slot values('" + slotid + "','" + cname + "','" + tname + "','" + cnum + "','" + time + "','" + day + "','" + year + "','" + type + "','" + batch + "')";
            SqlCommand cmd = new SqlCommand(insertquery, con);
            con.Open();
            int c = cmd.ExecuteNonQuery();
            loadgrid();
            if (c >= 1)
            {
                txtslotid.Text = " ";
                combocoursename.Text = " ";
                rdnse.Checked = false;
                rdnte.Checked = false;
                rdnbe.Checked = false;
                comboteacher.Text = " ";
                comboclassnum.Text = " ";
                combotime.Text = " ";
                comboday.Text = " ";
                combotype.Text = " ";
                combobatch.Text = " ";
            }


        }

        private void btnupdatecourse_Click(object sender, EventArgs e)
        {
            string slotid = txtslotid.Text;
            string cname = combocoursename.Text;
            string tname = comboteacher.Text;
            string cnum = comboclassnum.Text;
            string time = combotime.Text;
            string day = comboday.Text;
            string type = combotype.Text;
            string batch = combobatch.Text;
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string updatequery = "update slot set slotid = '" + slotid + "', coursename= '" + cname + "', tname = '" + tname + "', classnum= '" + cnum + "', time = '" + time + "', day= '" + day + "', year = '" + year + "', type = '" + type + "',batch = '" +batch+ "' where slotid = '"+ slotid+"'" ;
            SqlCommand cmd = new SqlCommand(updatequery, con);
            con.Open();
            int c = cmd.ExecuteNonQuery();
            loadgrid();
            if (c >= 1)
            {
                txtslotid.Text = " ";
                combocoursename.Text = " ";
                rdnse.Checked = false;
                rdnte.Checked = false;
                rdnbe.Checked = false;
                comboteacher.Text = " ";
                comboclassnum.Text = " ";
                combotime.Text = " ";
                comboday.Text = " ";
                combotype.Text = " ";
                combobatch.Text = " ";
            }
           
        }

        private void btndeletecourse_Click(object sender, EventArgs e)
        {
            string slotid = txtslotid.Text;
            string cname = combocoursename.Text;
            string tname = comboteacher.Text;
            string cnum = comboclassnum.Text;
            string time = combotime.Text;
            string day = comboday.Text;
            string type = combotype.Text;
            string batch = combobatch.Text;
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string deletequery = "delete from slot where slotid = '" + slotid+"'";
            SqlCommand cmd = new SqlCommand(deletequery, con);
            con.Open();
            int c = cmd.ExecuteNonQuery();
            loadgrid();
            if (c >= 1)
            {
                txtslotid.Text = " ";
                combocoursename.Text = " ";
                rdnse.Checked = false;
                rdnte.Checked = false;
                rdnbe.Checked = false;
                comboteacher.Text = " ";
                comboclassnum.Text = " ";
                combotime.Text = " ";
                comboday.Text = " ";
                combotype.Text = " ";
                combobatch.Text = " ";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            adminmainpage frm = new adminmainpage();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }

       
        private void rdnse_CheckedChanged_2(object sender, EventArgs e)
        {
            year = "S.E.";
        }

        private void rdnte_CheckedChanged(object sender, EventArgs e)
        {
            year = "T.E.";
        
        }

        private void rdnbe_CheckedChanged_1(object sender, EventArgs e)
        {
            year = "B.E.";
        }

        private void btnshowcourse_Click(object sender, EventArgs e)
        {
            if (rdnse.Checked == true)
            {
                year = "S.E.";
                string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
                SqlConnection conn = new SqlConnection(dbpath);
                conn.Open();
                string addquery = "select * from course where year='" + year + "'";
                SqlCommand cmd = new SqlCommand(addquery, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combocoursename.Items.Add(dr["coursename"].ToString());

                }
                conn.Close();
            }
            else if (rdnte.Checked == true)
            {
                year = "T.E.";
                string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
                SqlConnection conn = new SqlConnection(dbpath);
                conn.Open();
                string addquery = "select * from course where year='" + year + "'";
                SqlCommand cmd = new SqlCommand(addquery, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combocoursename.Items.Add(dr["coursename"].ToString());

                }
                conn.Close();
            }

            else if (rdnbe.Checked == true)
            {
                year = "B.E.";

                string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
                SqlConnection conn = new SqlConnection(dbpath);
                conn.Open();
                string addquery = "select * from course where year='" + year + "'";
                SqlCommand cmd = new SqlCommand(addquery, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combocoursename.Items.Add(dr["coursename"].ToString());

                }
                conn.Close();
            }
        }
    }
}
