using System;
using Clase;

namespace Builder
{
    public interface HamburguesaBuilder
    {
        public void nombre();
        public void relleno();
        public void pan();
        public void precio();
        public void tamanio();

        public Hamburguesa obtenerHamburguesa();
    }
}
