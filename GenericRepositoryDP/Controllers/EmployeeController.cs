using DAL;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepositoryDP.Controllers
{
    public class EmployeeController : Controller
    {
        IRepository<Employee> empRepo = null;
        public EmployeeController(IRepository<Employee> repo)
        {
            empRepo = repo;
        }
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> empList = new List<Employee>();
            empList = empRepo.GetAllItems();
            
            return View(empRepo.GetAllItems());
        }
    }
}