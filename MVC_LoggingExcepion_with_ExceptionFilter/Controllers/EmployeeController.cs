using MVC_LoggingExcepion_with_ExceptionFilter.CustomFilter;
using MVC_LoggingExcepion_with_ExceptionFilter.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MVC_LoggingExcepion_with_ExceptionFilter.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationModel ctx = new ApplicationModel();
        // GET: Employee
        public ActionResult Index()
        {
            var Emps = ctx.Employees.ToList();
            return View(Emps);
        }

        public ActionResult Create()
        {
            return View(new EmployeeInfo());
        }

        [ExceptionHandler]
        [HttpPost]
        public ActionResult Create(EmployeeInfo Emp)
        {

            if (Emp.Designation == "Manager" && (Emp.Salary < 40000 || Emp.Salary > 80000))
            {
                throw new Exception("Salary is not Matching with Manager Designatgion");
            }
            else
            if (Emp.Designation == "Operator" && (Emp.Salary < 10000 || Emp.Salary > 20000))
            {
                throw new Exception("Salary is not Matching with Operator Designatgion");
            }
            else {
                ctx.Employees.Add(Emp);
                ctx.SaveChanges();

            }

           
            return View(Emp);
        }
    }
}