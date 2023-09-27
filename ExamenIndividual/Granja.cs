using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class Granja
    {
        public void Acciones()
        {

            List<Granjaobj> granjaobj = new List<Granjaobj>();

            //Listaproductos
            Frutos Manzana = new Frutos("Manzana", 3);
            Frutos Naranja = new Frutos("Naranja", 4);
            Frutos Fresas = new Frutos("Frutos", 9);
            Frutos Cerezas = new Frutos("Cerezas", 13);
            AnimProduct Carne = new AnimProduct("Carne", 2);

            //ListaAnimalesPlantas
            Arboles Manzanos = new Arboles("Manzano", 12, 14, 35, Manzana);
            Arboles Naranjos = new Arboles("Naranjo", 15, 16, 24, Naranja);
            PequeñosFrutos FresasPlanta = new PequeñosFrutos("Fresas", 4, 6, 23, Fresas);
            PequeñosFrutos Cerezo = new PequeñosFrutos("Cerezo", 7, 4, 15, Cerezas);
            AnimalGrande Vaca = new AnimalGrande("Vaca", 9, 45, 60, Carne);

            //Interfaz

            String nombre;
            float dinero;
            Console.WriteLine("Para comenzar, inserte su nombre");
            nombre = Console.ReadLine();

            if (nombre != "")
            {
                Console.WriteLine("¿Con cuanto dinero va a comenzar?");
                dinero = float.Parse(Console.ReadLine());

                if (dinero >= 0 && dinero <= 250)
                {
                    //programar dinero
                    Console.WriteLine("Listo.");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("1. Comenzar partida");
                        Console.WriteLine("2. Salir de la partida");

                        string option;
                        option = Console.ReadLine();

                        switch (option)
                        {
                            case "1":
                                GranjaVirtual(granjaobj);
                                break;

                            case "2":
                                Environment.Exit(0);
                                break;

                        }
                    }

                }
                else
                {
                    Console.WriteLine("Error... Cantidad no valida.");
                    Acciones();
                }
            }


        }

        static void GranjaVirtual(List<Granjaobj> granjaobj)
        {

            Console.WriteLine("\nBienvenido a la granja virtual, ¿Que va a hacer?");

            Console.WriteLine("1. Comprar terreno (100)");
            Console.WriteLine("2. Comprar semillas");
            Console.WriteLine("3. Comprar animales");
            Console.WriteLine("4. Ver inventario.");
            Console.WriteLine("5. Volver");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Cada trozo de terreno sale 100 monedas.");
                    //programar terrenos
                    GranjaVirtual(granjaobj);
                    break;

                case "2":
                    Console.WriteLine("Las semillas en la tienda son:");
                    //Comprar semillas
                    GranjaVirtual(granjaobj);
                    break;

                case "3":
                    Console.WriteLine("Los animales en la tienda son:");

                    //Comprar animales"
                    GranjaVirtual(granjaobj);
                    break;

                case "4":

                    Console.WriteLine("Este es su inventario:");
                    for (int i = 0; i < granjaobj.Count; i++)
                    {
                        Console.WriteLine($"{granjaobj[i].GetName()}");
                    }
                    GranjaVirtual(granjaobj);
                    break;

                case "5":

                    return;



            }
        }

    }

}



