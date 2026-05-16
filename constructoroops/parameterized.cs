using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroops
{
    class studentp
    {
        int Sid;
        string Sname;
        int Sage;
        public studentp(int sid, string sname, int sage)
        {
            Sid = sid;
            Sname = sname;
            {
              if (sage >=18&sage<=60)
                    {
                    Sage = sage;
                    }   
                else
                {
                    Console.WriteLine("age should be between 18 and 60");
                }
            }
        }
        public void studentpdisplay()
        {
            Console.WriteLine("student id is:" + Sid);
            Console.WriteLine("student  name is:" + Sname);
            Console.WriteLine("student fee is:" + Sage);
        }


        internal class parameterized
        {
            static void Main(string[] args)
            {
                studentp obj1 = new studentp(101, "abc", 18);
                obj1.studentpdisplay();
                studentp obj2 = new studentp(102, "bcd", 55);
                obj2.studentpdisplay();
                studentp obj3 = new studentp(103, "cde", 15);
                obj3.studentpdisplay();

            }
        }
    }
}
