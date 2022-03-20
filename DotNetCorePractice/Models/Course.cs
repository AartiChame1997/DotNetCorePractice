using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCorePractice.Models
{
    public class Course
    {
        public int id { get; set; }
        public string title { get; set; }

        public string code { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
        
    }
}
