using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_lecture.Services.Users
{
    public interface IUserService
    {
         int Register(string username, string password);
         string Login(string username, string password);
    }
}