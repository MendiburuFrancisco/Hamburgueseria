using System;
using Builder;
using Clase; 

namespace BuilderConcreto
{
    public class Generica : HamburguesaBuilder
    {
        private Hamburguesa normal = new Hamburguesa();
        string[] tamanioH = { "normal", "medio", "grande" };

        public Generica()
        {
            //pan();
            //relleno();
            //precio();
            tamanio();
        }
      
        public void relleno()
        {
            normal.relleno = "lechuga + tomate + carne + panceta";
        }
        public void pan()
        {
            normal.pan = "de papa";
        }
        public void precio()
        {
            normal.precio = 150;
        }
        public void tamanio()
        {
            
            int op = -1; 
            while( op < 0 | op > 2 )
            {
                Console.WriteLine("Seleccionar opcion");
                
                for (int i = 0; i < tamanioH.Length; i++)
                {
                    Console.WriteLine($"({i}) - {tamanioH[i]}");
                }
                op = int.Parse(Console.ReadLine());

            }

            normal.tamanio = tamanioH[op]; 


            
            
        }

        public Hamburguesa obtenerHamburguesa() => normal;
         

    }
}


//selecciona un nombre que defina la representación del objeto a crear. 
//implementa la clase abstracta  Builder
//cconstruye y ensambla las partes del producto.
//ejemplo en c#: clase BuilderPizzaHawaiana : BuilderPizza