using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Coleccion
{
    internal interface IColeccionMilitar : IPreguntasCastrenses
    {
        void add(IUnidad unidad);
    }
}
