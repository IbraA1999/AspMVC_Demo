using AspMVC_Demo.BLL.Interfaces;
using AspMVC_Demo.Domain.Entities;
using AspMVC_Demo.Web.Mapper;
using AspMVC_Demo.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AspMVC_Demo.Web.Controllers
{
    public class AuthController : Controller
    {

        public readonly IAuthService _IAuthService;

        public AuthController(IAuthService iAuthService)
        {
            _IAuthService = iAuthService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUser registerUser)
        {
            User? user = _IAuthService.Register(registerUser.ToUser());

            if (user is null)
            {
                return RedirectToAction("Error");
            }
            return RedirectToAction("index", "Home"); 
        }
    }
}
