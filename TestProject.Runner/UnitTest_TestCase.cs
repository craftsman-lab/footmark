using Craftsman.Footmark.Core;
using System;
using TestProject.Domain.ModuleA.Featrue;
using Xunit;
using Xunit.Abstractions;

namespace TestProject.Runner
{
    public class UnitTest_TestCase : FootmarkTestBase
    {
        public UnitTest_TestCase(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void Test_Scenario_01()
        {
            ExecuteScenario<MyFeature01>();
            //test code... ...
        }
    }
}
