using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Blindados
{
    public class BlindadoVariable : IBlindado
    {

    private double blindaje;

    public BlindadoVariable(double blindaje)
    {
        setBlindaje(blindaje);
    }

    public void setBlindaje(double blindaje)
    {
        if (blindaje < 0)
            this.blindaje = 0;
        else
            this.blindaje = blindaje;
    }

    public double resistenciaAlAtaque()
    {
        return blindaje;
    }
}

}
