using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityExample.Models
{
    public class ClassModel
    {
        [Key]
        public string ClassID { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
