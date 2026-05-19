using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iskola13B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola13B.Tests
{
    [TestClass()]
    public class TanuloTests
    {
        

        
        [TestMethod()]
        [DataRow("2006;c;Bodnar Szilvia","6cbodszi")]
        [DataRow("2005;b;Kovacs Orsolya","5bkovors")]
        public void AzonositoJoTest(string alapadat, string jelszo)
        {
            Tanulo tanulo = new Tanulo(alapadat);

            string aktualis = tanulo.Azonosito();

            Assert.AreEqual(jelszo, aktualis);
        }

        [TestMethod()]
        [DataRow("2006;c;Bodnar Szilvia", "6cBodSzi")]
        [DataRow("2005;b;Kovacs Orsolya", "50bkovors")]
        public void AzonositoRosszTest(string alapadat, string jelszo)
        {
            Tanulo tanulo = new Tanulo(alapadat);

            string aktualis = tanulo.Azonosito();

            Assert.AreNotEqual(jelszo, aktualis);
        }
    }
}