using EjercitoNET.Unidades;
using EjercitoNET.Unidades.Coleccion;
using EjercitoNET.Unidades.Factoria;

namespace EjercitoNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnidadFactoryMethod Factoria = new FactoriaConBuilder();
            IColeccionMilitar Ejercito = new Coleccion();
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.Ametrallador));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.Canon));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.Sanitario));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.CanonAntiareo));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.InfanteriaBasica));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.TanqueDeAtaqueSombrasVB98));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.TorpederoMovil));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.TransporteMX7899));
            Ejercito.add(Factoria.dameUnidad(TiposDeUnidades.TransporteRapido));

            Console.WriteLine("Blindaje: " + Ejercito.blindajeTotal());
            Console.WriteLine("Potencia: " + Ejercito.potenciaFuegoTotal());
            Console.WriteLine("Movimiento: " + Ejercito.capacidadDeMovimiento());
            Console.WriteLine("Coste:" + Ejercito.dineroGastado());
            Console.WriteLine("Numero de unidades:" + Ejercito.numeroDeElementos());
            Console.WriteLine("CM:" + Ejercito.capacidadMilitar());
        }
    }
}
