using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD01
{
    class Clogin
    {
        public Clogin(loginsub obj)
        {
            if (obj.role==0)
            {

            }
            else if(obj.role==1)
            {

            }
            else if (obj.role==2)
            {

            }
            else  
            {

            }
        }
    }
    class loginsub
    {
        public string username { get; set; }
        public int role { get; set; }
        public string pass { get; set; }
        public loginsub(string username,string pass,int role)
        {
            this.role = role;
            this.username = username;
            this.pass = pass;
        }
    }
}
