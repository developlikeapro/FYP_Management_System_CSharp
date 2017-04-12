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
        List<Cstudent> Lststud;
        List<Cadvisor> Lstadvisor;
        List<Cinternal> Lstinternal;
        List<Cexternal> Lstexternal;

        public Ccontroler()
        {
            Lststud = new List<Cstudent>();
            Lstadvisor = new List<Cadvisor>();
            Lstinternal = new List<Cinternal>();
            Lstexternal = new List<Cexternal>();
        }
    }
}
