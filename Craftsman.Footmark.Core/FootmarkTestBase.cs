using Autofac;
using Craftsman.Footmark.Core.Domain.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Implement;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace Craftsman.Footmark.Core
{
    public class FootmarkTestBase
    {
        protected ITestOutputHelper _output;

        public FootmarkTestBase(ITestOutputHelper output)
        {
            _output = output;
        }
        protected void ExecuteScenario<T>() where T : IFeature
        {
            //IFeature feature = FootmarkContainer.Container.Resolve<T>();
            //feature.Execute();

            Action<ContainerBuilder> action = builder =>
            {
                var logger = new XUnitLogger(_output);
                builder.RegisterInstance(logger).As<ILogger>().SingleInstance();
            };

            using (var scope = FootmarkContainer.Container.BeginLifetimeScope("feature", action))
            {
                IFeature feature = scope.Resolve<T>();
                feature.Execute();
            }
        }
    }
}
