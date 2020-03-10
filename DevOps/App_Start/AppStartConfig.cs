using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using DevOps.Business.Handler;
using DevOps.Business.Interfaces;
using DevOps.Business.Manager;
using DevOps.Data.DataRepository;
using DevOps.Data.Interfaces;
using DevOps.DataEntities.Models;
using DevOps.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DevOps.App_Start
{
    public class AppStartConfig
    {
        public static IContainer RegisterAutoFac()
        {
            var builder = new ContainerBuilder();

            AddMvcRegistrations(builder);
            AddRegisterations(builder);

            var container = builder.Build();

            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return container;
        }

        private static void AddRegisterations(ContainerBuilder builder)
        {
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            //builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            //builder.RegisterModelBinderProvider();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterModule<AutofacWebTypesModule>();
        }

        private static void AddMvcRegistrations(ContainerBuilder builder)
        {
            RegisterManager.Register(builder);
            RegisterRepository.Register(builder);
        }
        //    public static IContainer Container;

        //    public static void Initialize(HttpConfiguration config)
        //    {
        //        Initialize(config, RegisterServices(new ContainerBuilder()));
        //    }


        //    public static void Initialize(HttpConfiguration config, IContainer container)
        //    {
        //        config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        //    }

        //    private static IContainer RegisterServices(ContainerBuilder builder)
        //    {
        //        //Register your Web API controllers.  
        //        builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

        //        builder.RegisterType<DevOpsEntities>()
        //               .As<DevOpsEntities>()
        //               .InstancePerRequest();

        //        builder.RegisterType<UserManager>()
        //               .As<IUserManager>()
        //               .InstancePerRequest();

        //        builder.RegisterType<UserDataRepository>()
        //               .As<IUserDataRepository>()
        //               .InstancePerRequest();

        //        //Set the dependency resolver to be Autofac.  
        //        Container = builder.Build();

        //        return Container;
        //    }
    }
}