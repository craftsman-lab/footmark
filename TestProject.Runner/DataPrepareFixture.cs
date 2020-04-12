using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Runner
{
    public class DataPrepareFixture : IDisposable
    {
        public int ConstructorCount { get; set; }
        public int DisposeCount { get; set; }
        public DataPrepareFixture()
        {
            ConstructorCount++;
        }
        public void Dispose()
        {
            DisposeCount++;
        }
    }
}
