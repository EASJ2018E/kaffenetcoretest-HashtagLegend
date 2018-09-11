using System;
using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAfPrisIkkeUnder0()
        {
            //arrange
            var sortKaffe = new SortKaffe(20);

            //act

            int pris = sortKaffe.Pris();

            //assert

            Assert.Fail();
        }

        [TestMethod]
        public void TestAfCortadoM�lk()
        {
            //arrange
            var  cortadoKaffe = new Cortado();
            //act
            int mlkM�lk = cortadoKaffe.MlM�lk();
            //assert
            Assert.AreEqual(25, mlkM�lk);
        }

        [TestMethod]
        public void TestAfCortadoPris()
        {
            //arrange
            var cortadoKaffe = new Cortado();
            //act
            int pris = cortadoKaffe.Pris();
            //assert
            Assert.AreEqual(25, pris);
        }

        [TestMethod]
        public void FlatwhiteStyrkeTest()
        {
            //arrange
            var flatWhite = new FlatWhite();
            //act
            string styrke = flatWhite.Styrke();
            //assert
            Assert.AreEqual(styrke, "Mild");
        }

        [TestMethod]
        public void FlatWhiteM�lkTest()
        {
            //arrange
            var flatWhite = new FlatWhite();
            //act
            int mlM�lk = flatWhite.MlM�lk();
            //assert
            Assert.AreEqual(160, mlM�lk);
        }

        [TestMethod]
        public void FlatWhitePris()
        {
            //arrange
            var flatWhite = new FlatWhite();
            //act
            int pris = flatWhite.Pris();
            //assert
            Assert.AreEqual(45, pris);
        }

        [TestMethod]
        public void LatteM�lkTest()
        {
            //arrange
            var latte = new Latte();
            //act
            int mlM�lk = latte.MlM�lk();
            //assert
            Assert.AreEqual(120, mlM�lk);
        }

        [TestMethod]
        public void LattePrisTest()
        {
            //arrange
            var latte = new Latte();
            //act
            int pris = latte.Pris();
            //assert
            Assert.AreEqual(40, pris);
        }
    }
}
