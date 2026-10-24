using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        // ---------- CalcularFactorial ----------
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno(int n)
        {
            Assert.AreEqual(-1L, Funciones.CalcularFactorial(n));
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            Assert.AreEqual(1L, Funciones.CalcularFactorial(0));
        }

        [TestMethod]
        [DataRow(1, 1L)]
        [DataRow(5, 120L)]
        [DataRow(10, 3628800L)]
        [DataRow(20, 2432902008176640000L)]
        public void CalcularFactorial_Positivo_DevuelveFactorialCorrecto(int n, long esperado)
        {
            Assert.AreEqual(esperado, Funciones.CalcularFactorial(n));
        }
    }
}
