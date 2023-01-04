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
    public partial class generatefacultywisett : Form
    {
        string path;
        string showslot;
        string time;
        string day;
        string type;
        string course;
        string tname;
        string hallnum;
        string batch;
        string t1;
        string year;
        int flag;
        void show(string t, string d, string tn)
        {
            path = " Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection conn = new SqlConnection(path);
            showslot = "select * from slot where tname ='" + tn + "' AND time = '" + t + "'  AND day ='" + d + "'";
            SqlCommand command = new SqlCommand(showslot, conn);
            conn.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {


                course = rd.GetString(1);
                year = rd.GetString(6);
                hallnum = rd.GetString(3);
                type = rd.GetString(7);
                batch = rd.GetString(8);
                
                flag = 1;

            }
            else
            {
                flag = 0;
          
            }
            conn.Close();
        }
        public generatefacultywisett()
        {
            InitializeComponent();
        }
        
        private void btngenerate_Click(object sender, EventArgs e)
        {
            tname = txttname.Text;
            time = "10:30-11:30";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon1030.Items.Add(course);
                listmon1030.Items.Add(year);
                listmon1030.Items.Add(type);
                listmon1030.Items.Add(hallnum);
                listmon1030.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "11:30-12:30";
            day = "monday";
            show(time, day, tname);
            if(flag==1)
            {
                listmon1130.Items.Add(course);
                listmon1130.Items.Add(year);
                listmon1130.Items.Add(type);
                listmon1130.Items.Add(hallnum);
                listmon1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-12:30";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon1030.Items.Add(course);
                listmon1030.Items.Add(year);
                listmon1030.Items.Add(type);
                listmon1030.Items.Add(hallnum);
                listmon1030.Items.Add(batch);
                listmon1130.Items.Add(course);
                listmon1130.Items.Add(year);
                listmon1130.Items.Add(type);
                listmon1130.Items.Add(hallnum);
                listmon1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "1:30-2:30";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon130.Items.Add(course);
                listmon130.Items.Add(year);
                listmon130.Items.Add(type);
                listmon130.Items.Add(hallnum);
                listmon130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "2:30-3:30";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon230.Items.Add(course);
                listmon230.Items.Add(year);
                listmon230.Items.Add(type);
                listmon230.Items.Add(hallnum);
                listmon230.Items.Add(batch);
            }


            tname = txttname.Text;
            time = "1:30-3:30";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon130.Items.Add(course);
                listmon130.Items.Add(year);
                listmon130.Items.Add(type);
                listmon130.Items.Add(hallnum);
                listmon130.Items.Add(batch);
                listmon230.Items.Add(course);
                listmon230.Items.Add(year);
                listmon230.Items.Add(type);
                listmon230.Items.Add(hallnum);
                listmon230.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-4:45";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon345.Items.Add(course);
                listmon345.Items.Add(year);
                listmon345.Items.Add(type);
                listmon345.Items.Add(hallnum);
                listmon345.Items.Add(batch);
            }
            tname = txttname.Text;
            time = "4:45-5:45";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon445.Items.Add(course);
                listmon445.Items.Add(year);
                listmon445.Items.Add(type);
                listmon445.Items.Add(hallnum);
                listmon445.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-5:45";
            day = "monday";
            show(time, day, tname);
            if (flag == 1)
            {
                listmon345.Items.Add(course);
                listmon345.Items.Add(year);
                listmon345.Items.Add(type);
                listmon345.Items.Add(hallnum);
                listmon345.Items.Add(batch);
                listmon445.Items.Add(course);
                listmon445.Items.Add(year);
                listmon445.Items.Add(type);
                listmon445.Items.Add(hallnum);
                listmon445.Items.Add(batch);
            }
            tname = txttname.Text;
            time = "10:30-11:30";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue1030.Items.Add(course);
                listtue1030.Items.Add(year);
                listtue1030.Items.Add(type);
                listtue1030.Items.Add(hallnum);
                listtue1030.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "11:30-12:30";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue1130.Items.Add(course);
                listtue1130.Items.Add(year);
                listtue1130.Items.Add(type);
                listtue1130.Items.Add(hallnum);
                listtue1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-12:30";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue1030.Items.Add(course);
                listtue1030.Items.Add(year);
                listtue1030.Items.Add(type);
                listtue1030.Items.Add(hallnum);
                listtue1030.Items.Add(batch);
                listtue1130.Items.Add(course);
                listtue1130.Items.Add(year);
                listtue1130.Items.Add(type);
                listtue1130.Items.Add(hallnum);
                listtue1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "1:30-2:30";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue130.Items.Add(course);
                listtue130.Items.Add(year);
                listtue130.Items.Add(type);
                listtue130.Items.Add(hallnum);
                listtue130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "2:30-3:30";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue230.Items.Add(course);
                listtue230.Items.Add(year);
                listtue230.Items.Add(type);
                listtue230.Items.Add(hallnum);
                listtue230.Items.Add(batch);
            }


            tname = txttname.Text;
            time = "1:30-3:30";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue130.Items.Add(course);
                listtue130.Items.Add(year);
                listtue130.Items.Add(type);
                listtue130.Items.Add(hallnum);
                listtue130.Items.Add(batch);
                listtue230.Items.Add(course);
                listtue230.Items.Add(year);
                listtue230.Items.Add(type);
                listtue230.Items.Add(hallnum);
                listtue230.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-4:45";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue345.Items.Add(course);
                listtue345.Items.Add(year);
                listtue345.Items.Add(type);
                listtue345.Items.Add(hallnum);
                listtue345.Items.Add(batch);
            }
            tname = txttname.Text;
            time = "4:45-5:45";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue445.Items.Add(course);
                listtue445.Items.Add(year);
                listtue445.Items.Add(type);
                listtue445.Items.Add(hallnum);
                listtue445.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-5:45";
            day = "tuesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listtue345.Items.Add(course);
                listtue345.Items.Add(year);
                listtue345.Items.Add(type);
                listtue345.Items.Add(hallnum);
                listtue345.Items.Add(batch);
                listtue445.Items.Add(course);
                listtue445.Items.Add(year);
                listtue445.Items.Add(type);
                listtue445.Items.Add(hallnum);
                listtue445.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-11:30";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed1030.Items.Add(course);
                listwed1030.Items.Add(year);
                listwed1030.Items.Add(type);
                listwed1030.Items.Add(hallnum);
                listwed1030.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "11:30-12:30";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed1130.Items.Add(course);
                listwed1130.Items.Add(year);
                listwed1130.Items.Add(type);
                listwed1130.Items.Add(hallnum);
                listwed1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-12:30";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed1030.Items.Add(course);
                listwed1030.Items.Add(year);
                listwed1030.Items.Add(type);
                listwed1030.Items.Add(hallnum);
                listwed1030.Items.Add(batch);
                listwed1130.Items.Add(course);
                listwed1130.Items.Add(year);
                listwed1130.Items.Add(type);
                listwed1130.Items.Add(hallnum);
                listwed1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "1:30-2:30";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed130.Items.Add(course);
                listwed130.Items.Add(year);
                listwed130.Items.Add(type);
                listwed130.Items.Add(hallnum);
                listwed130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "2:30-3:30";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed230.Items.Add(course);
                listwed230.Items.Add(year);
                listwed230.Items.Add(type);
                listwed230.Items.Add(hallnum);
                listwed230.Items.Add(batch);
            }


            tname = txttname.Text;
            time = "1:30-3:30";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed130.Items.Add(course);
                listwed130.Items.Add(year);
                listwed130.Items.Add(type);
                listwed130.Items.Add(hallnum);
                listwed130.Items.Add(batch);
                listwed230.Items.Add(course);
                listwed230.Items.Add(year);
                listwed230.Items.Add(type);
                listwed230.Items.Add(hallnum);
                listwed230.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-4:45";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed345.Items.Add(course);
                listwed345.Items.Add(year);
                listwed345.Items.Add(type);
                listwed345.Items.Add(hallnum);
                listwed345.Items.Add(batch);
            }
            tname = txttname.Text;
            time = "4:45-5:45";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed445.Items.Add(course);
                listwed445.Items.Add(year);
                listwed445.Items.Add(type);
                listwed445.Items.Add(hallnum);
                listwed445.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-5:45";
            day = "wednesday";
            show(time, day, tname);
            if (flag == 1)
            {
                listwed345.Items.Add(course);
                listwed345.Items.Add(year);
                listwed345.Items.Add(type);
                listwed345.Items.Add(hallnum);
                listwed345.Items.Add(batch);
                listwed445.Items.Add(course);
                listwed445.Items.Add(year);
                listwed445.Items.Add(type);
                listwed445.Items.Add(hallnum);
                listwed445.Items.Add(batch);
            }


            tname = txttname.Text;
            time = "10:30-11:30";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur1030.Items.Add(course);
                listthur1030.Items.Add(year);
                listthur1030.Items.Add(type);
                listthur1030.Items.Add(hallnum);
                listthur1030.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "11:30-12:30";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur1130.Items.Add(course);
                listthur1130.Items.Add(year);
                listthur1130.Items.Add(type);
                listthur1130.Items.Add(hallnum);
                listthur1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-12:30";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur1030.Items.Add(course);
                listthur1030.Items.Add(year);
                listthur1030.Items.Add(type);
                listthur1030.Items.Add(hallnum);
                listthur1030.Items.Add(batch);
                listthur1130.Items.Add(course);
                listthur1130.Items.Add(year);
                listthur1130.Items.Add(type);
                listthur1130.Items.Add(hallnum);
                listthur1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "1:30-2:30";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur130.Items.Add(course);
                listthur130.Items.Add(year);
                listthur130.Items.Add(type);
                listthur130.Items.Add(hallnum);
                listthur130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "2:30-3:30";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur230.Items.Add(course);
                listthur230.Items.Add(year);
                listthur230.Items.Add(type);
                listthur230.Items.Add(hallnum);
                listthur230.Items.Add(batch);
            }


            tname = txttname.Text;
            time = "1:30-3:30";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur130.Items.Add(course);
                listthur130.Items.Add(year);
                listthur130.Items.Add(type);
                listthur130.Items.Add(hallnum);
                listthur130.Items.Add(batch);
                listthur230.Items.Add(course);
                listthur230.Items.Add(year);
                listthur230.Items.Add(type);
                listthur230.Items.Add(hallnum);
                listthur230.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-4:45";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur345.Items.Add(course);
                listthur345.Items.Add(year);
                listthur345.Items.Add(type);
                listthur345.Items.Add(hallnum);
                listthur345.Items.Add(batch);
            }
            tname = txttname.Text;
            time = "4:45-5:45";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur445.Items.Add(course);
                listthur445.Items.Add(year);
                listthur445.Items.Add(type);
                listthur445.Items.Add(hallnum);
                listthur445.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-5:45";
            day = "thursday";
            show(time, day, tname);
            if (flag == 1)
            {
                listthur345.Items.Add(course);
                listthur345.Items.Add(year);
                listthur345.Items.Add(type);
                listthur345.Items.Add(hallnum);
                listthur345.Items.Add(batch);
                listthur445.Items.Add(course);
                listthur445.Items.Add(year);
                listthur445.Items.Add(type);
                listthur445.Items.Add(hallnum);
                listthur445.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-11:30";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri1030.Items.Add(course);
                listfri1030.Items.Add(year);
                listfri1030.Items.Add(type);
                listfri1030.Items.Add(hallnum);
                listfri1030.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "11:30-12:30";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri1130.Items.Add(course);
                listfri1130.Items.Add(year);
                listfri1130.Items.Add(type);
                listfri1130.Items.Add(hallnum);
                listfri1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-12:30";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri1030.Items.Add(course);
                listfri1030.Items.Add(year);
                listfri1030.Items.Add(type);
                listfri1030.Items.Add(hallnum);
                listfri1030.Items.Add(batch);
                listfri1130.Items.Add(course);
                listfri1130.Items.Add(year);
                listfri1130.Items.Add(type);
                listfri1130.Items.Add(hallnum);
                listfri1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "1:30-2:30";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri130.Items.Add(course);
                listfri130.Items.Add(year);
                listfri130.Items.Add(type);
                listfri130.Items.Add(hallnum);
                listfri130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "2:30-3:30";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri230.Items.Add(course);
                listfri230.Items.Add(year);
                listfri230.Items.Add(type);
                listfri230.Items.Add(hallnum);
                listfri230.Items.Add(batch);
            }


            tname = txttname.Text;
            time = "1:30-3:30";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                 listfri130.Items.Add(course);
                listfri130.Items.Add(year);
                listfri130.Items.Add(type);
                listfri130.Items.Add(hallnum);
                listfri130.Items.Add(batch);
                listfri230.Items.Add(course);
                listfri230.Items.Add(year);
                listfri230.Items.Add(type);
                listfri230.Items.Add(hallnum);
                listfri230.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-4:45";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri345.Items.Add(course);
                listfri345.Items.Add(year);
                listfri345.Items.Add(type);
                listfri345.Items.Add(hallnum);
                listfri345.Items.Add(batch);
            }
            tname = txttname.Text;
            time = "4:45-5:45";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri445.Items.Add(course);
                listfri445.Items.Add(year);
                listfri445.Items.Add(type);
                listfri445.Items.Add(hallnum);
                listfri445.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "3:45-5:45";
            day = "friday";
            show(time, day, tname);
            if (flag == 1)
            {
                listfri345.Items.Add(course);
                listfri345.Items.Add(year);
                listfri345.Items.Add(type);
                listfri345.Items.Add(hallnum);
                listfri345.Items.Add(batch);
                listfri445.Items.Add(course);
                listfri445.Items.Add(year);
                listfri445.Items.Add(type);
                listfri445.Items.Add(hallnum);
                listfri445.Items.Add(batch);
            }

             tname = txttname.Text;
            time = "10:30-11:30";
            day = "saturday";
            show(time, day, tname);
            if (flag == 1)
            {
                listsat1030.Items.Add(course);
                listsat1030.Items.Add(year);
                listsat1030.Items.Add(type);
                listsat1030.Items.Add(hallnum);
                listsat1030.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "11:30-12:30";
            day = "saturday";
            show(time, day, tname);
            if (flag == 1)
            {
                listsat1130.Items.Add(course);
                listsat1130.Items.Add(year);
                listsat1130.Items.Add(type);
                listsat1130.Items.Add(hallnum);
                listsat1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "10:30-12:30";
            day = "saturday";
            show(time, day, tname);
            if (flag == 1)
            {
                listsat1030.Items.Add(course);
                listsat1030.Items.Add(year);
                listsat1030.Items.Add(type);
                listsat1030.Items.Add(hallnum);
                listsat1030.Items.Add(batch);
                listsat1130.Items.Add(course);
                listsat1130.Items.Add(year);
                listsat1130.Items.Add(type);
                listsat1130.Items.Add(hallnum);
                listsat1130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "1:30-2:30";
            day = "saturday";
            show(time, day, tname);
            if (flag == 1)
            {
                listsat130.Items.Add(course);
                listsat130.Items.Add(year);
                listsat130.Items.Add(type);
                listsat130.Items.Add(hallnum);
                listsat130.Items.Add(batch);
            }

            tname = txttname.Text;
            time = "2:30-3:30";
            day = "saturday";
            show(time, day, tname);
            if (flag == 1)
            {
                listsat230.Items.Add(course);
                listsat230.Items.Add(year);
                listsat230.Items.Add(type);
                listsat230.Items.Add(hallnum);
                listsat230.Items.Add(batch);
            }


            tname = txttname.Text;
            time = "1:30-3:30";
            day = "saturday";
            show(time, day, tname);
            if (flag == 1)
            {
                listsat130.Items.Add(course);
                listsat130.Items.Add(year);
                listsat130.Items.Add(type);
                listsat130.Items.Add(hallnum);
                listsat130.Items.Add(batch);
                listsat230.Items.Add(course);
                listsat230.Items.Add(year);
                listsat230.Items.Add(type);
                listsat230.Items.Add(hallnum);
                listsat230.Items.Add(batch);
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Tag = this;
            frm.Show(this);
            Hide();
        }
    }
}
