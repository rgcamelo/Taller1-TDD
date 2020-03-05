using NUnit.Framework;
using Taller1;

namespace PruebasTaller1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var cuenta1 = new CuentaAhorro("10001", "Cuenta Ejemplo", 0, true, "Valledupar");
            var mensaje = cuenta1.Consignar(-10000,"Valledupar");
            


            Assert.AreEqual("El valor a consignar es incorrecto",mensaje);
        }

        [Test]
        public void Test2()
        {
            var cuenta1 = new CuentaAhorro("10001", "Cuenta Ejemplo", 0, true, "Valledupar");
            var mensaje = cuenta1.Consignar(50000,"Valledupar");


            Assert.AreEqual("Su nuevo saldo es $50000", mensaje);
        }

        [Test]
        public void Test3()
        {
            var cuenta1 = new CuentaAhorro("10001", "Cuenta Ejemplo", 0, true, "Valledupar");
            var mensaje = cuenta1.Consignar(49950,"Valledupar");


            Assert.AreEqual("el valor minimo de la primera consignacion debe ser de $50000 mil pesos" +
                            $"Su nuevo saldo es $0", mensaje);
        }

        [Test]
        public void Test4()
        {
            var cuenta1 = new CuentaAhorro("10001", "Cuenta Ejemplo", 30000, false, "Valledupar");
            var mensaje = cuenta1.Consignar(49950,"Valledupar");


            Assert.AreEqual("Su nuevo saldo es $79950", mensaje);
        }

        [Test]
        public void Test5()
        {
            var cuenta1 = new CuentaAhorro("10001", "Cuenta Ejemplo", 30000, false, "Bogota");
            var mensaje = cuenta1.Consignar(49950, "Valledupar");


            Assert.AreEqual("Su nuevo saldo es $69950", mensaje);
        }

    }
}
