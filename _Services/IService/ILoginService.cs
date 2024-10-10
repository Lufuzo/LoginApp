using _Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Services.IService
{
    public interface ILoginService
    {
         Login LoginMethod(string username, string password);
    }
}
