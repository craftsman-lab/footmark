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
        private IAssert _assert;
        //private SigninBehavior signinBehavior;

        public MyFeature01(IAssert assert01, IAssert assert02)
        {
            _assert = assert01;
        }

        public void Scenario01()
        {
            _assert.Equal(1, 2);
        }

        //[Scenario]
        public void Scenario02()
        {
            // var page = pageRouter.GoTo<LoginPage>();
            // signinBehavior.SignIn();
        }
    }
}
