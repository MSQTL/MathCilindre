using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace CilindreAreaTests
{
    [TestClass]
    public class CilindreTests
    {
        [TestMethod]
        public void CilindreArea_2and3_37_68returned()
        {
            double r = 2, h = 3, expected = 37.68;

            Cilindre g = new Cilindre();
            double actual = g.CilindreArea(r, h);

            Assert.AreEqual(expected, actual);
        }
    }
}
