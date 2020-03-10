using Autofac;
using DevOps.Data.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Business.Handler
{
    public class RegisterRepository
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType(typeof(UserDataRepository)).AsImplementedInterfaces();
            containerBuilder.RegisterType(typeof(MainMenuDataRepository)).AsImplementedInterfaces();
            containerBuilder.RegisterType(typeof(SubMenuDataRepository)).AsImplementedInterfaces();
        }
    }
}
