using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class AnimProduct
    {
        private string nombre;
        private float cantidadproducto;

        public AnimProduct(string nombre, float cantidadproducto)
        {
            this.nombre = nombre;
            this.cantidadproducto = cantidadproducto;
        }

        public float GetCantProducto()
        {
            return cantidadproducto;
        }

        public string GetName()
        {
            return nombre;
        }
    }
}
