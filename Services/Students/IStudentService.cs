using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_lecture.Models;

namespace dotnet_lecture.Services.Students
{
    //This dependecy injection
    public interface IStudentService
    {
        List<Student> Get();
        List<Student> AddStudent(string studentName);
        List<Student> RemoveStudent(string StudentToDelete); 
        List<Student> UpdateStudent(string oldName, string newName);
    }
}