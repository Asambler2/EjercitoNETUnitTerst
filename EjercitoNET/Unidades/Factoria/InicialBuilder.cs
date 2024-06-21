using EjercitoNET.Unidades.Blindados;
using EjercitoNET.Unidades.Destruccion;
using EjercitoNET.Unidades.Gasto;
using EjercitoNET.Unidades.Movilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Factoria
{
    internal class InicialBuilder : IUnidadBuilder
    {
        public IUnidad dameUnidad(TipoArma tipoArma, double blindaje, double destruccion, double movilidad, double coste)
        {
            IBlindado blind;
            if (blindaje == 0)
                blind = new SinBlindado();
            else
                blind = new BlindadoVariable(blindaje);
            IDestructor destructor;
            if (destruccion == 0)
                destructor = new SinDestruccion();
            else
                destructor = new DestruccionVariable(destruccion);
            IMovil movil;
            if (movilidad == 0)
                movil = new Estatico();
            else
                movil = new MovilidadVariable(movilidad);
            IGastable gasto;
            if (coste == 0)
                gasto = new SinCoste();
            else
                gasto = new CosteVariable(coste);
            return new UnidadMilitar(tipoArma, blind, destructor, movil, gasto);

        }
    }
}
