using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Destruccion 
{
    public class DestruccionVariable : IDestructor
    {
    private double destruccion;

    public DestruccionVariable(double destruccion)
    {
        setDestruccion(destruccion);
    }

    public void setDestruccion(double destruccion)
    {
        if (destruccion < 0)
            destruccion = 0;
        else
            this.destruccion = destruccion;
    }
    public double capacidadDeDestruccion()
    {
        return destruccion;
    }
}
}
