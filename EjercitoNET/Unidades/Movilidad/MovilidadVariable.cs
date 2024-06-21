using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Movilidad
{
    public class MovilidadVariable : IMovil
    {
        private double movilidad;


        public MovilidadVariable(double movilidad)
        {
            setMovilidad(movilidad);
        }
        public void setMovilidad(double movilidad)
        {
            if (movilidad < 0)
                this.movilidad = 0;
            else
                this.movilidad = movilidad;
        }
        public double capacidadDeMovimiento()
        {
            return movilidad;
        }
    }
}
