using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_engine
{
    class Login
    {
        string[] users;
        string[] passwords;
        int numOfUsers;
        int numOfPasswords;
        public Login() //Constructor
        {
            users = new string[5];
            passwords = new string[5];
            this.ReadData();
        }

        public bool CheckLogin(string inuser, string inpassword)
        {
            for(int i = 0; i < numOfUsers; i++)
            {
                if (inuser == users[i])
                {
                    if (inpassword == passwords[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ReadData()
        {
            users[0] = "admin";
            passwords[0] = "password";
            numOfUsers = 1;
            numOfPasswords = 1;
        }

        public void WriteData()
        {

        }
    }
}
