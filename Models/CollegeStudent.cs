using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cliqlearn.Models
{
    public class CollegeStudent
    {
        [Key]
        public int CollegeStudentId { get; set; }
        public Student student { get; set; }
        public College college { get;set; }

    }
}
