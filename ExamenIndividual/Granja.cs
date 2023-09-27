﻿using System;
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


        }
    }
}
