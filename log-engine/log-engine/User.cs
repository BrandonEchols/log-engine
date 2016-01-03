using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_engine
{
    class User
    {
        string username;
        string password;
        string personalMessage;

        public User(string inusername, string inpassword)
        {
            username = inusername;
            password = inpassword;
            personalMessage = "";
        }

        public User()
        {
            username = "";
            password = "";
            personalMessage = "";
        }

        public void ReadData(StreamReader inStream) //This will eventually read in the information from a .txt file
        {

        }

        public void WriteData()
        {

        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetPersonalMessage()
        {
            return personalMessage;
        }

        public void SetUsername(string inusername)
        {
            username = inusername;
        }

        public void SetPassword(string inpassword)
        {
            password = inpassword;
        }

        public void SetPersonalMessage(string inmessage)
        {
            personalMessage = inmessage;
        }
    }
}
