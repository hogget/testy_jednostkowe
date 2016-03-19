using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kalkulator
{
    [TestFixture]
    public class KalkulatorTest
    {
        [Test]
        public void DodawanieDwochliczb()
        {
            var kalkulator = new Kalkulator();
            Assert.AreEqual(4, kalkulator.Dodaj(2, 2));
            Assert.AreEqual(0, kalkulator.Dodaj(-2, 2));
            Assert.AreEqual(-3, kalkulator.Dodaj(4, -7));
            Assert.AreEqual(2, kalkulator.Dodaj(2, 0));
        }
        [Test]
        public void OdejmowanieDwochliczb()
        {
            var kalkulator = new Kalkulator();
            Assert.AreEqual(4, kalkulator.Odejmij(6, 2));
            Assert.AreEqual(0, kalkulator.Odejmij(2, 2));
            Assert.AreEqual(-3, kalkulator.Odejmij(0, -3));
            Assert.AreEqual(2, kalkulator.Odejmij(2, 0));
        }
        [Test]
        public void ModuloDwochliczb()
        {
            var kalkulator = new Kalkulator();
            Assert.AreEqual(0, kalkulator.Modulo(6, 2));
        }
    }
}
