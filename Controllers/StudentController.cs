using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_lecture.Models;
using dotnet_lecture.Services.Students;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace dotnet_lecture.Controllers;
//Add the controller and the route
[ApiController]
[Authorize]
//We add a custom endpoint name 
[Route("api/[controller]")]

//Add ControllerBase to the end of the function
//Inheretence will allow us to use C#'s built libraries
public class StudentController : ControllerBase
{
    public List<string> students = new List<string>();
    
    //create property to access
    private readonly IStudentService _studentService;



    //C# knows that this is the constructor
    public StudentController(IStudentService studentService)
    {
        
        _studentService = studentService;
     
        
    }

    [HttpGet]
    //[Route("GetStudents")]
    //Get is to get the Data
    public List<Student> Get()
    {
        return _studentService.Get();
    }

    [HttpPost]
    [Route("AddStudent")]
    //Post is to Add to the list or adding new data
    //taking in a string and adding it to the student list
    public List<Student> AddStudent(string studentName)
    {
        
        return _studentService.AddStudent(studentName);
    }

    [HttpDelete]
    [Route("DeleteStudent")]
    //[Route("DeleteStudent")]
    //This isnt used to often
    //Often just marked it as "as deleted"
    public List<Student> RemoveStudent( string StudentToDelete ) 
    {
        //students.Remove(StudentToDelete);
        return _studentService.RemoveStudent(StudentToDelete);
    }

    [HttpPut]
    [Route("UpdateStudent")]
    //PUT is for updating existing data
    public List<Student> UpdateStudent(string oldName, string newName)
    {
        
        return _studentService.UpdateStudent(oldName, newName);
    }
}


