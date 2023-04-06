using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwareWebAutheticationApi.Model
{
    public class User
    {
        private string uuid;
        private string username;
        private string password;
        private UserType userType;
        private UserConfig userConfig;
        public User(string uuid, string username, string password, UserType userType, UserConfig userConfig)
        {
            this.uuid = uuid;
            this.username = username;
            this.password = password;
            this.userType = userType;
            this.userConfig = userConfig;
        }


    }
}
