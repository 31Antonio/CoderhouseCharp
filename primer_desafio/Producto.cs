using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_desafio_de_la_clase
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        private float precioVenta { get; set; }
        private int stock { get; set; }
        private int idUsuario { get; set; }


        public Producto(int id, string descripcion, float precioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }
    }
}
