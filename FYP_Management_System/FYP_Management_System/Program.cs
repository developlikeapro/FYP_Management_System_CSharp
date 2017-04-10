using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Management_System
{
    class Program
    {
        static Cserialization Oserialization = new Cserialization();
        static Ccontroler Ocontroler = null;
        public Program()
        {
            Ocontroler = Oserialization.Mdeserialize();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
        }
    }
}
