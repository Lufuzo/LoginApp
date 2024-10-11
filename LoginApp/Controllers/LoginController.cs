using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Domain.Model;
using _Services.IService;
using _Services.Service;
using LoginApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class LoginController : Controller
    {


        private readonly ILoginService _loginService;

        //public LoginController()
        //{

        //}

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;

        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public IActionResult LoginCre(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Call the LoginMethod from the service
                var login = _loginService.LoginMethod(model.Username, model.Password);
                //
                // Check if login is successful and redirect accordingly
                if (login != null)
                {
                    // For example, redirect to a dashboard or home page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // If login fails, add a model error and return the view
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }

            // If ModelState is invalid or login fails, return the same view with errors
            return View(model);
        }

    }
}