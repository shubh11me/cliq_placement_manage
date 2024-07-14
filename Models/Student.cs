using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cliqlearn.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

        public IEnumerable<CollegeStudent> college { get; set; }
    }
}
