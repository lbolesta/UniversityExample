using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UniversityExample.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public string ClassID { get; set; }
        public ClassModel Class { get; set; }

        public int StudentID { get; set; }
        public StudentsModel Student { get; set; }
    }
}
