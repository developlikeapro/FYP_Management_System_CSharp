using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD01
{
    class Clogin
    {

        public Clogin(Role obj)
        {
            if (obj==Role.Student)
            {

            }
            else if(obj == Role.Advisor)
            {

            }
            else if (obj == Role.Internal)
            {

            }
            else  if(obj == Role.External)
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
