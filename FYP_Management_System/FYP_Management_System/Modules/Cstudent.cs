using System;
using System.Collections.Generic;

namespace FYP_Management_System
{
    [Serializable]
    public class Cstudent : Cperson, Istudent
    {
        public int studentid { get; set; }
        public double cgpa { get; set; }
        public List<Cidea> lstofideas { get; set; }
        public Cproject selectedproject { get; set; }
        public List<string> notifications { get; set; }

        public Cstudent()
        {

        }
        public Cstudent(
            string f_name,
            string l_name,
            string address,
            string contact_num,
            DateTime dob,
            string email,
            Egender gender,
            int cnic,
            string username,
            string pass
            )
        {
            firstname = f_name;
            lastname = l_name;
            this.address = address;
            contactnumber = contact_num;
            DOB = dob;
            Email = email;
            this.gemder = gemder;
            this.cnic = cnic;
            this.username = username;
            this.password = pass;
        }

        public void proposeidea(Cidea idea)
        {
            //added to the list of selected advisor 
        }

        public void submitproject(Cproject myproject)
        {
           //
        }
    }
    public class Cidea
    {
        public string idea { get; set; }
        public bool ispropose { get; set; }
        public bool isaccept { get; set; }
        public Cidea(string idea)
        {
            this.idea = idea;
            isaccept = false;
            ispropose = true;
        }
    }
}