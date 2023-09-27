using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class Animales : Granjaobj
    {
        //•Cada animal debe tener un nombre, un tiempo de vida, cuanta carne/productos (leche/lana/huevos) te puede dar, el precio del anima y el precio de sus productos finales

        protected float tiempovida;
        protected Animales(string nombre, float tiempovida, int precioinicial, int preciofinal) : base("Animal", precioinicial, preciofinal)
        {
            this.tiempovida = tiempovida;
        }

        public string GetName()
        {
            return nombre;
        }


    }
}
