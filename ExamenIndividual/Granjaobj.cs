using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class Granjaobj
    {

        //Contenido de la granja: plantas y animales

        protected string nombre;
        protected int precioinicial;
        protected int preciofinal;

        protected Granjaobj(string nombre, int precioinicial, int preciofinal)
        {
            this.nombre = nombre;
            this.precioinicial = precioinicial;
            this.preciofinal = preciofinal;

        }
        public string GetName()
        {
            return nombre;
        }
    }
}
