using Craftsman.Footmark.Core.Domain;
using Craftsman.Footmark.Core.Domain.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Entities;
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
        private readonly IRestClient _client;
        //private SigninBehavior signinBehavior;

        public MyFeature01(
            IAssert assert, 
            ILogger logger,
            IRestClient client)
        {
            _assert = assert;
            _logger = logger;
            _client = client;
        }

        [Scenario("TC0001-01","Scenario 01"), Tag("BVT")]
        public void Scenario01()
        {
            var request = new RequestModel()
            {
                BaseUrl = "http://localhost:3000",
                HttpMethod = "get",
                Resource = "users/1"
            };
            var response = _client.Invoke(request);
            _logger.LogInformation("Execute Scenario01");
            _assert.Equal(1, 1);
        }

        [Scenario("TC0001-02", "Scenario 02")]
        public void Scenario02()
        {
            _logger.LogInformation("Execute Scenario02");
            // var page = pageRouter.GoTo<LoginPage>();
            // signinBehavior.SignIn();
        }
    }
}
