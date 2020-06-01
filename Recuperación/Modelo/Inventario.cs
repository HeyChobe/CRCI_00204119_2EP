using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
        //CORRECCIÓN: Se hicieron públicos estos cinco atributos par poder acceder a ellos
        public string idArticulo { get; }
        public string producto { get; }
        public string descripcion { get; }
        public string precio { get; }
        public string stock { get; }

        public Inventario(string idArticulo, string producto, string descripcion, string precio, string stock)
        {
            this.idArticulo = idArticulo;
            this.producto = producto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
