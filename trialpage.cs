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
    public partial class trialpage : Form
    {

        string path;
        string showslot;
        string type;
        string course;
        string teacher;
        string hallnum;
        string batch;
        string t1;

        void show(string t,string d,string tn)
        {
            path = " Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection conn = new SqlConnection(path);
            showslot = "select * from slot where time ='" + t + "' AND day = '" + d + "'  AND tname='" + tn + "'";
            SqlCommand command = new SqlCommand(showslot, conn);
            conn.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {


                course = rd.GetString(1);
                teacher = rd.GetString(2);
                hallnum = rd.GetString(3);
                type = rd.GetString(7);
                batch = rd.GetString(8);
                t1 = course + " " + teacher + " " + hallnum + " " + batch;
                listBox1.Items.Add(t1);

            }
            else
            {
                listBox1.Items.Add("entered else");

            }
            conn.Close();
        }
    
        public trialpage()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            show("11:30-12:30","monday","kca");
        }
    }
}
