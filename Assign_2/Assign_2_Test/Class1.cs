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
    }
}
