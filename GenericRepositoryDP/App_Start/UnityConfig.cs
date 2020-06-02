using DAL;
using DAL.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace GenericRepositoryDP
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IRepository<Employee>, Repository<Employee>>();
            container.RegisterType<IRepository<Department>, Repository<Department>>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}