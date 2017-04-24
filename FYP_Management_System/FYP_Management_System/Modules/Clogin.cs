using FYP_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Management_System
{

    class Clogin
    {

        public Clogin(Erole role, loginsub user)
        {
            if (role == Erole.Student)
            {
                List<Cstudent> stlist = Program.Ocontroler.Lststud;

                for (int i = 0; i < stlist.Count; i++)
                {
                    if (stlist[i].username==user.username
                        &&
                        stlist[i].password == user.pass
                        )
                    {
                        Console.WriteLine("Welcome "+ stlist[i].firstname );
                        //set Environment
                    }
                }
            }
            else if (role == Erole.Advisor)
            {
                List<Cadvisor> advisorlst = Program.Ocontroler.Lstadvisor;

                for (int i = 0; i < advisorlst.Count; i++)
                {
                    if (advisorlst[i].username == user.username
                        &&
                        advisorlst[i].password == user.pass
                        )
                    {
                        Console.WriteLine("Welcome " + advisorlst[i].firstname);
                        //set Environment

                    }
                }
            }
            else if (role == Erole.Internal)
            {
                List<Cinternal> internallst = Program.Ocontroler.Lstinternal;

                for (int i = 0; i < internallst.Count; i++)
                {
                    if (internallst[i].username == user.username
                        &&
                        internallst[i].password == user.pass
                        )
                    {
                        Console.WriteLine("Welcome " + internallst[i].firstname);
                        //set Environment

                    }
                }
            }
            else if (role == Erole.External)
            {
                List<Cexternal> externallst = Program.Ocontroler.Lstexternal;

                for (int i = 0; i < externallst.Count; i++)
                {
                    if (externallst[i].username == user.username
                        &&
                        externallst[i].password == user.pass
                        )
                    {
                        Console.WriteLine("Welcome " + externallst[i].firstname);
                        //set Environment

                    }
                }
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
        public loginsub(string username, string pass)
        {
            this.username = username;
            this.pass = pass;
        }
    }
}
