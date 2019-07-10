using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using FormSubmission.Models;
using System.Linq;

namespace FormSubmission.Controllers

{
    public class HomeController : Controller
    {
        // Requests
        // localhost: 5000/
        // [Route("")]
        [HttpGet("")]

        public IActionResult Index()
        {
            //ViewResult myView = View();
            return View("Index");
        }
        [HttpPost("Result")]
        public IActionResult Result(User u)
        {
            if(ModelState.IsValid)
            {
            return View("Result", u);
            }
            else
            {
                return View("Index");
            }
        }    
    }
}