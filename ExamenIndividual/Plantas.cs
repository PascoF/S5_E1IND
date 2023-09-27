using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class Plantas : Granjaobj
    {
        //•Cada planta debe tener un nombre, un tiempo de vida, cuántos frutos/verduras te puede dar, el valor de la semilla y el valor del producto cuando crece

        protected float tiempovida;
        protected float frutos;
        protected Plantas(string nombre, float frutos, float tiempovida, int precioinicial, int preciofinal) : base("Planta", precioinicial, preciofinal)
        {
            this.tiempovida = tiempovida;
            this.frutos = frutos;
        }

        public string GetName()
        {
            return nombre;
        }

        //•Una vez que la planta se cosecha, esta se destruye y te da sus productos




    }
}