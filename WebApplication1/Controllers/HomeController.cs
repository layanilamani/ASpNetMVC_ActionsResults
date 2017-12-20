using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Index2()
        {
            return View();
        }

        public EmptyResult Index3()
        {
            return new EmptyResult();
        }

        public RedirectResult Index4()
        {
            return Redirect("http://www.yahoo.com");
        }

        public JsonResult Index5()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            return Json(nums, JsonRequestBehavior.AllowGet);
        }

        public JavaScriptResult Index6()
        {
            return JavaScript("alert('salam');");
        }

        public ContentResult Index7()
        {
            return Content("<book>ali</book>", "text/xml", System.Text.Encoding.ASCII);
        }

        public FileContentResult Index8()
        {
            System.IO.FileStream fs = new System.IO.FileStream("d:\\ic_launcher-web.png", System.IO.FileMode.Open);
            var buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            return File(buffer, "images/png");
        }

        public FileStreamResult Index9()
        {
            return File(new System.IO.FileStream("d:\\ic_launcher-web.png", System.IO.FileMode.Open), "images/png");
        }

        public FilePathResult Index10()
        {
            return File(@"D:\Books\ADSE-II\Introduction to Windows Azure.pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation", "sample.pptx");
        }
    }
}