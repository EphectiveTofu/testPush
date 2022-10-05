using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_lecture.Data;

namespace dotnet_lecture.Services.Users
{
    

    public class UserService : IUserService
    {
        private readonly IAuthRepository _authRepository;
        public UserService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public int Register(string username, string password)
        {
            return _authRepository.Register(username, password);
        }

         public string Login(string username, string password)
        {
            return _authRepository.Login(username, password);
        }
    }
}