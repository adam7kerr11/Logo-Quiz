using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication2
{
    class LoginNew
    {
        static string Password = "";
        static string Username = "";

        public static string GetUName
        {
            get
            {
                using (StreamReader readUName = new StreamReader("Username.txt"))
                {
                    string logindeets = "";
                    while ((logindeets = readUName.ReadLine()) != null)
                    {
                        Username = logindeets;
                    }
                }
                return Username;
            }
        }
        public static string GetPass
        {
            get
            {
                using (StreamReader readPass = new StreamReader("Password.txt"))
                {
                    string logindeets2 = "";
                    while ((logindeets2 = readPass.ReadLine()) != null)
                    {
                        Password = logindeets2;
                    }
                    return Password;
                }
            }
        }
    }
}
