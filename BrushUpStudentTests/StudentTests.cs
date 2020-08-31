using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpStudent;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpStudent.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student lu = new  Student("ib", "vanløse", 1, Gender.Male);

        [TestMethod()]
        public void StudentTest()
        {
            Assert.AreEqual("ib", lu.Name);
            
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => lu.Name = "x");
        }
    }
}