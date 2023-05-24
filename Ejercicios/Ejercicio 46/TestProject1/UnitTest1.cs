namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(3, 100, ETipoCompetencia.AutoF1)]
        public void InstanciarUnaCompetencia_DeberiaInstanciarSuListaDeVehiculos(int cantidadCompetidores, int cantVueltas, ETipoCompetencia tipo)
        {
            Competencia zyox = new Competencia((short)cantidadCompetidores, (short)cantVueltas, tipo);

            Assert.IsNotNull(zyox.Competidores);
        }

        [TestMethod]
        public void AgregarUnVehiculoNoCorrespondiente_ALaCompetencia_DeberiaObtenerCompetenciaNoDisponibleException()
        {
            Exception exception = new Exception();

            try
            {
                Competencia zyox = new Competencia(3, 100, ETipoCompetencia.MotoCross);
                zyox.Competidores.Add(new AutoF1(95, "Rayo", 100));
            }
            catch(Exception ex) 
            {
                exception = ex.InnerException;
            }

            Assert.IsTrue(exception is CompetenciaNoDisponibleException);
        }

        [TestMethod]
        public void AgregarUnVehiculoCorrespondiente_ALaCompetencia_NoDeberiaObtenerCompetenciaNoDisponibleException()
        {
            Exception exception = new Exception();
            
            try
            {
                Competencia zyox = new Competencia(3, 100, ETipoCompetencia.MotoCross);
                zyox.Competidores.Add(new AutoF1(95, "Rayo", 100));
            }
            catch (Exception ex)
            {
                exception = ex.InnerException;
            }

            Assert.IsTrue(exception is not CompetenciaNoDisponibleException);
            
        }

        [TestMethod]
        public void AgregarUnVehiculoCorrespondiente_ALaCompetencia_DebeGuardarloEnLaLista()
        {
            Competencia zyox = new Competencia(3, 100, ETipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(95, "Rayo", 100);
            
            bool aux = zyox + moto;
            Assert.IsTrue(zyox == moto);
        }

        [TestMethod]
        public void RemoverUnVehiculoCorrespondiente_ALaCompetencia_DebeQuitarloDeLaLista()
        {
            Competencia zyox = new Competencia(3, 100, ETipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(95, "Rayo", 100);
            
            zyox.Competidores.Add(moto);
            bool aux = zyox - moto;

            Assert.IsTrue(zyox != moto);
        }
    }
}