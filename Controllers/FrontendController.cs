using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using ASPNetCoreInventory.Models;
using Microsoft.AspNetCore.Http;

namespace ASPNetCoreInventory.Controllers
{

    public class FrontendController : Controller
    {

        public void TestConnectDB()
        {
            InventoryDBContext dbContext = new InventoryDBContext();

            if (dbContext.Database.CanConnect())
            {
                Console.WriteLine("Connnect Success");
            }
            else
            {
                Console.WriteLine("Connnect Fail!!!");
            }
        }

        public ActionResult Index()
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
        [Route("front/signup")]
        [HttpGet]
        public ActionResult Signup()
        {
            return View("SignupMember");
        }

        [Route("front/signup")]
        [HttpPost]
        public ActionResult Signup(tb_Member member)
        {
            string message;

            // ตรวจสอบว่า Validate ผ่านหรือยัง
            if (ModelState.IsValid)
            {
                
                // บันทึกลงตารางในฐานข้อมูล
                using (InventoryDBContext db = new InventoryDBContext())
                {
                    db.tb_Members.Add(member);
                    db.SaveChanges();
                    ModelState.Clear(); // Reset และ Clear ข้อมูลในฟอร์ม
                    message = "<div class=\"alert alert-success text-center\">ลงทะเบียนเรียบร้อยแล้ว</div>";
                    // Redirect ไปหน้า Login
                    return RedirectToAction("Login", "Frontend");
                }
            }
            else
            {
                // แสดงข้อความแจ้งเตือน
                message = "<div class=\"alert alert-danger text-center\">ป้อนข้อมูลให้ครบก่อน</div>";
            }
            

            ViewBag.Message = message;
            return View("SignupMember");
        }

        // เรียกแสดงแบบฟอร์มลงทะเบียน
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // Submit แบบฟอร์มลงทะเบียน POST Action
        [HttpPost]
        public ActionResult Register(User user)
        {
            string message;

            // ตรวจสอบว่า Validation ผ่านแล้ว
            if (ModelState.IsValid)
            {

                // บันทึกลงตารางในฐานข้อมูล
                using (InventoryDBContext db = new InventoryDBContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    ModelState.Clear(); // Reset และ Clear ข้อมูลในฟอร์ม
                    message = "<div class=\"alert alert-success text-center\">ลงทะเบียนเรียบร้อยแล้ว</div>";
                    // Redirect ไปหน้า Login
                    return RedirectToAction("Login", "Frontend");
                }

            }
            else
            {
                message = "<div class=\"alert alert-danger text-center\">ป้อนข้อมูลให้ครบก่อน</div>";
            }

            ViewBag.Message = message;
            return View();

        }

        // เรียกแสดงแบบฟอร์มลงเข้าสู่ระบบ
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // Submit แบบฟอร์มเข้าสุ่ระบบ POST Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            string message = "";

            // ตรวจสอบว่า Validation ผ่านแล้ว
            if (user.EmailID != null && user.Password != null)
            {
                using (InventoryDBContext db = new InventoryDBContext())
                {
                    var query = db.Users.Where(u => u.EmailID == user.EmailID).FirstOrDefault();
                    if (query != null)
                    {
                        if (string.Compare(user.Password, query.Password) == 0)
                        {
                            // เก็บข้อมูลลง session ไว้ตรวจใน Controller Backend
                            HttpContext.Session.SetString("Email",query.EmailID);
                            HttpContext.Session.SetString("FirstName", query.FirstName);
                            HttpContext.Session.SetString("LastName", query.LastName);

                            return RedirectToAction("Dashboard", "Backend");
                        }
                        else
                        {
                            message = "<div class=\"alert alert-danger text-center\">ป้อนรหัสผ่านไม่ถูกต้อง</div>";
                        }
                    }
                    else
                    {
                        message = "<div class=\"alert alert-danger text-center\">ไม่พบอีเมล์นี้</div>";
                    }
                }
            }
            else
            {
                message = "<div class=\"alert alert-danger text-center\">ป้อนข้อมูลให้ครบก่อน</div>";
            }

            ViewBag.Message = message;
            return View();

        }

    }
}
