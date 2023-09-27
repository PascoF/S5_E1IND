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

            List<Granjaobj> Granjaobjec = new List<Granjaobj>();

            //Lista
            Frutos Manzana = new Frutos("Manzana", 3);
            Frutos Naranja = new Frutos("Naranja", 4);
            Frutos Fresas = new Frutos("Frutos", 9);
            Frutos Cerezas = new Cerezas("Cerezas", 13);
            AnimProduct Carne = new Carne("Carne", 2);
            Arboles Manzanos = new Arboles("Manzano", 12, 14, 35, Manzana);
            Arboles Naranjos = new Arboles("Naranjo", 15, 16, 24, Naranja);
            PequeñosFrutos FresasPlanta = new PequeñosFrutos("Fresas", 4, 6, 23, Fresas);
            PequeñosFrutos Cerezas = new PequeñosFrutos("Cerezas", 7, 4, 15, Cerezas);
            AnimalGrande Vaca = new AnimalGrande("Vaca", 9, 45, 60, Carne);

            //Interfaz dinero

            Console.WriteLine("Para comenzar, ¿Con cuanto dinero vas a comenzar?");

            string y = Console.ReadLine();
            float dinero;

            if (y! = "")
            {
                dinero = float.Parse(Console.ReadLine());
                if(dinero >= 0 && dinero <= 250)
                {
                    Acciones();
                }
                else
                {
                    Console.WriteLine("Cantidad no valida.");
                }
            }
            else
            {
                Console.WriteLine("Error, debe insertar un monto.");

                Acciones();

            }

        }
      
    }

    static void GranjaVirtual(List<Granjaobj> Granjaobj)
    {

        Console.WriteLine("\nBienvenido a la granja virtual, ¿Que va a hacer?")

        Console.WriteLine("1. Comprar terreno (100)");
        Console.WriteLine("2. Comprar semillas");
        Console.WriteLine("3. Comprar animales");
        Console.WriteLine("4. Revisar granja");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                // Comprar terreno (100)
                break;

            case "2":
                //Comprar semillas
               
                break;

            case "3":
                //Comprar animales"
                break;
            case "4":
                //Revisar granja
                Console.WriteLine("Esta es su granja, ¿que va a hacer?(Elija un numero)");

                Console.WriteLine("1. Coseshar plantas.");
                Console.WriteLine("2. Matar animales");
                Console.WriteLine("3. Ver inventario de granja.");
                Console.WriteLine("4. Pasar turno.");
                Console.WriteLine("5. Vender productos.");
                Console.WriteLine("6. Salir.");
                string z = Console.ReadLine();
                float elecc;

                if (x == "1")
                {
                    Console.WriteLine("¿Que planta va a cosechar?")
                        string p = Console.ReadLine();

                    //mostrar inventario de semillas

                    return;
                    //prov.
                }

                if (x == "2")
                {
                    Console.WriteLine("Inventario completo:")

                    int i = 1;
                    foreach (Granjaobj Granjaobj in Granjaobjec)
                    {

                        Console.WriteLine(i + "." + Granjaobj.GetName());
                        i++;
                    }
                }
        }
                if (x == "3")
                {

                }
                if (x == "4")
                {
                    Console.WriteLine("Pasando de turno...")
                        //Programar el paso de turnos
                        return;
                }
                if (x == "5")
                {
            Console.WriteLine("¿Que producto va a vender?")
                int i = 1;
            foreach (Granjaobj Granjaobj in Granjaobjec)
            {
                Console.WriteLine(i + "." + Granjaobj.GetName());
                i++;
            }
        }

        if (x == "6")
        {
            Environment.Exit(0);
        }


        break;

        }
    }
}
