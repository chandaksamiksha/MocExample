using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MocExample;
using Moq;

namespace MockDemo
{
    [TestClass]
    public class UnitTest1
    {
        Class1 obj;
        Mock<Class2> mockC2;
        Mock<Class3> mockC3;

        public UnitTest1()
        {
            mockC2 = new Mock<Class2>();
            mockC3 = new Mock<Class3>();
                        
            obj = new Class1(mockC2.Object, mockC3.Object);
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            mockC2.Setup(x => x.MethodClass2()).Returns("3");
            mockC3.Setup(x => x.MethodClass3(2)).Returns(2);
            Assert.IsTrue(obj.MethodClass1(2) == 5);
        }
    }
}
