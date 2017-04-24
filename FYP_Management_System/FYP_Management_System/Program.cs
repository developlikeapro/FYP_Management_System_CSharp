
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Management_System
{
    class Program
    {

        static public Ccontroler Ocontroler = null;
        static public Cserialization Oserialization = new Cserialization(ref Ocontroler);

        static void Main(string[] args)
        {
            Ocontroler.Lststud.Add(new Cstudent() { username = "HELLO", password = "123" });
            Clogin oligin = new Clogin(Erole.Student, new loginsub("HELLO", "123"));




            Console.ReadKey();
        }
    }
}
