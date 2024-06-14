using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_12_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("a","1");
            Employee employee2 = new Employee("ab","12");
            Employee employee3 = new Employee("abc","123");

            EmployeeManager empMan  = new EmployeeManager();

            empMan.addEmployeInDict(employee1);
            empMan.addEmployeInDict(employee2);
            empMan.addEmployeInDict(employee3);

            empMan.ShowAllDict();

            empMan.changeEmployeLogin();

            empMan.changeEmployeePass();

            //empMan.removeEmployeeFromDict(employee1.Login)
            //Console.WriteLine("POSLE YDAL\n");

            empMan.ShowAllDict();

        

           
            //empMan.showPassByLogin();

            

            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add(employee1.Login, employee1.Pass);
            //dict.Add(employee2.Login, employee2.Pass);
            //dict.Add(employee3.Login, employee3.Pass);

            //foreach(var Pair in dict)
            //{
            //    KeyValuePair<string, string> = Pair;
            //}





            Console.ReadLine();
        }
    }
}
