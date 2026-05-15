using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroops
{
    class studentp
    {
        int sid;
        string sname;
        int sfee;
        public studentp(int sid, string sname, int sfee)
        {
            sid = sid;
            sname = sname;
            [p]
            sfee = sfee;
        }
        public void studentpdisplay()
        {
            Console.WriteLine("student id is:" + sid);
            Console.WriteLine("student  name is:" + sname);
            Console.WriteLine("student fee is:" + sfee);
        }


        internal class parameterized
        {
            static void Main(string[] args)
            {
                studentp obj1 = new studentp(101, "abc", 10000);
                obj1.studentpdisplay();
                studentp obj2 = new studentp(102, "bcd", 15000);
                obj2.studentpdisplay();
                studentp obj3 = new studentp(103, "cde", 20000);
                obj3.studentpdisplay();

            }
        }
    }
}
