using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nerv;

namespace pruebaUnitaria1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Tel = "1234";
            string Cla = "1234";
            string Nom = "1234";
            bool Esperado = false;

            var actual = ValidarTB.VerificarCamposDeTextoCliente(Tel, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string Tel = "1234567890";
            string Cla = "-1";
            string Nom = "1234";
            bool Esperado = false;

            var actual = ValidarTB.VerificarCamposDeTextoCliente(Tel, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string Tel = "1234567890";
            string Cla = "3";
            string Nom = "Juan Antonio Luis Jose Gardea De La Rosa Ramirez Perez";
            bool Esperado = false;

            var actual = ValidarTB.VerificarCamposDeTextoCliente(Tel, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string Tel = "1234567890";
            string Cla = "3";
            string Nom = "Juan Antonio Ramirez Perez";
            bool Esperado = true;

            var actual = ValidarTB.VerificarCamposDeTextoCliente(Tel, Cla, Nom);

            Assert.AreEqual(Esperado, actual);
        }
    }
}
