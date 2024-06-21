using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Gasto
{
    public class CosteVariable : IGastable
    {
        private double coste;

        public CosteVariable(double coste)
        {
            this.coste = coste;
        }

        public double dameCoste()
        {
            return coste;
        }

        public void setCoste(double coste)
        {
            if (coste < 0)
                this.coste = 0;
            else
                this.coste = coste;
        }
    }
}
