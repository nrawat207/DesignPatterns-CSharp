using NUnit.Framework;
using StructuralPatterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsTest.Adapter
{
    [TestFixture]
    public class AdapterTest
    {
        private IDataSource source;

        [Test]
        public void ShouldGetData()
        {
            source = new DataSourceAdapter();
            var list = source.GetData();
            Assert.Contains("Test", list);
            Assert.Contains("Data", list);
            Assert.Contains("Service", list);
        }
    }
}
