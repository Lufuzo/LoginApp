using _Domain.Data;
using _Domain.Model;
using _Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace _Repository.Repo
{
   public class LoginRepo : ILoginRepo
    {

        private readonly ApplicationDBContext _applicationDBContext;

       
        public LoginRepo(ApplicationDBContext applicationDBContext)
        {
            this._applicationDBContext = applicationDBContext;
        }

        public Login Login(string userN, string pass)
        {

            var user = _applicationDBContext.Login.FirstOrDefault(x => x.Username == userN && x.Password == pass);

            return user;
        }
    }
}
