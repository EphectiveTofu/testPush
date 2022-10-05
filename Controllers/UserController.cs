using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_lecture.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_lecture.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService){
            _userService = userService;
        }
        
            
        
        [HttpPost]
        [Route("Register")]
        public int Register(string username, string password)
        {
            return _userService.Register(username, password);
        }
        
        [HttpPost]
        [Route("Login")]
        public string Login(string username, string password)
        {
            return _userService.Login(username, password);
        }

    }
}