using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD01
{
    class Clogin
    {

        public Clogin(Erole role,loginsub user)
        {
            if (role==Erole.Student)
            {

            }
            else if(role == Erole.Advisor)
            {

            }
            else if (role == Erole.Internal)
            {

            }
            else  if(role == Erole.External)
            {

            }
            else
            {

            }
        }
    }
   public enum Erole { Student, Advisor, Internal, External };

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
