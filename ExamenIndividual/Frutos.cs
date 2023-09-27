using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class Frutos
    {
        private string nombre;
        private float cantidaddeproducto;

        public Frutos(string nombre, float cantidaddeproducto)
        {
            this.nombre = nombre;
            this.cantidaddeproducto = cantidaddeproducto;
        }

        public float GetCantProducto()
        {
            return cantidaddeproducto;
        }

        public string GetName()
        {
            return nombre;
        }
}
}
