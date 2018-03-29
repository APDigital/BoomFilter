using Microsoft.VisualStudio.TestTools.UnitTesting;
using BloomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter.Tests
{
    [TestClass()]
    public class BloomTests
    {
        [TestMethod()]
        public void AddDataTest()
        {
            Bloom MyBloom = new Bloom();
            string data = "Hello Bloom Filter";
            MyBloom.AddData(data);
            Assert.AreEqual("success", MyBloom.AddData(data));
        }

        [TestMethod()]
        public void LookUpTest()
        {

            Bloom MyBloom = new Bloom();
            string data = "Hello Bloom Filter";
            MyBloom.AddData(data);
            string data2 = "Hello Bloom Filter";
            Assert.AreEqual(true, MyBloom.LookUp(data2));
        }
    }
}