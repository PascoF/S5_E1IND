using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class PequeñosFrutos : Plantas
    {
        public PequeñosFrutos(string nombre, float frutos, float tiempovida, int precioinicial, int preciofinal) : base("Manzano", frutos, tiempovida, precioinicial, preciofinal)
        {
            this.nombre = nombre;
        }

        public float RestarVida()
        {
            return tiempovida;
        }

        public string Data()
        {
            return $"{nombre}/ tiempo de vida: {tiempovida} / precio inicial: {precioinicial} / precio final: {preciofinal}";
        }

    }
}
