using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityExample.Models
{
    public class StudentsModel
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
