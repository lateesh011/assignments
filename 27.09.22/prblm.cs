using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businessaccess;
using helper;
using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Sep27Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Course 2.Student 3.examcard");
            int m = Convert.ToInt32(Console.ReadLine());
            he_course pi = new he_course();
            he_student plo=new he_student();
            he_exam ploo = new he_exam();
            switch (m) {
                
                case 1:
                    Console.WriteLine("1.Insert 2.Update 3.Delete 4.Find 5.Showall");
                    int k = Convert.ToInt32(Console.ReadLine());
                    switch (k) {
                        case 1:
            bal_course po = new bal_course();
                    Console.WriteLine("Enter course id");
                    po.courseid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter course name");
                    po.cname = Console.ReadLine();
                    Console.WriteLine("Enter dept id");
                    po.deptid = Console.ReadLine();
                    Console.WriteLine("Enter duration");
                    po.duration = Convert.ToInt32(Console.ReadLine());
                  
                    bool s = pi.insertingcourse(po);
                    if (s)
                    {
                        Console.WriteLine("Inserted successfully");

                    }
                    else
                    {
                        Console.WriteLine("Not done");
                    }
                    Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the course no you want to update");
                            int ki=Convert.ToInt32(Console.ReadLine());
                            bal_course poi = new bal_course();
                            Console.WriteLine("Enter new course id");
                            poi.courseid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter course name");
                            poi.cname = Console.ReadLine();
                            Console.WriteLine("Enter dept id");
                            poi.deptid = Console.ReadLine();
                            Console.WriteLine("Enter duration");
                            poi.duration = Convert.ToInt32(Console.ReadLine());
                            bool si = pi.updatecourse(ki,poi);
                            if (si)
                            {
                                Console.WriteLine("Updated successfully");

                            }
                            else
                            {
                                Console.WriteLine("Not done");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter course no you want to delete");
                            int moi = Convert.ToInt32(Console.ReadLine());
                            bool sii = pi.deletecourse(moi);
                            if (sii)
                            {
                                Console.WriteLine("deleted successfully");

                            }
                            else
                            {
                                Console.WriteLine("Not done");
                            }
                            break;
                        case 4:
                            bal_course pl = new bal_course();
                            Console.WriteLine("Enter course no you want to find");
                            int moii = Convert.ToInt32(Console.ReadLine());
                            pl = pi.findcourse(moii);
                            if (pl!=null) {
                                Console.WriteLine(pl.courseid + " " + pl.cname + " " + pl.deptid + " " + pl.duration); 
                            }
                            else
                            {
                                Console.WriteLine("not found");
                            }
                            break;
                        case 5:
                            List<bal_course> ps=new List<bal_course>();
                            ps = pi.Show();
                            foreach(var item in ps)
                            {
                                Console.WriteLine(item.courseid + " " + item.cname + " " + item.deptid + " " + item.duration);
                            }
                            break;


            }
            break;
                case 2:
                    Console.WriteLine("1.Add 2.Update 3.Delete 4.Find 5.ShowAll");
                    int hj = Convert.ToInt32(Console.ReadLine());
                    switch (hj)
                    {
                        case 1:
                            bal_student pu = new bal_student();
                            Console.WriteLine("Enter the student id");
                            pu.studentid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the student name");
                            pu.studname = Console.ReadLine();
                            Console.WriteLine("Enter the course id");
                            pu.crsid = Convert.ToInt32(Console.ReadLine());
                            bool ko = plo.insertstud(pu);
                            if (ko)
                            {
                                Console.WriteLine("Inserted successfully");
                            }
                            else
                            {
                                Console.WriteLine("Not done");
                            }

                            break;
                        case 2:
                            Console.WriteLine("Enter the student number you want to update");
                            int jo = Convert.ToInt32(Console.ReadLine());
                            bal_student pu1 = new bal_student();
                            Console.WriteLine("Enter the student id");
                            pu1.studentid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the student name");
                            pu1.studname = Console.ReadLine();
                            Console.WriteLine("Enter the course id");
                            pu1.crsid = Convert.ToInt32(Console.ReadLine());
                            bool ko1 = plo.updatestud(jo,pu1);
                            if (ko1)
                            {
                                Console.WriteLine("Updated successfully");
                            }
                            else
                            {
                                Console.WriteLine("Not done");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Enter the student number you want to delete");
                            int pli = Convert.ToInt32(Console.ReadLine());
                            bool kit = plo.deletestud(pli);
                            if (kit)
                            {
                                Console.WriteLine("Deleted successfully");
                            }
                            else
                            {
                                Console.WriteLine("Not done");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter the student number you want to delete");
                            int pli1 = Convert.ToInt32(Console.ReadLine());
                            bal_student pk = new bal_student();
                            pk = plo.findstud(pli1);
                            if (pk != null)
                            {
                                Console.WriteLine(pk.studentid + " " + pk.studname + " " + pk.crsid);
                            }
                            else
                            {
                                Console.WriteLine("Not Done");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter student list");
                            List<bal_student> hi = new List<bal_student>();
                            hi = plo.Show();
                            foreach(var item in hi)
                            {
                                Console.WriteLine(item.studentid + " " + item.studname + " " + item.crsid);
                            }
                            break;

                    }
                    break;
                case 3:
                    Console.WriteLine("1.Add 2.ShowAll");
                    int jk=Convert.ToInt32(Console.ReadLine());
                    if (jk == 1)
                    {
                        bal_exam poq = new bal_exam();
                        Console.WriteLine("Enter exam id");
                        poq.examid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter stud id");
                        poq.sid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter course id");
                        poq.crsid = Convert.ToInt32(Console.ReadLine());
                        if (poq.crsid == 1)
                        {
                            poq.marks = consolidatechemistry();
                        }
                        else if (poq.crsid == 2)
                        {
                            poq.marks = consolidatephysics();
                        }
                        bool s2 = ploo.insert(poq);
                        if (s2)
                        {
                            Console.WriteLine("Inserted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Not done");
                        }
                    }
                    else if (jk == 2)
                    {
                        List<bal_exam> l = new List<bal_exam>();
                        l = ploo.Show();
                        foreach(var item in l)
                        {
                            Console.WriteLine(item.examid + " " + item.sid + " " + item.crsid + " " + item.marks);
                        }

                    }
                    break;
        }
            Console.ReadLine();
        }
        public static int consolidatechemistry()
        {
            int marks = 0;
            Console.WriteLine("What is symbol of gold");
            string mk = Console.ReadLine();
            if (mk == "Au")
            {
                marks += 50;
            }
            Console.WriteLine("What is symbol of Silver");
            string km = Console.ReadLine();
            if (km == "Ag")
            {
                marks += 50;
            }
            return marks;

        }
        public static int consolidatephysics()
        {
            int marks = 0;
            Console.WriteLine("What is SIunit of mass");
            string mk = Console.ReadLine();
            if (mk == "kg")
            {
                marks += 50;
            }
            Console.WriteLine("What is SIunit of Force");
            string km = Console.ReadLine();
            if (km == "N" || km=="newton")
            {
                marks += 50;
            }
            return marks;

        }
    }
}
------------------------------------------------------------


BAL Library



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businessaccess
{
    public class bal_course
    {
        public int courseid
        {
            get;
            set;
        }
        public string cname
        {
            get;
            set;
        }
        public string deptid
        {
            get;
            set;
        }
        public int duration
        {
            get;
            set;
        }
    }
    public class bal_student
    {
        public int studentid
        {
            get;
            set;
        }
        public string studname
        {
            get;
            set;
        }
        public int crsid
        {
            get;
            set;
        }

    }
    public class bal_exam
    {
        public int examid
        {
            get;
            set;
        }
        public int crsid
        {
            get;
            set;
        }
        public int sid
        {
            get;
            set;
        }
        public int marks
        {
            get;
            set;
        }
    }

}
-------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businessaccess;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Dataaccess
{
    public class dal_course
    {
        DataSet ds = null;
        SqlDataAdapter adapt = null;
        SqlConnection cn = null;
        public dal_course()
        {
            ds = new DataSet();
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["iims1"].ConnectionString);
        }
        private DataTable connect()
        {
            adapt = new SqlDataAdapter("Select * from COURSE", cn);
            adapt.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapt.Fill(ds, "course");
            DataTable dt = ds.Tables["course"];
            return dt;
        }
        public bool insertcourse(bal_course p)
        {
            DataTable dt = connect();
            DataRow dh = ds.Tables["course"].NewRow();
            dh["COURSEID"] = p.courseid;
            dh["COURSENAME"] = p.cname;
            dh["DEPTID"] = p.deptid;
            dh["DURATION"] = p.duration;
            ds.Tables["course"].Rows.Add(dh);// disconnected mode- inthe dataset

            SqlCommandBuilder bldr = new SqlCommandBuilder(adapt);
            int i = adapt.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }
        public bool updatecourse(int no, bal_course p)
        {
            DataTable dt = connect();
            DataRow dh = ds.Tables["course"].Rows.Find(no);
            dh["COURSEID"] = p.courseid;
            dh["COURSENAME"] = p.cname;
            dh["DEPTID"] = p.deptid;
            dh["DURATION"] = p.duration;


            SqlCommandBuilder bldr = new SqlCommandBuilder(adapt);
            int i = adapt.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }
        public bool DeleteCourse(int courseid)
        {

            DataTable dt_empdata = connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(adapt);
            int i = adapt.Update(ds.Tables["course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public bal_course FindCourse(int courseid)
        {

            DataTable dt_empdata = connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);
            bal_course p = new bal_course();
            p.courseid = Convert.ToInt32(drow["courseid"]);
            p.cname = drow[1].ToString();
            p.deptid = drow[2].ToString();
            p.duration = Convert.ToInt32(drow[3]);




            return p;
        }
        public List<bal_course> Showall()
        {
            List<bal_course> pll = new List<bal_course>();
            DataTable dt_empdata = connect();
            for (int i = 0; i < ds.Tables["course"].Rows.Count; i++)
            {
                DataRow dh = dt_empdata.Rows[i];
                bal_course pll2 = new bal_course();
                pll2.courseid = Convert.ToInt32(dh[0]);
                pll2.cname = dh[1].ToString();
                pll2.deptid = dh[2].ToString();
                pll2.duration = Convert.ToInt32(dh[3]);
                pll.Add(pll2);


            }
            return pll;
        }
    }
    public class dal_student
    {
        DataSet ds = null;
        SqlDataAdapter da1 = null;
        SqlConnection cn1 = null;
        public dal_student()
        {
            ds = new DataSet();
            cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["iims1"].ConnectionString);

        }
        private DataTable connect1()
        {
            da1 = new SqlDataAdapter("Select * from student", cn1);
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.Fill(ds, "student");
            DataTable dt = ds.Tables["student"];
            return dt;
        }
        public bool insertstudent(bal_student s)
        {
            DataTable dt = connect1();
            DataRow dr = ds.Tables["student"].NewRow();
            dr["stuid"] = s.studentid;
            dr["studname"] = s.studname;
            dr["crsid"] = s.crsid;
            ds.Tables["student"].Rows.Add(dr);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da1);
            int i = da1.Update(ds.Tables["student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public bool updatestudent(int no, bal_student pk)
        {
            DataTable dt = connect1();
            DataRow dr = ds.Tables["student"].Rows.Find(no);
            dr["stuid"] = pk.studentid;
            dr["studname"] = pk.studname;
            dr["crsid"] = pk.crsid;
            SqlCommandBuilder bldr = new SqlCommandBuilder(da1);
            int s = da1.Update(ds.Tables["student"]);
            bool status = false;
            if (s == 1)
            {
                status = true;
            }
            return true;
        }
        public bool Deletestudent(int no)
        {
            DataTable dt = connect1();
            DataRow dr = ds.Tables["student"].Rows.Find(no);
            dr.Delete();
            SqlCommandBuilder bldr = new SqlCommandBuilder(da1);
            int s = da1.Update(ds.Tables["student"]);
            bool status = false;
            if (s == 1)
            {
                status = true;
            }
            return true;

        }
        public bal_student FindStudent(int no)
        {
            DataTable dt = connect1();
            DataRow dr = ds.Tables["student"].Rows.Find(no);
            bal_student po = new bal_student();
            po.studentid = Convert.ToInt32(dr[0]);
            po.studname = dr[1].ToString();
            po.crsid = Convert.ToInt32(dr[2]);
            return po;
        }
        public List<bal_student> Showall()
        {
            DataTable dt = connect1();
            List<bal_student> studlist = new List<bal_student>();
            for (int i = 0; i < ds.Tables["student"].Rows.Count; i++)
            {
                DataRow dl = ds.Tables["student"].Rows[i];
                bal_student stud = new bal_student();
                stud.studentid = Convert.ToInt32(dl[0]);
                stud.studname = dl[1].ToString();
                stud.crsid = Convert.ToInt32(dl[2]);
                studlist.Add(stud);

            }
            return studlist;
        }
    }
    public class dal_exam{
        DataSet ds = null;
        SqlConnection conn = null;
        SqlDataAdapter da2 = null;
        public dal_exam()
        {
            ds = new DataSet();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["iims1"].ConnectionString);

        }
        private DataTable connect2()
        {
            da2 = new SqlDataAdapter("Select * from exam", conn);
            da2.Fill(ds, "exams");
            DataTable dt = ds.Tables["exams"];
            return dt;
        }
        public bool insertexam(bal_exam p)
        {
            DataTable dt = connect2();
            DataRow dr = ds.Tables["exams"].NewRow();
            dr["examid"] = p.examid;
            dr["studid"] = p.sid;
            dr["crsid"] = p.crsid;
            dr["marks"] = p.marks;
            ds.Tables["exams"].Rows.Add(dr);
            SqlCommandBuilder bldr= new SqlCommandBuilder(da2);
            int kl = da2.Update(ds.Tables["exams"]);
            if (kl == 1)
            {
                return true;

            }
            else
            {

                return false;
            }

        }
        public List<bal_exam> Showall()
        {
            DataTable dt = connect2();
            List<bal_exam> list = new List<bal_exam>();
            for (int i = 0; i < ds.Tables["exams"].Rows.Count; i++)
            {
               
                bal_exam kl = new bal_exam();
                DataRow dth = ds.Tables["exams"].Rows[i];
                kl.examid = Convert.ToInt32(dth[0]);
                kl.sid = Convert.ToInt32(dth[2]);
                kl.crsid = Convert.ToInt32(dth[1]);
                kl.marks= Convert.ToInt32(dth[3]);
                list.Add(kl);
            }
            return list;
        }
        }
}
