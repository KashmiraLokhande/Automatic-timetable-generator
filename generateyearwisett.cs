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
    public partial class generateyearwisett : Form
    {
        string path;
        string showslot;
        string time;
        string day;
        string type;
        string course;
        string teacher;
        string hallnum;
        string batch;
        string t1;
        string year;
        int flag=0;
        string t2="free";
        void show(string t, string d, string ty ,string b,string y)
        {
            path = " Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbtt;Integrated Security=True";
            SqlConnection conn = new SqlConnection(path);
            showslot = "select * from slot where time ='" + t + "' AND day = '" + d + "' AND type='" + ty + "' AND batch = '" + b + "'  AND year ='"+y+"'";
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
                     flag = 1;
                
            }
            else
            {
                flag = 0;
                
            }
            conn.Close();
        }
        public generateyearwisett()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
           if(comboyear.Text=="T.E.")
            {
                
                time = "10:30-11:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch,year);
                if (flag == 1)
                {
                    listmon1030.Items.Add(course);
                    listmon1030.Items.Add(teacher);
                    listmon1030.Items.Add(hallnum);
                    listmon1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }
                    if(type=="practical" && flag==0)
                    {
                        listmon1030.Items.Add(t2);
                    }
                }


                time = "11:30-12:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon1130.Items.Add(course);
                    listmon1130.Items.Add(teacher);
                    listmon1130.Items.Add(hallnum);
                    listmon1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }

                    if(type=="practical" && flag==0)
                    {
                        listmon1130.Items.Add(t2);
                    }

                }
                time = "1:30-2:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon130.Items.Add(course);
                    listmon130.Items.Add(teacher);
                    listmon130.Items.Add(hallnum);
                    listmon130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }
                    if(type=="practical" && flag==0)
                    {
                        listmon130.Items.Add(t2);
                    }
                }
                time = "2:30-3:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon230.Items.Add(course);
                    listmon230.Items.Add(teacher);
                    listmon230.Items.Add(hallnum);
                    listmon230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listmon230.Items.Add(t2);
                    }
                 }


                time = "3:45-4:45";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon345.Items.Add(course);
                    listmon345.Items.Add(teacher);
                    listmon345.Items.Add(hallnum);
                    listmon345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon345.Items.Add(t2);
                    }
                }


                time = "4:45-5:45";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon445.Items.Add(course);
                    listmon445.Items.Add(teacher);
                    listmon445.Items.Add(hallnum);
                    listmon445.Items.Add(batch);
                }

                if (type == "lecture" && flag == 0)
                {

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon445.Items.Add(t2);
                    }
                }
                time = "10:30-11:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue1030.Items.Add(course);
                    listtue1030.Items.Add(teacher);
                    listtue1030.Items.Add(hallnum);
                    listtue1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue1030.Items.Add(t2);
                    }
                }


                time = "11:30-12:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue1130.Items.Add(course);
                    listtue1130.Items.Add(teacher);
                    listtue1130.Items.Add(hallnum);
                    listtue1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }
                    if(type == "practical" && flag == 0)
                    {
                        listtue1130.Items.Add(t2);
                    }
                }
                time = "1:30-2:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue130.Items.Add(course);
                    listtue130.Items.Add(teacher);
                    listtue130.Items.Add(hallnum);
                    listtue130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue130.Items.Add(t2);
                    }
                }
                time = "2:30-3:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue230.Items.Add(course);
                    listtue230.Items.Add(teacher);
                    listtue230.Items.Add(hallnum);
                    listtue230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue230.Items.Add(t2);
                    }
                    }
                time = "3:45-4:45";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue345.Items.Add(course);
                    listtue345.Items.Add(teacher);
                    listtue345.Items.Add(hallnum);
                    listtue345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue345.Items.Add(t2);
                    }
                }

                time = "4:45-5:45";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue445.Items.Add(course);
                    listtue445.Items.Add(teacher);
                    listtue445.Items.Add(hallnum);
                    listtue445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue445.Items.Add(t2);
                    }
                }
                time = "10:30-11:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed1030.Items.Add(course);
                    listwed1030.Items.Add(teacher);
                    listwed1030.Items.Add(hallnum);
                    listwed1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }
                time = "11:30-12:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed1130.Items.Add(course);
                    listwed1130.Items.Add(teacher);
                    listwed1130.Items.Add(hallnum);
                    listwed1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "1:30-2:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed130.Items.Add(course);
                    listwed130.Items.Add(teacher);
                    listwed130.Items.Add(hallnum);
                    listwed130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "2:30-3:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed230.Items.Add(course);
                    listwed230.Items.Add(teacher);
                    listwed230.Items.Add(hallnum);
                    listwed230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "3:45-4:45";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed345.Items.Add(course);
                    listwed345.Items.Add(teacher);
                    listwed345.Items.Add(hallnum);
                    listwed345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }

                time = "4:45-5:45";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed445.Items.Add(course);
                    listwed445.Items.Add(teacher);
                    listwed445.Items.Add(hallnum);
                    listwed445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "10:30-11:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur1030.Items.Add(course);
                    listthur1030.Items.Add(teacher);
                    listthur1030.Items.Add(hallnum);
                    listthur1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }



                time = "11:30-12:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur1130.Items.Add(course);
                    listthur1130.Items.Add(teacher);
                    listthur1130.Items.Add(hallnum);
                    listthur1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur130.Items.Add(course);
                    listthur130.Items.Add(teacher);
                    listthur130.Items.Add(hallnum);
                    listthur130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur230.Items.Add(course);
                    listthur230.Items.Add(teacher);
                    listthur230.Items.Add(hallnum);
                    listthur230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "3:45-4:45";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur345.Items.Add(course);
                    listthur345.Items.Add(teacher);
                    listthur345.Items.Add(hallnum);
                    listthur345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "4:45-5:45";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur445.Items.Add(course);
                    listthur445.Items.Add(teacher);
                    listthur445.Items.Add(hallnum);
                    listthur445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "10:30-11:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1030.Items.Add(course);
                    listfri1030.Items.Add(teacher);
                    listfri1030.Items.Add(hallnum);
                    listfri1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "11:30-12:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1130.Items.Add(course);
                    listfri1130.Items.Add(teacher);
                    listfri1130.Items.Add(hallnum);
                    listfri1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri130.Items.Add(course);
                    listfri130.Items.Add(teacher);
                    listfri130.Items.Add(hallnum);
                    listfri130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }

                time = "2:30-3:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri230.Items.Add(course);
                    listfri230.Items.Add(teacher);
                    listfri230.Items.Add(hallnum);
                    listfri230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "3:45-4:45";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri345.Items.Add(course);
                    listfri345.Items.Add(teacher);
                    listfri345.Items.Add(hallnum);
                    listfri345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "4:45-5:45";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri445.Items.Add(course);
                    listfri445.Items.Add(teacher);
                    listfri445.Items.Add(hallnum);
                    listfri445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "10:30-11:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1030.Items.Add(course);
                    listsat1030.Items.Add(teacher);
                    listsat1030.Items.Add(hallnum);
                    listsat1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "11:30-12:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1130.Items.Add(course);
                    listsat1130.Items.Add(teacher);
                    listsat1130.Items.Add(hallnum);
                    listsat1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat130.Items.Add(course);
                    listsat130.Items.Add(teacher);
                    listsat130.Items.Add(hallnum);
                    listsat130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }


                time = "2:30-3:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "T.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat230.Items.Add(course);
                    listsat230.Items.Add(teacher);
                    listsat230.Items.Add(hallnum);
                    listsat230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "T.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }
                }

            }

           if(comboyear.Text=="S.E.")
            {


                time = "10:30-11:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon1030.Items.Add(course);
                    listmon1030.Items.Add(teacher);
                    listmon1030.Items.Add(hallnum);
                    listmon1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listmon1030.Items.Add(t2);
                    }
                }



                time = "11:30-12:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon1130.Items.Add(course);
                    listmon1130.Items.Add(teacher);
                    listmon1130.Items.Add(hallnum);
                    listmon1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listmon1130.Items.Add(t2);
                    }
                }


                time = "1:30-2:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon130.Items.Add(course);
                    listmon130.Items.Add(teacher);
                    listmon130.Items.Add(hallnum);
                    listmon130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listmon130.Items.Add(t2);
                    }
                }

                time = "2:30-3:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon230.Items.Add(course);
                    listmon230.Items.Add(teacher);
                    listmon230.Items.Add(hallnum);
                    listmon230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listmon230.Items.Add(t2);
                    }
                }


                time = "3:45-4:45";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon345.Items.Add(course);
                    listmon345.Items.Add(teacher);
                    listmon345.Items.Add(hallnum);
                    listmon345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon345.Items.Add(t2);
                    }

                }


                time = "4:45-5:45";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon445.Items.Add(course);
                    listmon445.Items.Add(teacher);
                    listmon445.Items.Add(hallnum);
                    listmon445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon445.Items.Add(t2);
                    }
                }


                time = "10:30-11:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue1030.Items.Add(course);
                    listtue1030.Items.Add(teacher);
                    listtue1030.Items.Add(hallnum);
                    listtue1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listtue1030.Items.Add(t2);
                    }
                }


                time = "11:30-12:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue1130.Items.Add(course);
                    listtue1130.Items.Add(teacher);
                    listtue1130.Items.Add(hallnum);
                    listtue1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue1130.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue130.Items.Add(course);
                    listtue130.Items.Add(teacher);
                    listtue130.Items.Add(hallnum);
                    listtue130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue130.Items.Add(t2);
                    }

                }


                time = "2:30-3:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue230.Items.Add(course);
                    listtue230.Items.Add(teacher);
                    listtue230.Items.Add(hallnum);
                    listtue230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue230.Items.Add(t2);
                    }

                }


                time = "3:45-4:45";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue345.Items.Add(course);
                    listtue345.Items.Add(teacher);
                    listtue345.Items.Add(hallnum);
                    listtue345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue345.Items.Add(t2);
                    }

                }


                time = "4:45-5:45";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue445.Items.Add(course);
                    listtue445.Items.Add(teacher);
                    listtue445.Items.Add(hallnum);
                    listtue445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue445.Items.Add(t2);
                    }

                }


                time = "10:30-11:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed1030.Items.Add(course);
                    listwed1030.Items.Add(teacher);
                    listwed1030.Items.Add(hallnum);
                    listwed1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "11:30-12:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed1130.Items.Add(course);
                    listwed1130.Items.Add(teacher);
                    listwed1130.Items.Add(hallnum);
                    listwed1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1130.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed130.Items.Add(course);
                    listwed130.Items.Add(teacher);
                    listwed130.Items.Add(hallnum);
                    listwed130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed130.Items.Add(t2);
                    }
                }


                time = "2:30-3:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed230.Items.Add(course);
                    listwed230.Items.Add(teacher);
                    listwed230.Items.Add(hallnum);
                    listwed230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed230.Items.Add(t2);
                    }
                }


                time = "3:45-4:45";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed345.Items.Add(course);
                    listwed345.Items.Add(teacher);
                    listwed345.Items.Add(hallnum);
                    listwed345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed345.Items.Add(t2);
                    }
                }


                time = "4:45-5:45";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed445.Items.Add(course);
                    listwed445.Items.Add(teacher);
                    listwed445.Items.Add(hallnum);
                    listwed445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed445.Items.Add(t2);
                    }
                }


                time = "10:30-11:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur1030.Items.Add(course);
                    listthur1030.Items.Add(teacher);
                    listthur1030.Items.Add(hallnum);
                    listthur1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listthur1030.Items.Add(t2);
                    }

                }


                time = "11:30-12:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur1130.Items.Add(course);
                    listthur1130.Items.Add(teacher);
                    listthur1130.Items.Add(hallnum);
                    listthur1130.Items.Add(batch);
                }

                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listthur1130.Items.Add(t2);
                    }
                }


                time = "1:30-2:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur130.Items.Add(course);
                    listthur130.Items.Add(teacher);
                    listthur130.Items.Add(hallnum);
                    listthur130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listthur130.Items.Add(t2);
                    }
                }


                time = "1:30-2:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur230.Items.Add(course);
                    listthur230.Items.Add(teacher);
                    listthur230.Items.Add(hallnum);
                    listthur230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listthur230.Items.Add(t2);
                    }

                }


                time = "3:45-4:45";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur345.Items.Add(course);
                    listthur345.Items.Add(teacher);
                    listthur345.Items.Add(hallnum);
                    listthur345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listthur345.Items.Add(t2);
                    }
                }



                time = "4:45-5:45";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur445.Items.Add(course);
                    listthur445.Items.Add(teacher);
                    listthur445.Items.Add(hallnum);
                    listthur445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listthur445.Items.Add(t2);
                    }

                }


                time = "10:30-11:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1030.Items.Add(course);
                    listfri1030.Items.Add(teacher);
                    listfri1030.Items.Add(hallnum);
                    listfri1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1030.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listfri1030.Items.Add(t2);
                    }
                }


                time = "11:30-12:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1130.Items.Add(course);
                    listfri1130.Items.Add(teacher);
                    listfri1130.Items.Add(hallnum);
                    listfri1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }

                    time = "10:30-11:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listfri1130.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri130.Items.Add(course);
                    listfri130.Items.Add(teacher);
                    listfri130.Items.Add(hallnum);
                    listfri130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listfri130.Items.Add(t2);
                    }

                }


                time = "2:30-3:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri230.Items.Add(course);
                    listfri230.Items.Add(teacher);
                    listfri230.Items.Add(hallnum);
                    listfri230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listfri230.Items.Add(t2);
                    }

                }



                time = "3:45-4:45";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri345.Items.Add(course);
                    listfri345.Items.Add(teacher);
                    listfri345.Items.Add(hallnum);
                    listfri345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listfri345.Items.Add(t2);
                    }
                }



                time = "4:45-5:45";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri445.Items.Add(course);
                    listfri445.Items.Add(teacher);
                    listfri445.Items.Add(hallnum);
                    listfri445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "friday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listfri445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listfri445.Items.Add(t2);
                    }
                }



                time = "10:30-11:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1030.Items.Add(course);
                    listsat1030.Items.Add(teacher);
                    listsat1030.Items.Add(hallnum);
                    listsat1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listsat1030.Items.Add(t2);
                    }

                }


                time = "11:30-12:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1130.Items.Add(course);
                    listsat1130.Items.Add(teacher);
                    listsat1130.Items.Add(hallnum);
                    listsat1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listsat1130.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat130.Items.Add(course);
                    listsat130.Items.Add(teacher);
                    listsat130.Items.Add(hallnum);
                    listsat130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listsat130.Items.Add(t2);
                    }

                }



                time = "2:30-3:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "S.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat230.Items.Add(course);
                    listsat230.Items.Add(teacher);
                    listsat230.Items.Add(hallnum);
                    listsat230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "A";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "B";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "C";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "saturday";
                    type = "practical";
                    batch = "D";
                    year = "S.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listsat230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listsat230.Items.Add(t2);
                    }

                }


            }

            if (comboyear.Text == "B.E.")
            {

                time = "10:30-11:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon1030.Items.Add(course);
                    listmon1030.Items.Add(teacher);
                    listmon1030.Items.Add(hallnum);
                    listmon1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon1030.Items.Add(t2);
                    }
                }



                time = "11:30-12:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon1130.Items.Add(course);
                    listmon1130.Items.Add(teacher);
                    listmon1130.Items.Add(hallnum);
                    listmon1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon1130.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon130.Items.Add(course);
                    listmon130.Items.Add(teacher);
                    listmon130.Items.Add(hallnum);
                    listmon130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listmon130.Items.Add(t2);
                    }
                }



                time = "2:30-3:30";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon230.Items.Add(course);
                    listmon230.Items.Add(teacher);
                    listmon230.Items.Add(hallnum);
                    listmon230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon230.Items.Add(t2);
                    }

                }


                time = "3:45-4:45";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon345.Items.Add(course);
                    listmon345.Items.Add(teacher);
                    listmon345.Items.Add(hallnum);
                    listmon345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon345.Items.Add(t2);
                    }

                }


                time = "4:45-5:45";
                day = "monday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listmon445.Items.Add(course);
                    listmon445.Items.Add(teacher);
                    listmon445.Items.Add(hallnum);
                    listmon445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "monday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listmon445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listmon445.Items.Add(t2);
                    }

                }


                time = "10:30-11:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue1030.Items.Add(course);
                    listtue1030.Items.Add(teacher);
                    listtue1030.Items.Add(hallnum);
                    listtue1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }


                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1030.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listtue1030.Items.Add(t2);
                    }
                }


                time = "11:30-12:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue1130.Items.Add(course);
                    listtue1130.Items.Add(teacher);
                    listtue1130.Items.Add(hallnum);
                    listtue1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue1130.Items.Add(t2);
                    }
                }



                time = "1:30-2:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue130.Items.Add(course);
                    listtue130.Items.Add(teacher);
                    listtue130.Items.Add(hallnum);
                    listtue130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue130.Items.Add(t2);
                    }

                }


                time = "2:30-3:30";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue230.Items.Add(course);
                    listtue230.Items.Add(teacher);
                    listtue230.Items.Add(hallnum);
                    listtue230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue230.Items.Add(t2);
                    }

                }


                time = "3:45-4:45";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue345.Items.Add(course);
                    listtue345.Items.Add(teacher);
                    listtue345.Items.Add(hallnum);
                    listtue345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue345.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue345.Items.Add(t2);
                    }

                }


                time = "4:45-5:45";
                day = "tuesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listtue445.Items.Add(course);
                    listtue445.Items.Add(teacher);
                    listtue445.Items.Add(hallnum);
                    listtue445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "tuesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listtue445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listtue445.Items.Add(t2);
                    }
                }



                time = "10:30-11:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed1030.Items.Add(course);
                    listwed1030.Items.Add(teacher);
                    listwed1030.Items.Add(hallnum);
                    listwed1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1030.Items.Add(t2);
                    }

                }


                time = "11:30-12:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed1130.Items.Add(course);
                    listwed1130.Items.Add(teacher);
                    listwed1130.Items.Add(hallnum);
                    listwed1130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed1130.Items.Add(t2);
                    }

                }


                time = "1:30-2:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed130.Items.Add(course);
                    listwed130.Items.Add(teacher);
                    listwed130.Items.Add(hallnum);
                    listwed130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed130.Items.Add(t2);
                    }

                }


                time = "2:30-3:30";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed230.Items.Add(course);
                    listwed230.Items.Add(teacher);
                    listwed230.Items.Add(hallnum);
                    listwed230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed230.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed230.Items.Add(t2);
                    }
                }



                time = "3:45-4:45";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed345.Items.Add(course);
                    listwed345.Items.Add(teacher);
                    listwed345.Items.Add(hallnum);
                    listwed345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed345.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listwed345.Items.Add(t2);
                    }

                }


                time = "4:45-5:45";
                day = "wednesday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listwed445.Items.Add(course);
                    listwed445.Items.Add(teacher);
                    listwed445.Items.Add(hallnum);
                    listwed445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "wednesday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listwed445.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listwed445.Items.Add(t2);
                    }

                }


                time = "10:30-11:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur1030.Items.Add(course);
                    listthur1030.Items.Add(teacher);
                    listthur1030.Items.Add(hallnum);
                    listthur1030.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1030.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listthur1030.Items.Add(t2);
                    }

                }


                time = "11:30-12:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur1130.Items.Add(course);
                    listthur1130.Items.Add(teacher);
                    listthur1130.Items.Add(hallnum);
                    listthur1130.Items.Add(batch);
                }

                if (type == "lecture" && flag == 0)
                {

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }

                    time = "10:30-12:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur1130.Items.Add(t1);
                    }
                    if (type == "practical" && flag == 0)
                    {
                        listthur1130.Items.Add(t2);
                    }


                }


                time = "1:30-2:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur130.Items.Add(course);
                    listthur130.Items.Add(teacher);
                    listthur130.Items.Add(hallnum);
                    listthur130.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur130.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listthur130.Items.Add(t2);
                    }
                }


                time = "1:30-2:30";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur230.Items.Add(course);
                    listthur230.Items.Add(teacher);
                    listthur230.Items.Add(hallnum);
                    listthur230.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }

                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }


                    time = "1:30-3:30";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur230.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listthur230.Items.Add(t2);
                    }
                }


                time = "3:45-4:45";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur345.Items.Add(course);
                    listthur345.Items.Add(teacher);
                    listthur345.Items.Add(hallnum);
                    listthur345.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur345.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listthur345.Items.Add(t2);
                    }

                }


                time = "4:45-5:45";
                day = "thursday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listthur445.Items.Add(course);
                    listthur445.Items.Add(teacher);
                    listthur445.Items.Add(hallnum);
                    listthur445.Items.Add(batch);
                }
                if (type == "lecture" && flag == 0)
                {
                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "A";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "B";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "C";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    time = "3:45-5:45";
                    day = "thursday";
                    type = "practical";
                    batch = "D";
                    year = "B.E.";
                    show(time, day, type, batch, year);
                    if (flag == 1)
                    {
                        listthur445.Items.Add(t1);
                    }

                    if (type == "practical" && flag == 0)
                    {
                        listthur445.Items.Add(t2);
                    }

                }


                time = "10:30-11:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1030.Items.Add(course);
                    listfri1030.Items.Add(teacher);
                    listfri1030.Items.Add(hallnum);
                    listfri1030.Items.Add(batch);
                }

                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1030.Items.Add(t1);
                }

                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1030.Items.Add(t1);
                }

                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1030.Items.Add(t1);
                }

                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1030.Items.Add(t1);
                }

                if (type == "practical" && flag == 0)
                {
                    listfri1030.Items.Add(t2);
                }

            }


                time = "11:30-12:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1130.Items.Add(course);
                    listfri1130.Items.Add(teacher);
                    listfri1130.Items.Add(hallnum);
                    listfri1130.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1130.Items.Add(t1);
                }

                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1130.Items.Add(t1);
                }

                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1130.Items.Add(t1);
                }

                time = "10:30-11:30";
                day = "friday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri1130.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listfri1130.Items.Add(t2);
                }

            }


                time = "1:30-2:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri130.Items.Add(course);
                    listfri130.Items.Add(teacher);
                    listfri130.Items.Add(hallnum);
                    listfri130.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri130.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri130.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri130.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri130.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listfri130.Items.Add(t2);
                }

            }


                time = "2:30-3:30";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri230.Items.Add(course);
                    listfri230.Items.Add(teacher);
                    listfri230.Items.Add(hallnum);
                    listfri230.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri230.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri230.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri230.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "friday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri230.Items.Add(t1);
                }

                if (type == "practical" && flag == 0)
                {
                    listfri230.Items.Add(t2);
                }
            }


                time = "3:45-4:45";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri345.Items.Add(course);
                    listfri345.Items.Add(teacher);
                    listfri345.Items.Add(hallnum);
                    listfri345.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri345.Items.Add(t1);
                }

                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri345.Items.Add(t1);
                }

                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri345.Items.Add(t1);
                }

                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri345.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listfri345.Items.Add(t2);
                }

            }


                time = "4:45-5:45";
                day = "friday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri445.Items.Add(course);
                    listfri445.Items.Add(teacher);
                    listfri445.Items.Add(hallnum);
                    listfri445.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri445.Items.Add(t1);
                }

                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri445.Items.Add(t1);
                }

                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri445.Items.Add(t1);
                }

                time = "3:45-5:45";
                day = "friday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listfri445.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listfri445.Items.Add(t2);
                }

            }


                time = "10:30-11:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1030.Items.Add(course);
                    listsat1030.Items.Add(teacher);
                    listsat1030.Items.Add(hallnum);
                    listsat1030.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1030.Items.Add(t1);
                }

                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1030.Items.Add(t1);
                }

                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1030.Items.Add(t1);
                }

                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1030.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listsat1030.Items.Add(t2);
                }

            }


                time = "11:30-12:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1130.Items.Add(course);
                    listsat1130.Items.Add(teacher);
                    listsat1130.Items.Add(hallnum);
                    listsat1130.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1130.Items.Add(t1);
                }

                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1130.Items.Add(t1);
                }

                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1130.Items.Add(t1);
                }


                time = "10:30-12:30";
                day = "saturday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat1130.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listsat1130.Items.Add(t2);
                }
            }


            
                time = "1:30-2:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat130.Items.Add(course);
                    listsat130.Items.Add(teacher);
                    listsat130.Items.Add(hallnum);
                    listsat130.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat130.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat130.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat130.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat130.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listsat130.Items.Add(t2);
                }
            }



                time = "2:30-3:30";
                day = "saturday";
                type = "lecture";
                batch = "All batches";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat230.Items.Add(course);
                    listsat230.Items.Add(teacher);
                    listsat230.Items.Add(hallnum);
                    listsat230.Items.Add(batch);
                }
            if (type == "lecture" && flag == 0)
            {
                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "A";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat230.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "B";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat230.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "C";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat230.Items.Add(t1);
                }

                time = "1:30-3:30";
                day = "saturday";
                type = "practical";
                batch = "D";
                year = "B.E.";
                show(time, day, type, batch, year);
                if (flag == 1)
                {
                    listsat230.Items.Add(t1);
                }
                if (type == "practical" && flag == 0)
                {
                    listsat230.Items.Add(t2);
                }



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

