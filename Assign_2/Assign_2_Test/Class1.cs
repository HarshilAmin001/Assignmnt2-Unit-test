using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2_Main;

namespace Assign_2_Test
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void checkEquiTriangle()
        {
            Assert.AreEqual(TriangleSolver.Scan(10, 10, 10), "Equilateral");

        }
        [Test]
        public void checkIsoTriangle()
        {
            Assert.AreEqual(TriangleSolver.Scan(20, 20, 15), "Isosceles");

        }
        [Test]
        public void checkScaleneTriangle()
        {
            Assert.AreEqual(TriangleSolver.Scan(20, 15, 30), "Scalene");

        }
        [Test]
        public void check_Triangle_3_5_11()
        {
            Assert.AreEqual(TriangleSolver.Scan(3, 5, 11), "Given Values cannot form a triangle");

        }
        [Test]
        public void check_Triangle_0_11_21()
        {
            Assert.AreEqual(TriangleSolver.Scan(0, 11, 21), "Not Recognized");

        }
        [Test]
        public void check_Triangle_0_10_minus20()
        {
            Assert.AreEqual(TriangleSolver.Scan(0, 10, -20), "Not Recognized");

        }
        [Test]
        public void check_Triangle_minus20_minus20_minus20()
        {
            Assert.AreEqual(TriangleSolver.Scan(-20, -20, -20), "Not Recognized");

        }
        [Test]
        public void check_Triangle_0_0_0()
        {
            Assert.AreEqual(TriangleSolver.Scan(0, 0, 0), "Not Recognized");

        }
       
    }
}
