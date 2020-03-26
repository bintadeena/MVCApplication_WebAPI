using RouxAcademyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RouxAcademyWebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:2392/", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id=1,
                Name="Binta Deena Chacko",
                DateofBirth= new DateTime(1988,11,03)
            },
            new Student()
            {
                Id=2,
                Name="Berlee Chacko",
                DateofBirth= new DateTime(1984,01,08)
            },
            new Student()
            {
                Id=3,
                Name="Blessy Chacko",
                DateofBirth= new DateTime(1982,05,11)
            }
        };
        public IEnumerable<Student> GetStudents()
        {
            return students;
        }
    }
}
