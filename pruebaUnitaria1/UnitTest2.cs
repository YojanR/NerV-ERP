using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nerv;
using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaUnitaria1
{
    class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            string Cat = "12345678901231312";
            string Cla = "3";
            string Nom = "Juan Antonio Ramirez Perez";
            bool Esperado = true;

            var actual = ValidarTB.VerificarCamposDeTextoCatalogoProducto(Cat, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string Cat = "123456789";
            string Cla = "-2";
            string Nom = "Juan Antonio Ramirez Perez";
            bool Esperado = true;

            var actual = ValidarTB.VerificarCamposDeTextoCatalogoProducto(Cat, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string Cat = "8901231312";
            string Cla = "3";
            string Nom = "Oro";
            bool Esperado = true;

            var actual = ValidarTB.VerificarCamposDeTextoCatalogoProducto(Cat, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string Cat = "01231312";
            string Cla = "3";
            string Nom = "Memoria";
            bool Esperado = true;

            var actual = ValidarTB.VerificarCamposDeTextoCatalogoProducto(Cat, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
    }
}
