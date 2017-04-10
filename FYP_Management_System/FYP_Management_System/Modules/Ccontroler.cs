using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Management_System
{
    [Serializable]
    class Ccontroler
    {
        public Cstudent Ostudent;
        public Cadvisor Oadvisor;
        public Cexternal Oexternal;
        public Cinternal Ointernal;
        public Ccontroler()
        {
            Oadvisor = new Cadvisor();
            Ostudent = new Cstudent();
            Oexternal = new Cexternal();
            Ointernal = new Cinternal();
        }
    }
}
