using EjercitoNET.Unidades.Blindados;
using EjercitoNET.Unidades.Destruccion;
using EjercitoNET.Unidades.Factoria;
using EjercitoNET.Unidades.Gasto;
using EjercitoNET.Unidades.Movilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades
{
    public class UnidadMilitar : IUnidad, IPreguntasCastrenses
    {
        private TipoArma tipo;
        private IBlindado blindaje;
        private IDestructor destruccion;
        private IMovil transporte;
        private IGastable gasto;

        public UnidadMilitar(TipoArma tipo, IBlindado blindaje, IDestructor destruccion, IMovil transporte, IGastable gasto)
        {
            this.blindaje = blindaje;
            this.destruccion = destruccion;
            this.transporte = transporte;
            this.gasto = gasto;
            this.tipo = tipo;
        }

    public short numeroDeElementos()
        {
            return 1;
        }


    public double potenciaFuegoTotal()
        {
            return destruccion.capacidadDeDestruccion();
        }


    public double blindajeTotal()
        {
            return blindaje.resistenciaAlAtaque();
        }


    public double capacidadDeMovimiento()
        {
            return transporte.capacidadDeMovimiento();
        }


    public double dineroGastado()
        {
            return gasto.dameCoste();
        }


    public double capacidadMilitar()
        {
            return (this.potenciaFuegoTotal() * (this.capacidadDeMovimiento() / 2)) / (100 - blindaje.resistenciaAlAtaque());
        }
    }
}
