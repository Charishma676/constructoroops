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
        public Employee()
        {
            Eid = 0;
            Ename = "abc";
            Esal = 10000;
        }
        public void Employee(int Eid, string Ename, double Esal)
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
        internal class parameteremployee
        {
            static void Main(string[] args)
            {
                Employee obj = new Employee();
                obj.DisplayEmployee();
                Employee obj2 = new Employee(102, "bcd", 15000);
                obj2.DisplayEmployee();
                Employee obj3 = new Employee(103, "cde", 20000);
                obj3.DisplayEmployee();
            }
        }
    }
}
