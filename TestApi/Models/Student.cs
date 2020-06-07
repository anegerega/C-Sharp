using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int Level { get; set; }
        public string Course { get; set; }
        public char Gender { get; set; }
    }

}
