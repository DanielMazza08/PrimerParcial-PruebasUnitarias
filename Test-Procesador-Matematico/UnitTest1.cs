using Microsoft.VisualStudio.TestTools.UnitTesting;
using primer_parcial_unit_test_procesador_matematico;
namespace Test_Procesador_Matematico
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void Dividendo_ResultadoCorrecto()
        {
            //Arrange
            ProcesadorMatematico procesador = new ProcesadorMatematico();
            int dividendo = 6;
            int divisor = 3;
            int resultadoEsperado = 2;

            //Act
            procesador.Dividir(dividendo, divisor);

            //Assert - El resultado debe ser un 2
            Assert.AreEqual(resultadoEsperado, procesador._resultado);
        }

        [TestMethod]
        public void DevolverElMayorEntreDosNumeros()
        {
            //Arrange
            var procesador = new ProcesadorMatematico();
            var primerNumero = 5;
            var segundoNumero = 10;

            //Act
            procesador.CalcularMayor(primerNumero, segundoNumero);
            var resultado = procesador._resultado;

            //Assert - M;e tiene que devolver el segundo numero
            Assert.AreEqual(segundoNumero, resultado);
        }

        [TestMethod]
        public void DividirPorCero_DebeRetornarCero()
        {
            // Arrange
            var procesador = new ProcesadorMatematico();
            var dividendo = 5;
            var divisor = 0;

            // Act
            procesador.Dividir(dividendo, divisor);
            var resultado = procesador._resultado;

            //Act & Assert
            Assert.ThrowsException<System.DivideByZeroException>(() => procesador.Dividir(dividendo, divisor));
        }
    }
}