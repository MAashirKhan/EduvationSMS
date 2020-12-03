using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduvation_SMS
{
    public class user_login
    {
        private string uname, password;

        public string UNAME
        {
            get { return uname; }
            set { uname = value; }
        }
        public string PSWD
        {
            get { return password; }
            set { password = value; }
        }
        public user_login()
        {

        }
    }
}
