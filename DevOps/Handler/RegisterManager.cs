using Autofac;
using DevOps.Business.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOps.Handler
{
    public class RegisterManager
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType(typeof(UserManager)).AsImplementedInterfaces();
            containerBuilder.RegisterType(typeof(MainMenuManager)).AsImplementedInterfaces();
            containerBuilder.RegisterType(typeof(SubMenuManager)).AsImplementedInterfaces();
        }
    }
}