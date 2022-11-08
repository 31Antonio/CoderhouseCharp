using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_desafio_de_la_Clase
{
    internal class ProductoVendido
    {
        public int id { get; set; }
        public int idProducto { get; set; }
        public int stock { get; set; }
        public int idVenta { get; set; }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }
    }
}
