using Craftsman.Footmark.Core;
using System;
using TestProject.Domain.ModuleA.Featrue;
using Xunit;

namespace TestProject.Runner
{
    public class UnitTest_TestCase : TestBase
    {

        [Fact]
        public void Test_Scenario_01()
        {
            var feature01 = ExecuteScenario<MyFeature01>();
            feature01.Scenario01();

            //test code... ...
        }
    }
}
