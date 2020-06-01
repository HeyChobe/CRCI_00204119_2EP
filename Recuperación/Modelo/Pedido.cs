using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Pedido
    {
        public string idPedido { get; }
        public string idUsuario { get; }
        public string idArticulo { get; }
        public string cantidad { get; }

        public Pedido(string idPedido, string idUsuario, string idArticulo, string cantidad)
        {
            this.idPedido = idPedido;
            this.idUsuario = idUsuario;
            this.idArticulo = idArticulo;
            this.cantidad = cantidad;
        }
    }
}
