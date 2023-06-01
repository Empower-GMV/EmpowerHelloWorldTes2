using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectHelloWorld2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var script = new EmpowerHelloWorldTest2_1.Script();
            var result = script.OperationA(10);
            Assert.AreEqual(100, result);
            result = script.OperationB(10);
            Assert.AreEqual(1000, result);
            script.Run(null);
            

        }
    }
}
