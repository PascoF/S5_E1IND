using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class AnimalGrande : Animales
    {

        private AnimProduct AnimProduct;

        protected AnimalGrande(string nombre, AnimProduct animProduct, float tiempovida, int precioinicial, int preciofinal) : base("Animales grandes", tiempovida, precioinicial, preciofinal)
        {
            this.nombre = nombre;
            this.AnimProduct = AnimProduct;

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