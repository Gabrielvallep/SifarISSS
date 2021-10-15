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

        public IActionResult ViewCreateUser()
        {
            return View();
        }

        public IActionResult ViewEditUser()
        {
            return View();
        }

        public IActionResult ViewListUsers()
        {
            return View();
        }
    }
}
