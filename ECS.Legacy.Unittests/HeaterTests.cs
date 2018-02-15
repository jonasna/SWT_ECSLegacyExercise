using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Unittests
{
    [TestFixture]
    class HeaterTests
    {
        [Test]
        public void SelfTest_ReturnsTrue()
        {
            var uut = new Heater();
            Assert.That(uut.RunSelfTest(), Is.EqualTo(true));
        }
    }
}
