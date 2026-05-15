using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroops
{
    class student
    {
        int sid;
        string sname;
        int sfee;
        public void studentDisplay()
        {
            Console.WriteLine("student id is" + sid);
            Console.WriteLine("student name is" + sname);
            Console.WriteLine("student fee is" + sfee);
        }
    }
    internal class systemdefault
    {
        static void Main(string[] args)
        {
            student objstu = new student();
            objstu.studentDisplay();
            student objstu2 = new student();
            objstu2.studentDisplay();
        }
    }
}
