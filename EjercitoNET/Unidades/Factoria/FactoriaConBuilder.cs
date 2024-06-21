using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoNET.Unidades.Factoria
{
    internal class FactoriaConBuilder : IUnidadFactoryMethod
    {
        public IUnidad dameUnidad(TiposDeUnidades tipo)
        {
            InicialBuilder build = new InicialBuilder();
            switch (tipo)
            {
                case TiposDeUnidades.TransporteMX7899:
                    return build.dameUnidad(TipoArma.Caballeria, 1.4, 0, 4.5, 4200);
                case TiposDeUnidades.TanqueDeAtaqueSombrasVB98:
                    return build.dameUnidad(TipoArma.Caballeria, 4.8, 9.8, 7.3, 15600);
                case TiposDeUnidades.TransporteRapido:
                    return build.dameUnidad(TipoArma.Caballeria, 0, 0, 12, 1600);
                case TiposDeUnidades.InfanteriaBasica:
                    return build.dameUnidad(TipoArma.Infanteria, 0, 7, 6, 250);
                case TiposDeUnidades.Ametrallador:
                    return build.dameUnidad(TipoArma.Infanteria, 0, 10, 4, 400);
                case TiposDeUnidades.Sanitario:
                    return build.dameUnidad(TipoArma.Infanteria, 5, 0, 7, 500);
                case TiposDeUnidades.CanonAntiareo:
                    return build.dameUnidad(TipoArma.Artilleria, 0, 22, 1, 1100);
                case TiposDeUnidades.TorpederoMovil:
                    return build.dameUnidad(TipoArma.Artilleria, 2, 19, 3, 1300);
                case TiposDeUnidades.Canon:
                    return build.dameUnidad(TipoArma.Artilleria, 0, 14, 0, 1100);
                default:
                    return null;

            }
        }
    }
}
