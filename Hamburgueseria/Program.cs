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
           // mostrarHamburguesas(Pedidos);
            int seleccionarComida = menu();
            Hamburguesa hamburguesaPreparada = pedirComida(seleccionarComida);
            Pedidos.Add(hamburguesaPreparada);
 
            mostrarHamburguesas(Pedidos);
 

        }

        static Hamburguesa nuevoPedido(HamburguesaBuilder nueva)
        { 
            Cocina.pedidoHamburguesa(nueva);
            Cocina.prepararHamburguesa();
            return Cocina.construirHamburguesa();
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
                case 1:  
                        if(carta() == 1)
                    {
                        nuevaHamburguesa = nuevoPedido(new Generica());
                     }

                    break;

                case 2:

                    nuevaHamburguesa = nuevoPedido(new Personalizada());


                    break;

            }

            return nuevaHamburguesa;
        }
        static int carta()
        {
            int seleccionComida = 0;
            Console.WriteLine("Carta");
            Console.WriteLine("1 - Generica");

            Console.WriteLine("Ingresar seleccion");
            seleccionComida = int.Parse(Console.ReadLine());
          
            return seleccionComida;
        }

        static void mostrarHamburguesas(List<Hamburguesa> listaCreada)
        {
            Hamburguesa ham;
            Console.WriteLine();
            Console.WriteLine("---Lista de Hamburguesas----");
            foreach (var Hamburguesas in listaCreada)
            {
                  ham = (Hamburguesa)Hamburguesas;

                ham.obtenerHamburguesa();

            }

            Console.WriteLine("--------------------------");

        }


    }


}
