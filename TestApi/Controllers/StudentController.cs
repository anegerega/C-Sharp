using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.IO;
using System.Text;
using Newtonsoft.Json;
using TestApi.Models;
using System.Net.Mail;

namespace TestApi.Controllers
{
    public class StudentController : ApiController
    {

        // GET: api/Student
        List<Student> student = new List<Student>();

        public object JsonSerializer { get; private set; }
     
        public List<Student> Get()
        {
            return student;
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return student.Where(s => s.StudentID == id).FirstOrDefault();
        }

       // [Route("api/Student/pd")]
        // POST: api/Student
        public ResponseHeader Post(Student details)
        {
            string studentfile = @"C:\Users\Angela Egerega\Desktop\C-Sharp\Student_Info\studentfile.txt";
            List<string> newdetails = File.ReadAllLines(studentfile).ToList();
            var jsonstring = JsonConvert.SerializeObject(details);
            newdetails.Add(jsonstring);
            File.WriteAllLines(studentfile, newdetails);

            return new ResponseHeader
            {
                ResponseCode = "00",
                ResponseMessage = "Welldone!"
            };
        }

        //send mail
       
        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }

    }
}
