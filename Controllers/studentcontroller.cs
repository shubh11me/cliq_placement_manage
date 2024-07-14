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
    public class studentcontroller : Controller
    {
        CliqDBContext _db;
        public studentcontroller(CliqDBContext db)
        {
            _db = db;
        }
        // GET: studentcontroller
        [HttpGet]
        [Route("getStudents")]
        public IActionResult Index()
        {
            return new JsonResult(_db.students.Select(st => new {
                naav = st.name,
                aadnaav = st.lastName,
                vidhyalay = st.college.FirstOrDefault().college.college_name
            }));
        }


        // GET: studentcontroller/Details/5
        [HttpGet]
        [Route("getStudents/{id}")]
        public ActionResult Details(int id)
        {
            var student = _db.students.Where(s => s.id == id).Select(st => new {
                naav = st.name,
                aadnaav = st.lastName,
                vidhyalay = st.college.FirstOrDefault().college.college_name
            }).FirstOrDefault();
            if (student != null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return new JsonResult(student);
            }
            else
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                return new JsonResult(new {message="student not found"});
            }
        }



        // POST: studentcontroller/Register
        [HttpPost]
        [Route("Register")]
        public ActionResult Register(Student student)
        {
            try
            {
                _db.students.Add(student);
                _db.SaveChanges();
                HttpContext.Response.StatusCode = StatusCodes.Status201Created;
                return new JsonResult(new {student=student });
            }
            catch(Exception ex)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status406NotAcceptable;
                return new JsonResult(new { message = ex.Message });
            }
        }


      
    }
}
