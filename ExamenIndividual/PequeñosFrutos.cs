﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class PequeñosFrutos : Plantas
    {

        private Frutos frutos;

        public PequeñosFrutos(string nombre, float tiempovida, int precioinicial, int preciofinal, Frutos frutos) : base("Frutos Pequeños", tiempovida, precioinicial, preciofinal)
        {
            this.nombre = nombre;
            this.frutos = frutos;

        }

        public float RestarVida()
        {
            return tiempovida;
        }

        public float GetCantProducto()
        {
            return GetCantProducto();
        }

        public string Data()
        {
            return $"{nombre}/ tiempo de vida: {tiempovida} / precio inicial: {precioinicial} / precio final: {preciofinal}";
        }

    }
}
