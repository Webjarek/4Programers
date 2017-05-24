using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(executingAssembly)
                .AsSelf()
                .AsImplementedInterfaces();

            using (var scope = builder.Build().BeginLifetimeScope())
            {
                var controler = scope.Resolve<AnyControler>();
                controler.DoIt();
            }
        }
    }
}
