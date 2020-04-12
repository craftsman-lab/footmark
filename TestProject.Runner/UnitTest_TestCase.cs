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
        public void Test_Feature_01()
        {
            //ExecuteFeature<MyFeature01>();
            //ExecuteFeature<MyFeature01>("Scenario 01");
            ExecuteFeature<MyFeature01>("TC0001-01");
            // feature.RunAllScenario();

            // feature.RunScenario("Scenario 01");
            // feature.RunScenarioWithSuite("BVT");

            //test code... ...

            // ExecuteScenarios<MyFeature01>();
        }

        [Fact]
        public void Test_Feature_02()
        {
            //var feature = BuildFeature<MyFeature01>();
            // feature.RunScenario("Scenario 01");
        }

        //[Theory]
        //[InlineData()]
        //public void Test_Scenario_01() { }

    }
}
