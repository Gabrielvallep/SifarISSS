using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SifarISSS.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class UserController : Controller
    {
        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult EditUser()
        {
            return View();
        }

        public IActionResult ListUsers()
        {
            return View();
        }
    }
}
