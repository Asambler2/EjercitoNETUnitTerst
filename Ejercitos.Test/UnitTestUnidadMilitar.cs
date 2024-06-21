using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercitoNET.Unidades.Gasto;
using EjercitoNET.Unidades;
using EjercitoNET.Unidades.Blindados;
using EjercitoNET.Unidades.Destruccion;
using EjercitoNET.Unidades.Factoria;
using EjercitoNET.Unidades.Movilidad;

namespace Ejercitos.Test
{
    [TestClass]
    public class UnitTestUnidadMilitar
    {
        private UnidadMilitar soldadito = new UnidadMilitar(TipoArma.Caballeria,
            new BlindadoVariable(4.8),
            new DestruccionVariable(9.8),
            new MovilidadVariable(7.3),
            new CosteVariable(15600));

        [TestMethod]
        public void numeroDeElementos()
        {
            Assert.AreEqual(1, soldadito.numeroDeElementos());
        }

        [TestMethod]
        public void potenciaFuegoTotal()
        {
            Assert.AreEqual(9.8, soldadito.potenciaFuegoTotal());
        }

        [TestMethod]
        public void blindajeTotal()
        {
            Assert.AreEqual(4.8, soldadito.blindajeTotal());
        }

        [TestMethod]
        public void capacidadDeMovimiento()
        {
            Assert.AreEqual(7.3, soldadito.capacidadDeMovimiento());
        }

        [TestMethod]
        public void dineroGastado()
        {
            Assert.AreEqual(15600, soldadito.dineroGastado());
        }

        [TestMethod]
        public void capacidadMilitar()
        {
            Assert.AreEqual(Math.Round(0.37573529411764706,10), Math.Round(soldadito.capacidadMilitar(), 10));
        }
    }
}
