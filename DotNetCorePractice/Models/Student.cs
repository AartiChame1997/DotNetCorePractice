using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCorePractice.Models
{
    public class Student
    {
        public int id { get; set; }

        public string name { get; set; }

        public DateTime code { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}
