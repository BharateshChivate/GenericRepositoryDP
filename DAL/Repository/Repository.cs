using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        EmployeesEntities _context = null;
        private DbSet<T> table = null;

        public Repository()
        {
            _context = new EmployeesEntities();
            table = _context.Set<T>();

        }
        public List<T> GetAllItems()
        {
            List<T> empList = new List<T>();
               empList =  table.ToList();
            return empList;
        }
    }
}
