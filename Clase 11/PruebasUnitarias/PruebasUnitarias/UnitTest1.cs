using Entidades.Excepciones;
using System.Text;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlRecibirUnNumeroUno_EnDecimal_DeberiaObternerUnNumeroRomano()
        {
            //given
            //arrange
            int numero = 1;
            string expected = "I";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            //assert
            //then
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void AlRecibirUnNumeroDos_EnDecimal_DeberiaObternerUnNumeroRomano()
        {
            //given
            //arrange
            int numero = 2;
            string expected = "II";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            //assert
            //then
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void AlRecibirInvalido_DeberiaObternerUnError()
        {
            //given
            //arrange

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(0);

            //assert
            //then
            Assert.ThrowsException<NumeroInvalidoException>(() => Conversor.ConvertirANumeroRomano(-10));
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void AlRecibirUnNumero_EnDecimal_DeberiaObternerSuEquivalenteRomano(int value)
        {
            //given
            //arrange

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('I', value);
            string esperado = stringBuilder.ToString();

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(value);

            //assert
            //then
            Assert.AreEqual(resultado, esperado);
        }
    }
}