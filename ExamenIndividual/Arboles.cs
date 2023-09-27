using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class Arboles : Plantas
    {
        public Arboles(string nombre, float frutos, float tiempovida, int precioinicial, int preciofinal) :base("Frutos Pequeños", frutos, tiempovida, precioinicial, preciofinal)
        {
            this.nombre = nombre;
        }

        //Los arboles deberian vivir más.
        public float RestarVida()
        {
            return tiempovida / 4;
        }

        public string Data()
        {
            return $"{nombre}/ tiempo de vida: {tiempovida} / precio inicial: {precioinicial} / precio final: {preciofinal}";
        }

    }
}
