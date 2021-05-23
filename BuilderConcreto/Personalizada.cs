using System;
using System.Collections.Generic;
using System.Text;
using Builder;
using Clase;

namespace BuilderConcreto
{
    public class Personalizada: HamburguesaBuilder
    {
        Hamburguesa HPersonalizada = new Hamburguesa();
        public void nombre()
        {
           HPersonalizada.nombre = "Hamburguesa Personalizada";
        }

        public Hamburguesa obtenerHamburguesa()
        {
            return HPersonalizada;
        }

        public void pan()
        {
            Console.WriteLine("Ingresa el tipo de pan");
            HPersonalizada.pan = Console.ReadLine();
        }

        public void precio()
        {
            HPersonalizada.precio = 1200;
        }

        public void relleno()
        {
            Console.WriteLine("Ingresa el relleno");
            HPersonalizada.relleno = Console.ReadLine();
        }

        public void tamanio()
        {
            Console.WriteLine("Ingresa el tamanio ");
            HPersonalizada.tamanio = Console.ReadLine();
        }
    }
}
