using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Skyline.DataMiner.Automation;
using Skyline.DataMiner.Net.Messages;
using System.Collections.Generic;
using Skyline.DataMiner.Net;
using EmpowerHelloWorldTest2_1;

namespace HelloWorldUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCodeA()
        {
            EmpowerHelloWorldTest2_1.Script script = new EmpowerHelloWorldTest2_1.Script();
            // script.Run(engine);
            int result = script.OperationA(5);
            Assert.AreEqual(50, result);
            //script.OperationB(5);

        }
    }


}
