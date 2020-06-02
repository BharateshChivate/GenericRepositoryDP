using DAL;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepositoryDP.Controllers
{
    public class DepartmentController : Controller
    {
        IRepository<Department> deptRepo = null;
        public DepartmentController(IRepository<Department> repo)
        {
            deptRepo = repo;
        }
        // GET: Department
        public ActionResult Index()
        {
            List<Department> deptList = new List<Department>();
            deptList = deptRepo.GetAllItems();
            return View(deptList);
        }
    }
}