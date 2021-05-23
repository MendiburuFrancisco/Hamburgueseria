using System;
using Builder;
using BuilderConcreto;
using Clase;

namespace Director
{
    public class Cocina
    {
        private static HamburguesaBuilder HamburguesaNueva;

        public static void pedidoHamburguesa(HamburguesaBuilder HamburguesaSolicitada)
        {
          
            HamburguesaNueva = HamburguesaSolicitada;

            Console.WriteLine("Se registro el pedido con exito");
        }

        public static void prepararHamburguesa()
        {
            HamburguesaNueva.relleno();
            HamburguesaNueva.pan();
            HamburguesaNueva.precio();
            HamburguesaNueva.tamanio();
            HamburguesaNueva.nombre();
        }

        public static Hamburguesa construirHamburguesa() => HamburguesaNueva.obtenerHamburguesa();

    }
}
