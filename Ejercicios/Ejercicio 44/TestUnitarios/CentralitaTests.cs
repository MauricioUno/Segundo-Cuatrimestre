using Entidades.Clases;
using Entidades.Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class CentralitaTests
    {
        [TestMethod]
        public void AlInstanciarCentralita_DeberiaInstanciarLaListaDeLlamadas()
        {
            Centralita centralita = new Centralita("Kokos");
            Assert.IsNotNull(centralita.Llamadas);
        }

        [TestMethod]
        public void AlAgregarUnaLlamada_DeClaseLocal_DeberiaObtenerCentralitaException() 
        {
            Centralita centralita = new Centralita("Kokos");
            Local llamadaLocal = new Local("A",15,"B",30);

            centralita += llamadaLocal;

            Assert.ThrowsException<CentralitaException>(() => centralita += new Local("A", 13, "B", 10));
        }

        [TestMethod]
        public void AlAgregarUnaLlamada_DeClaseProvincial_DeberiaObtenerCentralitaException()
        {
            Centralita centralita = new Centralita("Kokos");
            Provincial llamadaProvincial = new Provincial("A", EFranja.Franja_1, 21, "B");
            centralita += llamadaProvincial;
            Assert.ThrowsException<CentralitaException>(() => centralita += new Provincial("A", EFranja.Franja_3, 30, "B"));
        }

        [TestMethod]
        public void AlCompararLlamadasConDestinoYOrigenIguales_DeberiaObtenerIgualdadSoloConLaMismaClase() 
        {
            Local l1 = new Local("A", 45, "B", 1.99f);
            Local l2 = new Local("A", 50, "B", 2.99f);
            Provincial l3 = new Provincial("A", EFranja.Franja_1, 21, "B");
            Provincial l4 = new Provincial("A", EFranja.Franja_3, 12, "B");
            bool IgualdadLocales = false;
            bool IgualdadProvinciales = false;
            if (l2 != l3 && l2 != l4 && l2 == l1) 
            {
                IgualdadLocales = true;
            }
            if (l3 != l2 && l3 != l1 && l3 == l4)
            {
                IgualdadProvinciales = true;
            }

            Assert.AreEqual(IgualdadLocales, IgualdadProvinciales);

        }
    }
}