using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD01
{
    class Clogin
    {

        public Clogin(Role role,loginsub user)
        {
            if (role==Role.Student)
            {

            }
            else if(role == Role.Advisor)
            {

            }
            else if (role == Role.Internal)
            {

            }
            else  if(role == Role.External)
            {

            }
            else
            {

            }
        }
    }
   public enum Role { Student, Advisor, Internal, External };

    class loginsub
    {
        public string username { get; set; }
        public string pass { get; set; }
        public loginsub(string username,string pass)
        {
            this.username = username;
            this.pass = pass;
        }
    }
}
