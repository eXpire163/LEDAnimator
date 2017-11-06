using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LEDAnimator.helper;
using LEDAnimator;

namespace Testit
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void RoundOff()
        {
            Assert.AreEqual(120, Mathhelper.RoundOff(124));
            Assert.AreEqual(120, Mathhelper.RoundOff(115));
        }

        [TestMethod]
        public void dist() {
            KCPoint p1 = new KCPoint();
            p1.X = 0;
            p1.Y = 0;
            KCPoint p2 = new KCPoint();
            p2.X = 10;
            p2.Y = 10;

            double dist = Math.Sqrt(100 + 100);
            Assert.AreEqual(dist, Mathhelper.dist(p1,p2));
           
        
        }
    }
}
