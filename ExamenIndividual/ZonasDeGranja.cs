using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    class ZonasDeGranja : IAumprecio
    {
        //Cada que se compra, aumenta 10.

        int zonacampoprec;

        public ZonasDeGranja(int zonacampoprec)
        {
            this.zonacampoprec = zonacampoprec;
        }

        public float PrecioAumentando()
        {
            return zonacampoprec + 10f;
        }
    }
}
