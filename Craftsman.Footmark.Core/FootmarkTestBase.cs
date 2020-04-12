using Autofac;
using Craftsman.Footmark.Core.Domain;
using Craftsman.Footmark.Core.Domain.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        protected void ExecuteFeature<T>() where T : IFeature
        {
            ExecuteFeature<T>(string.Empty);
        }
        protected void ExecuteFeature<T>(string scenarioKey) where T : IFeature
        {
            Action<ContainerBuilder> action = builder =>
            {
                var logger = new XUnitLogger(_output);
                builder.RegisterInstance(logger).As<ILogger>().SingleInstance();
            };

            using (var scope = FootmarkContainer.Container.BeginLifetimeScope("feature", action))
            {
                IFeature feature = scope.Resolve<T>();

                // 执行对应的测试场景
                var type = feature.GetType();
                var methods = type.GetMethods().Where(x => HasScenarioAttribute(x, scenarioKey));

                foreach (var method in methods)
                {
                    method.Invoke(feature, null);
                }
            }
        }

        private bool HasScenarioAttribute(MethodInfo methodInfo, string scenarioKey)
        {
            var flag = false;
            var attribute = methodInfo.GetCustomAttributes(typeof(ScenarioAttribute), false).FirstOrDefault() as ScenarioAttribute;

            if (string.IsNullOrEmpty(scenarioKey))
            {
                flag = attribute != null;
            }
            else
            {
                flag = attribute != null && attribute.Key == scenarioKey;
            }

            return flag;
        }
    }
}
