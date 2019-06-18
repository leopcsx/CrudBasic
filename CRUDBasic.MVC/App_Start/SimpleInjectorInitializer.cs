[assembly: WebActivator.PostApplicationStartMethod(typeof(CRUDBasic.MVC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace CRUDBasic.MVC.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using CRUDBasic.Application.Interface;
    using CRUDBasic.Application.Services;
    using CRUDBasic.Domain.Interfaces.Repository;
    using CRUDBasic.Infra.Data.Repository;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<IColaboradorAppService, ColaboradorAppService>(Lifestyle.Scoped);
            container.Register<IColaboradorRepository, RepositoryColaborador>(Lifestyle.Scoped);
            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}