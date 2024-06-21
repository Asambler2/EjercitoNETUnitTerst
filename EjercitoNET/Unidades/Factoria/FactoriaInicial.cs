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
    public class FactoriaInicial : IUnidadFactoryMethod
    {
        public IUnidad dameUnidad(TiposDeUnidades tipo)
        {
            switch (tipo)
            {
                case TiposDeUnidades.TransporteMX7899:
                    return new UnidadMilitar(
                            TipoArma.Caballeria,
                            new BlindadoVariable(1.4),
                            new SinDestruccion(),
                            new MovilidadVariable(4.5),
                            new CosteVariable(4200));
                case TiposDeUnidades.TanqueDeAtaqueSombrasVB98:
                    return new UnidadMilitar(
                            TipoArma.Caballeria,
                            new BlindadoVariable(4.8),
                            new DestruccionVariable(9.8),
                            new MovilidadVariable(7.3),
                            new CosteVariable(15600));
                case TiposDeUnidades.TransporteRapido:
                    return new UnidadMilitar(
                            TipoArma.Caballeria,
                            new SinBlindado(),
                            new SinDestruccion(),
                            new MovilidadVariable(12),
                            new CosteVariable(1600));
                case TiposDeUnidades.InfanteriaBasica:
                    return new UnidadMilitar(
                            TipoArma.Infanteria,
                            new SinBlindado(),
                            new DestruccionVariable(7),
                            new MovilidadVariable(6),
                            new CosteVariable(250));
                case TiposDeUnidades.Ametrallador:
                    return new UnidadMilitar(
                            TipoArma.Infanteria,
                            new SinBlindado(),
                            new DestruccionVariable(10),
                            new MovilidadVariable(4),
                            new CosteVariable(400));
                case TiposDeUnidades.Sanitario:
                    return new UnidadMilitar(
                            TipoArma.Infanteria,
                            new BlindadoVariable(5),
                            new SinDestruccion(),
                            new MovilidadVariable(7),
                            new CosteVariable(500));
                case TiposDeUnidades.CanonAntiareo:
                    return new UnidadMilitar(
                            TipoArma.Artilleria,
                            new SinBlindado(),
                            new DestruccionVariable(22),
                            new MovilidadVariable(1),
                            new CosteVariable(1100));
                case TiposDeUnidades.TorpederoMovil:
                    return new UnidadMilitar(
                            TipoArma.Artilleria,
                            new BlindadoVariable(2),
                            new DestruccionVariable(19),
                            new MovilidadVariable(3),
                            new CosteVariable(1300));
                case TiposDeUnidades.Canon:
                    return new UnidadMilitar(
                            TipoArma.Artilleria,
                            new SinBlindado(),
                            new DestruccionVariable(14),
                            new Estatico(),
                            new CosteVariable(1100));
                default:
                    return null;

            }
        }
    }
}
