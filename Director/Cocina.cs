using System;
using Builder;
using BuilderConcreto;
using Clase;

namespace Director
{
    public class Cocina
    {
        private HamburguesaBuilder HamburguesaNueva;

        public void pedidoHamburguesa(HamburguesaBuilder HamburguesaSolicitada)
        {
          
            HamburguesaNueva = HamburguesaSolicitada;

            Console.WriteLine("Se registro el pedido con exito");
        }

        public void prepararHamburguesa()
        {
            HamburguesaNueva.relleno();
            HamburguesaNueva.pan();
            HamburguesaNueva.precio();
        }

        public Hamburguesa construirHamburguesa() => HamburguesaNueva.obtenerHamburguesa();

    }
}
