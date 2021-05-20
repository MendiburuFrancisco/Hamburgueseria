using System;
using Clase;
using Director;
using BuilderConcreto;
using Builder;
using System.Collections.Generic;

namespace Hamburgueseria
{
    class Program
    {
        static void Main(string[] args)
        {
            
             
            var Pedidos = new List<Hamburguesa>();
            int seleccionarComida = menu();
            Hamburguesa hamburguesaPreparada = pedirComida(seleccionarComida);
           
            

 
        }

        static Hamburguesa nuevoPedido()
        {
            Cocina nuevaCocina = new Cocina();

            nuevaCocina.pedidoHamburguesa(new Generica());
            nuevaCocina.prepararHamburguesa();
            return nuevaCocina.construirHamburguesa();
        }

        static Hamburguesa nuevoPedido(string pan, string relleno, string tamanio, int precio)
        {
            Hamburguesa HamburguesaPersonalizada = new Hamburguesa(pan, relleno, tamanio, precio+50);

            return HamburguesaPersonalizada;
        }

        static int menu()
        {
            Console.WriteLine("Bienvenido a la hamburguesaria");
            Console.WriteLine("1 - Ver Carta");
            Console.WriteLine("2 - Pedir Hamburguesa a gusto");
            
            int op = -1; 
            while(op < 0 | op > 2)
            {
                Console.WriteLine("Seleccionar Opcion: ");

                op = int.Parse(Console.ReadLine());


            }

            return op;
        }
        static Hamburguesa pedirComida(int comidaSeleccionada)
        {
            Hamburguesa nuevaHamburguesa = new Hamburguesa();

            switch (comidaSeleccionada)
            {
                case 1: nuevaHamburguesa  = carta(); break;

            }

            return nuevaHamburguesa;
        }
        static Hamburguesa carta()
        {
            Hamburguesa hambPedida = new Hamburguesa;
            int seleccionComida = 0;
            Console.WriteLine("Carta");
            Console.WriteLine("1 - Generica");

            Console.WriteLine("Ingresar seleccion");
            seleccionComida = int.Parse(Console.ReadLine());
            
            if(seleccionComida == 1) 
            {
                hambPedida = nuevoPedido();
            }

            return hambPedida;
        }

        static void mostrarHamburguesa(Hamburguesa nueva)
        {

        }


    }


}
