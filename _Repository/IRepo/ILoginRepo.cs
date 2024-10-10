using _Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Repository.IRepo
{
    public interface ILoginRepo
    {
        Login Login(string user, string pass);
    }
}
