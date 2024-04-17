using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ConsoleTree.MainClass;

namespace Testsss
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void TestMethod1()
            {
                var parentNode = new Node("Parent");
                var childNode = new Node("Child");
                parentNode.AddChild(childNode);
                Assert.AreEqual(1, parentNode.Children.Count);
                Assert.AreEqual(childNode, parentNode.Children[0]);
            }
        
    }
}
