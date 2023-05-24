namespace TestUnitarios
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        public void UtilizarElMetodoLanzarExcepcion_DeMiClase_DeberiaObtenerDivideByZeroException()
        {
            Assert.ThrowsException<DivideByZeroException>(() => MiClase.LanzarExcepcion());
        }

        [TestMethod]
        public void InstanciarMiClase_DeberiaObtenerFormatException()
        {
            Assert.ThrowsException<FormatException>(() => new MiClase());
        }

        [TestMethod]
        public void InstanciarMiClaseConId_DeberiaObtenerUnaExcepcion()
        {
            int id = 24;
            Assert.ThrowsException<UnaExcepcion>(() => new MiClase(24));
        }

        [TestMethod]
        public void UtilizarElMetodoInstanciarMiClase_DeOtraClase_DeberiaObtenerMiExcepcion()
        {
            OtraClase otraClase = new OtraClase();
            Assert.ThrowsException<MiExcepcion>(() => otraClase.InstanciarMiClase());
        }
    }
}