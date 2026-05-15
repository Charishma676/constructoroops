using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroops
{
    class employee
    {
        int Eid;
        string Ename;
        double Esal;
        public employee()
        {
            Eid = 1;
            Ename = "abc";
            Esal = 10000;
        }
        public  employee(int eid, string ename, double esal)
        {
            Eid = eid;
            Ename = ename;
            Esal = esal;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee id is:" + Eid);
            Console.WriteLine("Employee name is:" + Ename);
            Console.WriteLine("Employee salary is:" + Esal);
        }
        internal class program
        {
            static void Main(string[] args)
            {
                employee obj = new employee();
                obj.DisplayEmployee();
                employee obj2 = new employee(102, "bcd", 15000);
                obj2.DisplayEmployee();
                employee obj3 = new employee(103, "cde", 20000);
                obj3.DisplayEmployee();
            }
        }
    }
}
