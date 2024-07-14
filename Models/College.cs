using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cliqlearn.Models
{
    public class College
    {
        public int id { get; set; }
        public string college_name { get; set; }
        public string college_address { get; set; }
        [Required]
        public string college_email { get; set; }
        [Required]
        public string college_password { get; set; }
    }
}
