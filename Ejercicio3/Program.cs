using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia menú
            
            Menu menu = new Menu();
            //se crea un string continuar para indicar si continúa haciendo el while
            string continuar = "si";
            Console.WriteLine("Menu: ");


            while (continuar == "si")
            {
                Console.WriteLine("1. Hamburguesa Sencilla (5€)");
                Console.WriteLine("2. Hamburguesa con Queso (8€)");
                Console.WriteLine("3. Hamburguesa Especial (10€)");
                Console.WriteLine("4. Patatas Fritas (3€)");
                Console.WriteLine("5. Refresco (2€)");
                Console.WriteLine("6. Postre (3€)");
                Console.WriteLine("7. Salir");
                Console.Write("¿Qué desea añadir?(elija el número del producto)");

                string input = Console.ReadLine();
                int eleccion = Convert.ToInt32(input);
                switch (eleccion)
                {
                    case 1:
                        menu.AddHamburguesaSencilla();
                        break;
                    case 2:
                        menu.AddHamburguesaQueso();
                        break;
                    case 3:
                        menu.AddHamburguesaEspecial();
                        break;
                    case 4:
                        menu.AddPatatasFritas();
                        break;
                    case 5:
                        menu.AddRefresco();
                        break;
                    case 6:
                        menu.AddPostre();
                        break;
                    case 7:
                        continuar = "no";
                        break;
                    default:
                        break;
                }


            }

            Console.WriteLine("El total de su pedido es de: {0}", menu.CalcularTotal());


            Console.Read();
        }
    }
}
//EJERCICIO 3
//El siguiente es el menú de un restaurante de hamburguesas.Elabora un sistema capaz de leer la cantidad de cada alimento y calcular la cuenta total de cada pedido de 
//acuerdo al precio de cada uno de los productos.
//Hamburguesa sencilla (5€)
//Hamburguesa con queso(8€)
//Hamburguesa especial(10€)
//Patatas fritas(3€)
//Refresco(2€)
//Postre(3€)
