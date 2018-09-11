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
        public void FlatwhiteStyrke()
        {
            //arrange
            var flatWhite = new FlatWhite();
            //act
            string styrke = FlatwhiteStyrke("mild");
            //assert
            Assert.AreEqual(styrke, "mild");
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            //act
            //assert
        }
    }
}
