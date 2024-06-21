using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Factoria
{
    public interface IUnidadBuilder
    {
        IUnidad dameUnidad(TipoArma tipoArma,
            double blindaje,
            double destruccion,
            double movilidad,
            double coste);
    }
}
