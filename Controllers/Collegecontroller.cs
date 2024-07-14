using Cliqlearn.DTO;
using Cliqlearn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliqlearn.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class Collegecontroller : Controller
    {
        CliqDBContext _db;
        public Collegecontroller(CliqDBContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] College college)
        {
            try
            {
                _db.colleges.Add(college);
                _db.SaveChanges();
                HttpContext.Response.StatusCode = StatusCodes.Status201Created;
                return new JsonResult(new { college = college });
            }
            catch (Exception ex)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status406NotAcceptable;
                return new JsonResult(new { message = ex.Message });
            }
        }
        [HttpGet]
        [Route("Invite/{id}")]
        public List<CollegeStudent> InviteStudents(int id)
        {
            return _db.CollegeStudent.Select(s=>new CollegeStudent()
            { 
            college=s.college,
            student=s.student
            }).Where(s => s.college.id == id).ToList();
        }
            [HttpPost]
        [Route("Invite")]
        public bool InviteStudents([FromBody] Invitestudents data)
        {
            try
            {
                List<CollegeStudent> cols = new List<CollegeStudent>(); //collegeStudents
                College col = _db.colleges.Find(data.college);
                foreach (int i in data.students)
                {
                    cols.Add(
                        new CollegeStudent
                        {
                            college = col,
                            student = _db.students.Find(i)
                        }
                        );
                }
                _db.CollegeStudent.AddRange(cols);
                _db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
