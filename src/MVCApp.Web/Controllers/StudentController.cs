using MVCApp.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Web.Controllers
{
    public class StudentController : Controller
    {
      private readonly IStudentService _studentService;

      public StudentController()
      {
        _studentService = new StudentService();
      }
 
        public ActionResult Index()
        {
          //_studentService.
            return View();
        }
    }
}