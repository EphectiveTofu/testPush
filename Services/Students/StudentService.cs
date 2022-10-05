using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using dotnet_lecture.Data;
using dotnet_lecture.Models;

namespace dotnet_lecture.Services.Students
{
    //We are creating the instructions for the IStudentService 
    public class StudentService : IStudentService
    {
        private readonly DataContext _db;
        private readonly IHttpContextAccessor _httpContext;

        //We will now inject the DBContext
        public List<string> students = new List<string>();


        public StudentService(DataContext db, IHttpContextAccessor httpContext)
        {
            _db = db;
            _httpContext = httpContext;
        }

        private int GetUserId()
        {
            return int.Parse(_httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        }
        public List<Student> AddStudent(string studentName)
        {
            //students.Add(studentName);

            Student newStudent = new Student();
            User user = _db.Users.FirstOrDefault( u => u.Id == GetUserId());

            newStudent.User = user;
            newStudent.Name = studentName;
            _db.Students.Add(newStudent);
            _db.SaveChanges();

            return _db.Students.Where(s => s.User.Id == user.Id).ToList();
        }

        public List<Student> Get()
        {

            return _db.Students.ToList();
        }

        public List<Student> RemoveStudent(string studentToDelete)
        {
            var student = _db.Students.FirstOrDefault(x => x.Name == studentToDelete);
            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }

            return _db.Students.ToList();

            //students.Remove(StudentToDelete);
            //return students;
        }

        public List<Student> UpdateStudent(string oldName, string newName)
        {
            var student = _db.Students.FirstOrDefault(x => x.Name == oldName);
            if (student != null)
            {
                student.Name = newName;
                _db.SaveChanges();
            }

            return _db.Students.ToList();
            // students[students.IndexOf(oldName)] = newName;
            // return students;
        }

    }

}