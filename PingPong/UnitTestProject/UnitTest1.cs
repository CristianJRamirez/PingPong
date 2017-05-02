using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nombre = "David";
            string puntos = "5";

            Jugador j = new Jugador(nombre, puntos);

            Assert.AreEqual(j.nombre, nombre);
            Assert.AreEqual(j.puntos, puntos);

            Assert.IsNotNull(j);

            Assert.IsNull(j.ID);
        }
    }
}
