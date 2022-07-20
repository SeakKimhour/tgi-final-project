using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postgresqlTest.DataModels
{
    internal class UserLoginModel
    {
        public UserLoginModel(string user_id, string user_name, string user_password)
        {
            this.user_id = user_id;
            this.user_name = user_name;
            this.user_password = user_password;
        }

        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
    }
}
