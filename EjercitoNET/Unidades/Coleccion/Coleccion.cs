using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Coleccion
{
    public class Coleccion : IColeccionMilitar
    {
        private List<IPreguntasCastrenses> tropa;
        private double _dineroGastado=0;

        public Coleccion()
        {
            tropa = new List<IPreguntasCastrenses>();
        }


    public void add(IUnidad unidad)
        {
            tropa.Add((IPreguntasCastrenses)unidad);
            _dineroGastado += (unidad as IPreguntasCastrenses).dineroGastado();
        }


    public short numeroDeElementos()
        {
            return (short)tropa.Count();
        }


    public double potenciaFuegoTotal()
        {
            double potenciaDeFuego = 0;
            foreach (var item in tropa)
            {
                potenciaDeFuego += (item as IPreguntasCastrenses).potenciaFuegoTotal();
            }
            return potenciaDeFuego;
        }


    public double blindajeTotal()
        {
            double blindaje = 0;

            Parallel.ForEach(tropa, item =>
            {
                blindaje+= (item as IPreguntasCastrenses).blindajeTotal();
            });

            return blindaje;
        }


    public double capacidadDeMovimiento()
        {
            double movimiento = 0;

            Parallel.ForEach(tropa, item =>
            {
                movimiento += (item as IPreguntasCastrenses).capacidadDeMovimiento();
            });
            
            return movimiento;
        }


    public double dineroGastado()
        {
            return this._dineroGastado;
        }


    public double capacidadMilitar()
        {
            return (this.potenciaFuegoTotal() * (this.capacidadDeMovimiento() / 2)) / (100 - this.blindajeTotal());

        }
    }
}
