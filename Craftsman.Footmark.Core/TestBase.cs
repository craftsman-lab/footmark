using Autofac;
using Craftsman.Footmark.Core.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core
{
    public class TestBase
    {
        protected T ExecuteScenario<T>() where T : IFeature
        {
            var scenario = FootmarkContainer.Container.Resolve<T>();
            return scenario;
        }
    }
}
