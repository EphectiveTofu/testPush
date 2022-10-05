using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_lecture.Data
{
    public interface IAuthRepository
    {
        int Register (string username, string password);

        string Login (string username, string password);
    }
}