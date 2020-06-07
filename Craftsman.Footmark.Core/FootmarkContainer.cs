using Autofac;
using Craftsman.Footmark.Core.Domain.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Implement;
using System;
using System.Reflection;

namespace Craftsman.Footmark.Core
{
    public sealed class FootmarkContainer
    {
        public static IContainer Container { get; private set; }
        static FootmarkContainer()
        {
            var builder = new ContainerBuilder();

            // 注册框架基础组件
            builder.RegisterType<MockDbHelper>().As<IDbHelper>();
            builder.RegisterType<XUnitNetAssert>().As<IAssert>();

            builder.RegisterType<SimpleRestClient>().As<IRestClient>();
            //builder.RegisterType<NUnitAssert>().As<IAssert>();
            //builder.RegisterInstance().As<ILogger>();
            //XUnitLogger : ILogger

            var assemblyCore = Assembly.Load("Craftsman.Footmark.Core");
            var assemblyDomain = Assembly.Load("TestProject.Domain");
            var assemblyComponent = Assembly.Load("TestProject.BusinessComponent");

            builder.RegisterAssemblyTypes(assemblyCore, assemblyDomain, assemblyComponent)
                .Where(type => typeof(IFeature).IsAssignableFrom(type) && !type.IsAbstract)
                .AsSelf();

            Container = builder.Build();
        }
    }
}
