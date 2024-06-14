using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_12_06_2024
{
    internal class EmployeeManager
    {
        public Dictionary<string,string> Dictionary1 { get; set; }
        public EmployeeManager()
        {
            Dictionary1 = new Dictionary<string, string>();
        }
        public void addEmployeInDict(Employee empl)
        {
            
            Dictionary1.Add(empl.Login, empl.Pass);
        }

        public void removeEmployeeFromDict(string login)
        {
            Dictionary1.Remove(login);
        }

       public void changeEmployeLogin()
       {
            string newLogin,currentLogin;
            Console.Write("Enter new login: ");
            newLogin = Console.ReadLine();
            Console.WriteLine("Enter current login: ");
            currentLogin = Console.ReadLine();

            try
            {
                if (newLogin != null && Dictionary1.ContainsKey(currentLogin))
                {
                    
                    string valueForSave = Dictionary1[currentLogin];
                    Dictionary1.Remove(currentLogin);
                    Dictionary1.Add(newLogin, valueForSave);

                }
                else
                {
                    throw new Exception("Incorrect zapros\n");
                }

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
       }

 
        

        public void changeEmployeePass()
        {
            string newPass,currentLogin;
            Console.Write("Enter current login: ");
            currentLogin= Console.ReadLine();
            Console.WriteLine("Enter new pass: ");
            newPass = Console.ReadLine();

            if(newPass!= null && Dictionary1.ContainsKey(currentLogin))
            {
                Dictionary1.Remove(currentLogin);
                Dictionary1.Add(currentLogin, newPass);
            }
        }

        

        public void showPassByLogin()
        {
            string searchLogin;
            Console.Write("Enter searchde login: ");
            searchLogin = Console.ReadLine();  
            
            foreach(var empl in Dictionary1)
            {
                KeyValuePair<string, string> keyValue = empl;
                if (empl.Key == searchLogin)
                {
                    Console.WriteLine($"Value: {empl.Value}");
                } 
            }
        }

        /////*public*/ void ShowAllPair()
        ////{
        ////    foreach(var pair in Dictionary1)
        ////    {
        ////        KeyValuePair<string,string> PairP = pair;
        ////        Console.WriteLine($"Login: {PairP.Value}\nPass{PairP.Key}");
        ////    }
        ////}
        ///


        public void ShowAllDict()
        {
            foreach(var el in Dictionary1)
            {
                
                this.ShowPair(el);
            }
        }
        private void ShowPair(KeyValuePair<string, string> pair)
        {
            Console.WriteLine($"Key: {pair.Key}\nValue: {pair.Value}");

        }

        

    }
}
