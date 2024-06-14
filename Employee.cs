using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_12_06_2024
{
    internal class Employee
    {
        public string Login {  get; set; }
        public string Pass {  get; set; }
        public Employee() { }
        public Employee(string login, string pass)
        {
            Login = login;
            Pass = pass;
        }

        public override string ToString()
        {
            return $"Login: {Login}\nPass: {Pass}";
        }
    }
}
