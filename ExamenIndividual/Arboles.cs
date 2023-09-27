using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class Arboles : Plantas
    {

        private Frutos frutos;

        public Arboles(string nombre, float tiempovida, int precioinicial, int preciofinal, Frutos frutos) 
            :base("Arboles", tiempovida, precioinicial, preciofinal)
        {
            this.nombre = nombre;
            this.frutos = frutos;
        }

        //Los arboles deberian vivir más.
        public float RestarVida()
        {
            return tiempovida / 4;
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
