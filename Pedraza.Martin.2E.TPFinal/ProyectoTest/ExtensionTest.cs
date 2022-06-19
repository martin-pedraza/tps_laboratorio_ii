using Biblioteca;
namespace ProyectoTest
{
    [TestClass]
    public class ExtensionTest
    {
        [TestMethod]
        public void PrimerizarPalabra_RecibeUnTexto_DeberiaRetornarLaPrimerPalabra()
        {
            string texto = "Este es el texto que será validado.";
            string expected = "Este";

            string actual = texto.PrimerizarPalabra();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NoNumber_RecibeUnaPalabraConUnNumero_DeberiaRetornarTrue()
        {
            string texto = "TrabajoPractico4";
            bool expected = true;

            bool actual = texto.NoNumber();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LengthWord_RecibeUnaSilabaCuandoElNumeroEs5_DeberiaRetornarTrue()
        {
            string silaba = "si";
            bool expected = true;

            bool actual = silaba.LengthWord(5);

            Assert.AreEqual(expected, actual);
        }
    }
}