using lab6webapi.Interface;
using lab6webapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab6webapi.Models;

namespace lab6webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudent students = new StudentRepositery();

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            return students.GetAllStudent();
        }
        [Route("/{id}")]
        [HttpGet]
        public ActionResult<Student> GetStudentById(int id) { 
            return students.GetStudent(id);
        }
        [Route("/address/{city}")]
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudentByCity(string city)
        {
            return students.GetCity(city);
        }
    }
}
