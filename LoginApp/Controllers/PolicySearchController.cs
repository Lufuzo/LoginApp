using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class PolicySearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search([FromBody] PolicySearchViewModel search)
        {
            try
            {
                var a = search.PolicySearch;
                if (search != null)
                {
                    // Example logic based on searchType (Policy Number or ID Number)
                    if (search.SchemeCode == 1) // Policy Number
                    {
                        //var data = _memberService.GetPolicyByNumber(search.searchInput);
                        //return Json(data);
                    }
                    else if (search.PolicySearchType == 2) // ID Number
                    {
                        //var data = _memberService.GetPolicyByIdNumber(search.searchInput);
                        //return Json(data);
                    }
                }

                return Json(null);
            }
            catch (Exception ex)
            {
                // Handle the exception, log, etc.
                return BadRequest(ex.Message);
            }
        }

    }
}