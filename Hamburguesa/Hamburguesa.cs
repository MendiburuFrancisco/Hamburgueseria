using System;
namespace Clase
{
    public class Hamburguesa 
    {
        public string nombre { get; set; }
        public string pan { get; set; }
        public string relleno { get; set; }
        public string tamanio { get; set; }
        public int precio { get; set; }

        public Hamburguesa()
        {

        }

        public Hamburguesa(string pan,string relleno, string tamanio, int precio)
        {
            this.pan = pan;
            this.relleno = relleno;
            this.tamanio = tamanio;
            this.precio = precio;
            Console.WriteLine("Se creo con exito la siguiente hamburguesa");
            Console.WriteLine($"Pan: {pan}\nRelleno: {relleno}\nTamanio: {tamanio}\nPrecio: {precio}");
        }

         public void obtenerHamburguesa()
        {
            Console.WriteLine("Hamburgesa: " + nombre );
            Console.WriteLine(" * Pan: " + pan);
            Console.WriteLine(" * Relleno: " + relleno);
            Console.WriteLine(" * Tamanio: " + tamanio);
            Console.WriteLine(" * Precio: $" + precio);
        }
    }
}
