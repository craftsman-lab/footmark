using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject.Runner
{
    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture() 
        { 

        }

        public void Dispose()
        {
        }
    }

    [CollectionDefinition("MyDatabaseCollection")]
    public class DatabaseCollection : ICollectionFixture<DatabaseFixture>
    { }
}
