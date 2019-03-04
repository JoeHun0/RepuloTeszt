using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    [TestClass()]
    public class JaratKezeloTests
    {
        [TestMethod()]
        public void UjJaratTest()
        {
            JaratKezelo j = new JaratKezelo();
            j.UjJarat("12345", "Budapest", "Berlin", new DateTime(2008, 3, 9, 16, 5, 7, 123));
            j.Keses("12345", 5);
            Assert.AreEqual(j.lista[0].Keses,5);
        }

        [TestMethod()]
        public void KesesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MikorIndulTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void JaratokRepuloterrolTest()
        {
            Assert.Fail();
        }
    }
}