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
    public partial class adminslot1 : Form
    {
        string year;
        public adminslot1()
        {
            InitializeComponent();
            loadgrid();
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
        void loadgridse()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from slot where year='S.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridslot.DataSource = bs;
            da1.Update(dt1);
            
        }
        void loadgridte()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from slot where year='T.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridslot.DataSource = bs;
            da1.Update(dt1);

        }
        void loadgridbe()
        {
            string dbpath = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath);
            conn1.Open();
            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from slot where year='B.E.'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            gridslot.DataSource = bs;
            da1.Update(dt1);

        }
        private void adminslot1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dbttDataSet12.slot' table. You can move, or remove it, as needed.
            this.slotTableAdapter.Fill(this.dbttDataSet12.slot);
            
        }

        private void btninsertcourse_Click(object sender, EventArgs e)
        {
            string slotid = txtslotid.Text;
            string cname = combocoursename.Text;
            string tname = comboteacher.Text;
            string cnum = comboclassnum.Text;
            string time = combotime.Text;
            string day = comboday.Text;
            string type = combotype.Text;
            string batch = combobatch.Text;
            int c;
            int c2;
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string checkslot = "select * from slot where time ='" + time + "' AND day = '" + day + "' AND tname = '" + tname + "'";
            SqlCommand command = new SqlCommand(checkslot, con);
            con.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("teacher busy at that slot select other teacher");
            }

            else
            {
                rd.Close();
                string checkslot1 = "select * from slot where slotid ='" + slotid + "'";
                SqlCommand command1 = new SqlCommand(checkslot1, con);
                SqlDataReader rd1 = command1.ExecuteReader();
                if (rd1.Read())
                {
                    MessageBox.Show("slot already alloted choose another slot or update the present slot");
                }
                else
                {
                    rd1.Close();
                    if (type == "lecture")
                    {
                        string checknolecture = "select count(slotid) from slot where day='" + day + "' AND year='" + year + "' AND type ='lecture'";
                        SqlCommand command2 = new SqlCommand(checknolecture, con);
                        SqlDataReader rd2 = command2.ExecuteReader();
                        if (rd2.Read())
                        {
                            c = rd2.GetInt32(0);
                            if (c >= 4)
                            {
                                MessageBox.Show("4 lecture slots already present in these day");
                            }
                            else
                            {
                                rd2.Close();
                                if (rdnse.Checked)
                                {
                                        string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                        SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                        SqlDataReader rd4 = cmd1.ExecuteReader();
                                        if(rd4.Read())
                                        {
                                        if (rd4.GetString(4) == "free")
                                        {
                                            rd4.Close();
                                            string insertquery = "insert into slot values('" + slotid + "','" + cname + "','" + tname + "','" + cnum + "','" + time + "','" + day + "','" + year + "','" + type + "','" + batch + "')";
                                            SqlCommand cmd = new SqlCommand(insertquery, con);
                                            int c1 = cmd.ExecuteNonQuery();
                                            if (c1 >= 1)
                                            {
                                                loadgridse();
                                                txtslotid.Text = "";
                                                combocoursename.Text = "";
                                                rdnse.Checked = false;
                                                rdnte.Checked = false;
                                                rdnbe.Checked = false;
                                                comboteacher.Text = "";
                                                comboclassnum.Text = "";
                                                combotime.Text = "";
                                                comboday.Text = "";
                                                combotype.Text = "";
                                                combobatch.Text = "";
                                                string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                cmd2.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("the class is already occupied");
                                        }
                                    }
                                       
                                }
                                else
                                {
                                    if (rdnte.Checked)
                                    {
                                        string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                        SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                        SqlDataReader rd4 = cmd1.ExecuteReader();
                                        if (rd4.Read())
                                        {
                                            if (rd4.GetString(4) == "free")
                                            {
                                                rd4.Close();
                                                string insertquery = "insert into slot values('" + slotid + "','" + cname + "','" + tname + "','" + cnum + "','" + time + "','" + day + "','" + year + "','" + type + "','" + batch + "')";
                                                SqlCommand cmd = new SqlCommand(insertquery, con);
                                                int c1 = cmd.ExecuteNonQuery();
                                                if (c1 >= 1)
                                                {
                                                    loadgridte();
                                                    txtslotid.Text = "";
                                                    combocoursename.Text = "";
                                                    rdnse.Checked = false;
                                                    rdnte.Checked = false;
                                                    rdnbe.Checked = false;
                                                    comboteacher.Text = "";
                                                    comboclassnum.Text = "";
                                                    combotime.Text = "";
                                                    comboday.Text = "";
                                                    combotype.Text = "";
                                                    combobatch.Text = "";
                                                    string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                    SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                    cmd2.ExecuteNonQuery();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("the class is already occupied");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (rdnbe.Checked)
                                        {

                                            string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                            SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                            SqlDataReader rd4 = cmd1.ExecuteReader();
                                            if (rd4.Read())
                                            {
                                                if (rd4.GetString(4) == "free")
                                                {
                                                    rd4.Close();
                                                    string insertquery = "insert into slot values('" + slotid + "','" + cname + "','" + tname + "','" + cnum + "','" + time + "','" + day + "','" + year + "','" + type + "','" + batch + "')";
                                                    SqlCommand cmd = new SqlCommand(insertquery, con);
                                                    int c1 = cmd.ExecuteNonQuery();
                                                    if (c1 >= 1)
                                                    {
                                                        loadgridbe();
                                                        txtslotid.Text = "";
                                                        combocoursename.Text = "";
                                                        rdnse.Checked = false;
                                                        rdnte.Checked = false;
                                                        rdnbe.Checked = false;
                                                        comboteacher.Text = "";
                                                        comboclassnum.Text = "";
                                                        combotime.Text = "";
                                                        comboday.Text = "";
                                                        combotype.Text = "";
                                                        combobatch.Text = "";
                                                        string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                        SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                        cmd2.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("the class is already occupied");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (type == "practical")
                        {
                            string checknopractical = "select count(slotid) from slot where day='" + day + "' AND year='" + year + "' AND type ='practical' AND (batch='A' OR batch='B' OR batch='C' OR batch='D')";
                            SqlCommand command3 = new SqlCommand(checknopractical, con);
                            SqlDataReader rd3 = command3.ExecuteReader();
                            if (rd3.Read())
                            {
                                c2 = rd3.GetInt32(0);
                                if (c2 >= 4)
                                {
                                    MessageBox.Show("1 practical slot already present in these day");
                                }
                                else
                                {
                                    rd3.Close();
                                    if (rdnse.Checked)
                                    {
                                        string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                        SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                        SqlDataReader rd4 = cmd1.ExecuteReader();
                                        if (rd4.Read())
                                        {
                                            if (rd4.GetString(4) == "free")
                                            {
                                                rd4.Close();
                                                string insertquery = "insert into slot values('" + slotid + "','" + cname + "','" + tname + "','" + cnum + "','" + time + "','" + day + "','" + year + "','" + type + "','" + batch + "')";
                                                SqlCommand cmd = new SqlCommand(insertquery, con);
                                                int c1 = cmd.ExecuteNonQuery();
                                                if (c1 >= 1)
                                                {
                                                    loadgridse();
                                                    txtslotid.Text = "";
                                                    combocoursename.Text = "";
                                                    rdnse.Checked = false;
                                                    rdnte.Checked = false;
                                                    rdnbe.Checked = false;
                                                    comboteacher.Text = "";
                                                    comboclassnum.Text = "";
                                                    combotime.Text = "";
                                                    comboday.Text = "";
                                                    combotype.Text = "";
                                                    combobatch.Text = "";
                                                    string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                    SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                    cmd2.ExecuteNonQuery();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("the class is already occupied");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (rdnte.Checked)
                                        {
                                            string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                            SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                            SqlDataReader rd4 = cmd1.ExecuteReader();
                                            if (rd4.Read())
                                            {
                                                if (rd4.GetString(4) == "free")
                                                {
                                                    rd4.Close();
                                                    string insertquery = "insert into slot values('" + slotid + "','" + cname + "','" + tname + "','" + cnum + "','" + time + "','" + day + "','" + year + "','" + type + "','" + batch + "')";
                                                    SqlCommand cmd = new SqlCommand(insertquery, con);
                                                    int c1 = cmd.ExecuteNonQuery();
                                                    if (c1 >= 1)
                                                    {
                                                        loadgridte();
                                                        txtslotid.Text = "";
                                                        combocoursename.Text = "";
                                                        rdnse.Checked = false;
                                                        rdnte.Checked = false;
                                                        rdnbe.Checked = false;
                                                        comboteacher.Text = "";
                                                        comboclassnum.Text = "";
                                                        combotime.Text = "";
                                                        comboday.Text = "";
                                                        combotype.Text = "";
                                                        combobatch.Text = "";
                                                        string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                        SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                        cmd2.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("the class is already occupied");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (rdnbe.Checked)
                                            {
                                                string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                                SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                                SqlDataReader rd4 = cmd1.ExecuteReader();
                                                if (rd4.Read())
                                                {
                                                    if (rd4.GetString(4) == "free")
                                                    {
                                                        rd4.Close();
                                                        string insertquery = "insert into slot values('" + slotid + "','" + cname + "','" + tname + "','" + cnum + "','" + time + "','" + day + "','" + year + "','" + type + "','" + batch + "')";
                                                        SqlCommand cmd = new SqlCommand(insertquery, con);
                                                        int c1 = cmd.ExecuteNonQuery();
                                                        if (c1 >= 1)
                                                        {
                                                            loadgridbe();
                                                            txtslotid.Text = "";
                                                            combocoursename.Text = "";
                                                            rdnse.Checked = false;
                                                            rdnte.Checked = false;
                                                            rdnbe.Checked = false;
                                                            comboteacher.Text = "";
                                                            comboclassnum.Text = "";
                                                            combotime.Text = "";
                                                            comboday.Text = "";
                                                            combotype.Text = "";
                                                            combobatch.Text = "";
                                                            string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                            SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                            cmd2.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("the class is already occupied");
                                                    }
                                                }
                                            }
                                        }
                                    }

                            }
                        }
                     }
                }
             }
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
            int c;
            int c2;
            string path = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            string checkslot = "select * from slot where time ='" + time + "' AND day = '" + day + "' AND tname = '" + tname + "'";
            SqlCommand command = new SqlCommand(checkslot, con);
            con.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("teacher busy at that slot select other teacher");
            }

            else
            {
               
                    rd.Close();
                    if (type == "lecture")
                    {
                        string checknolecture = "select count(slotid) from slot where day='" + day + "' AND year='" + year + "' AND type ='lecture'";
                        SqlCommand command2 = new SqlCommand(checknolecture, con);
                        SqlDataReader rd2 = command2.ExecuteReader();
                        if (rd2.Read())
                        {
                            c = rd2.GetInt32(0);
                            if (c >= 4)
                            {
                                MessageBox.Show("4 lecture slots already present in these day");
                            }
                            else
                            {
                                rd2.Close();
                                if (rdnse.Checked)
                                {
                                string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                SqlDataReader rd4 = cmd1.ExecuteReader();
                                if (rd4.Read())
                                {
                                    if (rd4.GetString(4) == "free")
                                    {
                                        rd4.Close();
                                        string updatequery = "update slot set slotid = '" + slotid + "', coursename= '" + cname + "', tname = '" + tname + "', classnum= '" + cnum + "', time = '" + time + "', day= '" + day + "', year = '" + year + "', type = '" + type + "',batch = '" + batch + "' where slotid = '" + slotid + "'";
                                        SqlCommand cmd = new SqlCommand(updatequery, con);
                                        int c1 = cmd.ExecuteNonQuery();
                                        if (c1 >= 1)
                                        {
                                            loadgridse();
                                            txtslotid.Text = "";
                                            combocoursename.Text = "";
                                            rdnse.Checked = false;
                                            rdnte.Checked = false;
                                            rdnbe.Checked = false;
                                            comboteacher.Text = "";
                                            comboclassnum.Text = "";
                                            combotime.Text = "";
                                            comboday.Text = "";
                                            combotype.Text = "";
                                            combobatch.Text = "";
                                            string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                            SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                            cmd2.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("the class is already occupied");
                                    }
                                }
                            }
                                else
                                {
                                    if (rdnte.Checked)
                                    {
                                    string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                    SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                    SqlDataReader rd4 = cmd1.ExecuteReader();
                                    if (rd4.Read())
                                    {
                                        if (rd4.GetString(4) == "free")
                                        {
                                            rd4.Close();
                                            string updatequery = "update slot set slotid = '" + slotid + "', coursename= '" + cname + "', tname = '" + tname + "', classnum= '" + cnum + "', time = '" + time + "', day= '" + day + "', year = '" + year + "', type = '" + type + "',batch = '" + batch + "' where slotid = '" + slotid + "'";
                                            SqlCommand cmd = new SqlCommand(updatequery, con);
                                            int c1 = cmd.ExecuteNonQuery();
                                            if (c1 >= 1)
                                            {
                                                loadgridte();
                                                txtslotid.Text = "";
                                                combocoursename.Text = "";
                                                rdnse.Checked = false;
                                                rdnte.Checked = false;
                                                rdnbe.Checked = false;
                                                comboteacher.Text = "";
                                                comboclassnum.Text = "";
                                                combotime.Text = "";
                                                comboday.Text = "";
                                                combotype.Text = "";
                                                combobatch.Text = "";
                                                string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                cmd2.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("the class is already occupied");
                                        }
                                    }
                                }
                                    else
                                    {
                                        if (rdnbe.Checked)
                                        {
                                        string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                        SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                        SqlDataReader rd4 = cmd1.ExecuteReader();
                                        if (rd4.Read())
                                        {
                                            if (rd4.GetString(4) == "free")
                                            {
                                                rd4.Close();
                                                string updatequery = "update slot set slotid = '" + slotid + "', coursename= '" + cname + "', tname = '" + tname + "', classnum= '" + cnum + "', time = '" + time + "', day= '" + day + "', year = '" + year + "', type = '" + type + "',batch = '" + batch + "' where slotid = '" + slotid + "'";
                                                SqlCommand cmd = new SqlCommand(updatequery, con);
                                                int c1 = cmd.ExecuteNonQuery();
                                                if (c1 >= 1)
                                                {
                                                    loadgridbe();
                                                    txtslotid.Text = "";
                                                    combocoursename.Text = "";
                                                    rdnse.Checked = false;
                                                    rdnte.Checked = false;
                                                    rdnbe.Checked = false;
                                                    comboteacher.Text = "";
                                                    comboclassnum.Text = "";
                                                    combotime.Text = "";
                                                    comboday.Text = "";
                                                    combotype.Text = "";
                                                    combobatch.Text = "";
                                                    string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                    SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                    cmd2.ExecuteNonQuery();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("the class is already occupied");
                                            }
                                        }
                                    }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (type == "practical")
                        {
                            string checknopractical = "select count(slotid) from slot where day='" + day + "' AND year='" + year + "' AND type ='practical' AND (batch='A' OR batch='B' OR batch='C' OR batch='D')";
                            SqlCommand command3 = new SqlCommand(checknopractical, con);
                            SqlDataReader rd3 = command3.ExecuteReader();
                            if (rd3.Read())
                            {
                                c2 = rd3.GetInt32(0);
                                if (c2 >= 4)
                                {
                                    MessageBox.Show("1 practical slot already present in these day");
                                }
                                else
                                {
                                    rd3.Close();
                                    if (rdnse.Checked)
                                    {
                                    string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                    SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                    SqlDataReader rd4 = cmd1.ExecuteReader();
                                    if (rd4.Read())
                                    {
                                        if (rd4.GetString(4) == "free")
                                        {
                                            rd4.Close();
                                            string updatequery = "update slot set slotid = '" + slotid + "', coursename= '" + cname + "', tname = '" + tname + "', classnum= '" + cnum + "', time = '" + time + "', day= '" + day + "', year = '" + year + "', type = '" + type + "',batch = '" + batch + "' where slotid = '" + slotid + "'";
                                            SqlCommand cmd = new SqlCommand(updatequery, con);
                                            int c1 = cmd.ExecuteNonQuery();
                                            if (c1 >= 1)
                                            {
                                                loadgridse();
                                                txtslotid.Text = "";
                                                combocoursename.Text = "";
                                                rdnse.Checked = false;
                                                rdnte.Checked = false;
                                                rdnbe.Checked = false;
                                                comboteacher.Text = "";
                                                comboclassnum.Text = "";
                                                combotime.Text = "";
                                                comboday.Text = "";
                                                combotype.Text = "";
                                                combobatch.Text = "";
                                                string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                cmd2.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("the class is already occupied");
                                        }
                                    }
                                }
                                    else
                                    {
                                        if (rdnte.Checked)
                                        {
                                        string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                        SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                        SqlDataReader rd4 = cmd1.ExecuteReader();
                                        if (rd4.Read())
                                        {
                                            if (rd4.GetString(4) == "free")
                                            {
                                                rd4.Close();
                                                string updatequery = "update slot set slotid = '" + slotid + "', coursename= '" + cname + "', tname = '" + tname + "', classnum= '" + cnum + "', time = '" + time + "', day= '" + day + "', year = '" + year + "', type = '" + type + "',batch = '" + batch + "' where slotid = '" + slotid + "'";
                                                SqlCommand cmd = new SqlCommand(updatequery, con);
                                                int c1 = cmd.ExecuteNonQuery();
                                                if (c1 >= 1)
                                                {
                                                    loadgridte();
                                                    txtslotid.Text = "";
                                                    combocoursename.Text = "";
                                                    rdnse.Checked = false;
                                                    rdnte.Checked = false;
                                                    rdnbe.Checked = false;
                                                    comboteacher.Text = "";
                                                    comboclassnum.Text = "";
                                                    combotime.Text = "";
                                                    comboday.Text = "";
                                                    combotype.Text = "";
                                                    combobatch.Text = "";
                                                    string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                    SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                    cmd2.ExecuteNonQuery();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("the class is already occupied");
                                            }
                                        }
                                    }
                                        else
                                        {
                                            if (rdnbe.Checked)
                                            {
                                            string classstatus = "select * from classroom where classnum='" + cnum + "'";
                                            SqlCommand cmd1 = new SqlCommand(classstatus, con);
                                            SqlDataReader rd4 = cmd1.ExecuteReader();
                                            if (rd4.Read())
                                            {
                                                if (rd4.GetString(4) == "free")
                                                {
                                                    rd4.Close();
                                                    string updatequery = "update slot set slotid = '" + slotid + "', coursename= '" + cname + "', tname = '" + tname + "', classnum= '" + cnum + "', time = '" + time + "', day= '" + day + "', year = '" + year + "', type = '" + type + "',batch = '" + batch + "' where slotid = '" + slotid + "'";
                                                    SqlCommand cmd = new SqlCommand(updatequery, con);
                                                    int c1 = cmd.ExecuteNonQuery();
                                                    if (c1 >= 1)
                                                    {
                                                        loadgridse();
                                                        txtslotid.Text = "";
                                                        combocoursename.Text = "";
                                                        rdnse.Checked = false;
                                                        rdnte.Checked = false;
                                                        rdnbe.Checked = false;
                                                        comboteacher.Text = "";
                                                        comboclassnum.Text = "";
                                                        combotime.Text = "";
                                                        comboday.Text = "";
                                                        combotype.Text = "";
                                                        combobatch.Text = "";
                                                        string updatestatus = "update classroom set status='alloted' where classnum='" + cnum + "'";
                                                        SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                                        cmd2.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("the class is already occupied");
                                                }
                                            }
                                        }
                                        }
                                    }

                                }
                            }
                        }
                    
                }
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
            if (rdnse.Checked)
            {
                string deletequery = "delete from slot where slotid = '" + slotid + "'";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                loadgridse();
                if (c >= 1)
                {
                    string classstatus = "select * from classroom where classnum='" + cnum + "'";
                    SqlCommand cmd1 = new SqlCommand(classstatus, con);
                    SqlDataReader rd4 = cmd1.ExecuteReader();
                    if (rd4.Read())
                    {
                        rd4.Close();
                        string updatestatus = "update classroom set status='free' where classnum='" + cnum + "'";
                        SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                        cmd2.ExecuteNonQuery();
                    }
                        txtslotid.Text = "";
                    combocoursename.Text = "";
                    rdnse.Checked = false;
                    rdnte.Checked = false;
                    rdnbe.Checked = false;
                    comboteacher.Text = "";
                    comboclassnum.Text = "";
                    combotime.Text = "";
                    comboday.Text = "";
                    combotype.Text = "";
                    combobatch.Text = "";
                }
            }
            else
            {
                if(rdnte.Checked)
                {
                    string deletequery = "delete from slot where slotid = '" + slotid + "'";
                    SqlCommand cmd = new SqlCommand(deletequery, con);
                    con.Open();
                    int c = cmd.ExecuteNonQuery();
                    loadgridse();
                    if (c >= 1)
                    {
                        string classstatus = "select * from classroom where classnum='" + cnum + "'";
                        SqlCommand cmd1 = new SqlCommand(classstatus, con);
                        SqlDataReader rd4 = cmd1.ExecuteReader();
                        if (rd4.Read())
                        {
                            rd4.Close();
                            string updatestatus = "update classroom set status='free' where classnum='" + cnum + "'";
                            SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                            cmd2.ExecuteNonQuery();
                        }
                        txtslotid.Text = "";
                        combocoursename.Text = "";
                        rdnse.Checked = false;
                        rdnte.Checked = false;
                        rdnbe.Checked = false;
                        comboteacher.Text = "";
                        comboclassnum.Text = "";
                        combotime.Text = "";
                        comboday.Text = "";
                        combotype.Text = "";
                        combobatch.Text = "";
                    }

                }
                else
                {
                    if(rdnbe.Checked)
                    {
                        string deletequery = "delete from slot where slotid = '" + slotid + "'";
                        SqlCommand cmd = new SqlCommand(deletequery, con);
                        con.Open();
                        int c = cmd.ExecuteNonQuery();
                        loadgridse();
                        if (c >= 1)
                        {
                            string classstatus = "select * from classroom where classnum='" + cnum + "'";
                            SqlCommand cmd1 = new SqlCommand(classstatus, con);
                            SqlDataReader rd4 = cmd1.ExecuteReader();
                            if (rd4.Read())
                            {
                                rd4.Close();
                                string updatestatus = "update classroom set status='free' where classnum='" + cnum + "'";
                                SqlCommand cmd2 = new SqlCommand(updatestatus, con);
                                cmd2.ExecuteNonQuery();
                            }
                            txtslotid.Text = "";
                            combocoursename.Text = "";
                            rdnse.Checked = false;
                            rdnte.Checked = false;
                            rdnbe.Checked = false;
                            comboteacher.Text = "";
                            comboclassnum.Text = "";
                            combotime.Text = "";
                            comboday.Text = "";
                            combotype.Text = "";
                            combobatch.Text = "";
                        }


                    }
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
            loadgridse();
            combocoursename.Items.Clear();
            year = "S.E.";
            string dbpath2 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn = new SqlConnection(dbpath2);
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

        private void rdnte_CheckedChanged(object sender, EventArgs e)
        {
            loadgridte();
            combocoursename.Items.Clear();
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

            comboteacher.Items.Clear();
            string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath1);
            conn1.Open();
            string addquery1 = "select * from teacher where year='" + year + "'";
            SqlCommand cmd1 = new SqlCommand(addquery1, conn1);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboteacher.Items.Add(dr1["tname"].ToString());

            }
            conn1.Close();

        }

        private void rdnbe_CheckedChanged(object sender, EventArgs e)
        {
            loadgridbe();
            combocoursename.Items.Clear();
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

            comboteacher.Items.Clear();
            string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
            SqlConnection conn1 = new SqlConnection(dbpath1);
            conn1.Open();
            string addquery1 = "select * from teacher where year='" + year + "'";
            SqlCommand cmd1 = new SqlCommand(addquery1, conn1);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboteacher.Items.Add(dr1["tname"].ToString());

            }
            conn1.Close();
        }

        private void combocoursename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combotype.Text == "lecture")
            {
                combobatch.Items.Clear();
                combobatch.Items.Add("All Batches");
                combotime.Items.Clear();
                combotime.Items.Add("10:30-11:30");
                combotime.Items.Add("11:30-12:30");
                combotime.Items.Add("1:30-2:30");
                combotime.Items.Add("2:30-3:30");
                combotime.Items.Add("3:45-4:45");
                combotime.Items.Add("4:45-5:45");
            }
            else if (combotype.Text == "practical")
            {
                combobatch.Items.Clear();
                combobatch.Items.Add("A");
                combobatch.Items.Add("B");
                combobatch.Items.Add("C");
                combobatch.Items.Add("D");
                combotime.Items.Clear();
                combotime.Items.Add("10:30-12:30");
                combotime.Items.Add("1:30-3:30");
                combotime.Items.Add("3:45-5:45");
            }
            if (combotype.Text == "lecture")
            {

                comboclassnum.Items.Clear();
                string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
                SqlConnection conn1 = new SqlConnection(dbpath1);
                conn1.Open();
                string addquery1 = "select * from classroom where year='" + year + "' AND type='lecture' AND status='free'";
                SqlCommand cmd1 = new SqlCommand(addquery1, conn1);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    comboclassnum.Items.Add(dr1["classnum"].ToString());

                }
                conn1.Close();
            }
            if(combotype.Text=="practical")
            {
                comboclassnum.Items.Clear();
                string dbpath1 = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = dbtt; Integrated Security = True";
                SqlConnection conn1 = new SqlConnection(dbpath1);
                conn1.Open();
                string addquery1 = "select * from classroom where year='" + year + "' AND type='practical' AND status='free'";
                SqlCommand cmd1 = new SqlCommand(addquery1, conn1);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    comboclassnum.Items.Add(dr1["classnum"].ToString());

                }
                conn1.Close();
            }
        }
    }
}
