using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInventory.Controllers
{
    public class FrontendController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Webdev()
        {
            return View();
        }

        public ActionResult Mobiledev()
        {
            return View();
        }

        public ActionResult Graphic()
        {
            return View();
        }

        // เรียกแสดงแบบฟอร์มลงทะเบียน
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // เรียกแสดงแบบฟอร์มลงเข้าสุ่ระบบ
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

    }
}
