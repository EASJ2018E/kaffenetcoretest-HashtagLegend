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
        public void TestAfCortadoMælk()
        {
            //arrange
            var  cortadoKaffe = new Cortado();
            //act
            int mlkMælk = cortadoKaffe.MlMælk();
            //assert
            Assert.AreEqual(25, mlkMælk);
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
        public void FlatWhiteMælkTest()
        {
            //arrange
            var flatWhite = new FlatWhite();
            //act
            int mlMælk = flatWhite.MlMælk();
            //assert
            Assert.AreEqual(160, mlMælk);
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
        public void LatteMælkTest()
        {
            //arrange
            var latte = new Latte();
            //act
            int mlMælk = latte.MlMælk();
            //assert
            Assert.AreEqual(120, mlMælk);
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
