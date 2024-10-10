using _Domain.Model;
using _Repository.IRepo;
using _Repository.Repo;
using _Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Services.Service
{
    public class LoginService : ILoginService
    {

        private readonly ILoginRepo _loginRepo;

       
        public LoginService(ILoginRepo loginRepo)
        {
            this._loginRepo = loginRepo;
        }



        public Login LoginMethod(string username, string password)
        {
            return _loginRepo.Login(username,password);
        }
    }
}
