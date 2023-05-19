namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //given
            //arrange
            int numero = 1;
            string expected = "I";

            //when
            //act
            string resultado = Conversor.ConvertirNumeroRomano();

            //assert
            //then
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //given
            //arrange
            int numero = 2;
            string expected = "II";

            //when
            //act
            string resultado = Conversor.ConvertirNumeroRomano();

            //assert
            //then
            Assert.AreEqual(expected, resultado);
        }
    }
}