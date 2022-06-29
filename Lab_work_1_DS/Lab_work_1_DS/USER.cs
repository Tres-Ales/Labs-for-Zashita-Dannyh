using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_1_DS
{
    public class USER
    {
        public string username;
        public string password;
        //public int password_length; //индекс пользователя
        public bool first_time;
        public bool par_blocked;
        public bool par_restricted;

        public USER(string un, string pw, bool ft, bool pb, bool pr)
        {
            this.username = un;
            this.password = pw;
            this.first_time = ft;
            this.par_blocked = pb;
            this.par_restricted = pr;
        }
    }
}
