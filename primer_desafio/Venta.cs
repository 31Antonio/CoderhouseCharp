using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_desafio_de_la_clase
{
    internal class Venta
    {
        public int id { get; set; }
        public string comentarios { get; set; }

        public Venta(int id, string comentarios)
        {
            this.id = id;
            this.comentarios = comentarios;
        }
    }
}
