using Craftsman.Footmark.Core.Domain;
using Craftsman.Footmark.Core.Domain.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.ModuleA.Behavior;

namespace TestProject.Domain.ModuleA.Featrue
{
    public class MyFeature01 : IFeature
    {
        private readonly IAssert _assert;
        private readonly ILogger _logger;
        //private SigninBehavior signinBehavior;

        public MyFeature01(IAssert assert, ILogger logger)
        {
            _assert = assert;
            _logger = logger;
        }

        [Scenario("Scenario 01"), Tag("BVT")]
        public void Scenario01()
        {
            _logger.LogInformation("Execute Scenario01");
            _assert.Equal(1, 1);
        }

        [Scenario("Scenario 02")]
        public void Scenario02()
        {
            _logger.LogInformation("Execute Scenario02");
            // var page = pageRouter.GoTo<LoginPage>();
            // signinBehavior.SignIn();
        }
    }
}
