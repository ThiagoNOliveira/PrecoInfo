using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using PrecoInfo.Core.Domain.Repository;
using PrecoInfo.Domain.ComponenteProduto;
using ProcuraFacil.Core.Domain.Repository;

namespace PrecoInfo.UI
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IRepositorio<Categoria>, Repositorio<Categoria>>(new InjectionConstructor());
        }
    }
}