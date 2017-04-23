using System;

namespace FYP_Management_System
{
    [Serializable]
    public class Cperson
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string contactnumber { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public Egender gemder { get; set; }
        public int cnic { get; set; }



    }
    [Serializable]
    public enum Egender
    {
        Male,
        Female,
        Other
    }
}