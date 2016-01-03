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
        {              //This initializes the data members and calls the 'ReadData' function to read itself in from a file.
            numOfUsers = 1;
            numOfPasswords = 1;
            users = new string[5];
            passwords = new string[5];
            this.ReadData();
        }

        //Purpose: To check the login information against a database of usernames and passwords
        //Parameters: two strings, one for the username, and one for the password
        //Returns: a booleen
        public bool CheckLogin(string inuser, string inpassword)
        {
            for(int i = 0; i < numOfUsers; i++) //as many times as there are data stored in the next element of the array
            {
                if (inuser == users[i]) //check the given username against the current selected username
                {
                    if (inpassword == passwords[i]) //Check the password given against the current selected password
                    {
                        return true; //username and password match up
                    }
                }
            }
            return false; //any other case
        }

        public void ReadData() // this will eventually read in data from a file.
        {                      // for now it just creates a test case and stores it in the array.
            users[0] = "admin";
            passwords[0] = "password";
        }

        public void WriteData() // this will save the data to a .txt file.
        {

        }
    }
}
