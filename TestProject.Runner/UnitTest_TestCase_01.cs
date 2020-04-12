using Craftsman.Footmark.Core;
using System;
using TestProject.Domain.ModuleA.Featrue;
using Xunit;
using Xunit.Abstractions;

namespace TestProject.Runner
{
    [Collection("MyDatabaseCollection")]
    public class UnitTest_TestCase_01 : IDisposable, IClassFixture<DataPrepareFixture>
    {
        private ITestOutputHelper _output;
        public UnitTest_TestCase_01(
            ITestOutputHelper output,
            DataPrepareFixture dataPrepareFixture
        )
        {
            _output = output;
            _output.WriteLine("单个用例前执行~");
            _output.WriteLine($"{dataPrepareFixture.ConstructorCount} - {dataPrepareFixture.DisposeCount}");
        }

        public void Dispose()
        {
            _output.WriteLine("单个用例后执行~");
        }

        [Fact]
        public void Test_Scenario_01()
        {
            _output.WriteLine("Test_Scenario_01 执行~");
        }
        [Fact]
        public void Test_Scenario_02()
        {
            _output.WriteLine("Test_Scenario_02 执行~");
        }
    }
}
