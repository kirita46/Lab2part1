using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2part;  

namespace SetTests
{
    [TestClass]
    public class SetTest
    {
        [TestMethod]
        public void TestAddElementToSet()
        {
            var set = new Set<int>(new[] { 1, 2, 3 });
            set += 4;  
            Assert.AreEqual(4, set.Count);  
            Assert.IsTrue(set.ToString().Contains("4"));  
        }

        [TestMethod]
        public void TestUnionOfSets()
        {
            var set1 = new Set<int>(new[] { 1, 2, 3 });
            var set2 = new Set<int>(new[] { 3, 4, 5 });
            var result = set1 + set2;  

            Assert.AreEqual(5, result.Count);  
            Assert.IsTrue(result.ToString().Contains("1"));
            Assert.IsTrue(result.ToString().Contains("2"));
            Assert.IsTrue(result.ToString().Contains("3"));
            Assert.IsTrue(result.ToString().Contains("4"));
            Assert.IsTrue(result.ToString().Contains("5"));
        }

        [TestMethod]
        public void TestIntersectionOfSets()
        {
            var set1 = new Set<int>(new[] { 1, 2, 3 });
            var set2 = new Set<int>(new[] { 3, 4, 5 });
            var result = set1 * set2;  

            Assert.AreEqual(1, result.Count);  
            Assert.IsTrue(result.ToString().Contains("3"));  
        }

        [TestMethod]
        public void TestSetCountConversion()
        {
            var set = new Set<int>(new[] { 1, 2, 3 });
            int count = (int)set;  
            Assert.AreEqual(3, count);  
        }
        

        [TestMethod]
        public void TestAddCommasExtension()
        {
            string input = "Hello world this is test";
            string result = input.AddCommas(); 
            Assert.AreEqual("Hello, world, this, is, test", result); 
        }

        [TestMethod]
        public void TestRemoveDuplicatesExtension()
        {
            var set = new Set<int>(new[] { 1, 1, 2, 3, 3 });
            var result = set.RemoveDuplicates();  
            Assert.AreEqual(3, result.Count); 
            Assert.IsTrue(result.ToString().Contains("1"));
            Assert.IsTrue(result.ToString().Contains("2"));
            Assert.IsTrue(result.ToString().Contains("3"));
        }
    }
}