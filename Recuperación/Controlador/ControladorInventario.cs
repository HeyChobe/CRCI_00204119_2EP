using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorInventario
    {
        // Metodo encargado de devolver un DataTable con todos los elementos del inventario
        public static DataTable GetProductosTable()
        {
            DataTable productos = null;

            // Solamente la consulta y conexion a la BD van en el try, ya que lo demas no puede ocasionar excepcion
            try
            {
                productos = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo que devuelve los productos en formato de List
        public static List<Inventario> GetProductos()
        {
            // Declaracion de lista y DataTable
            var productos = new List<Inventario>();
            DataTable dt = null;

            try
            {
                // Consulta para llenar el DataTable
                dt = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");

                // Por cada fila del DataTable, crear un nuevo usuario anadiendolo a la lista
                foreach(DataRow dr in dt.Rows)
                {
                    productos.Add(new Inventario
                        (
                            dr[0].ToString(),
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString(), 
                            dr[4].ToString()
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo para anadir productos
        public static void AnadirProducto(string nombre, string descripcion, string precio, string stock)
        {
            try
            {
                //CORRECCIÓN: Se cambio nombreArtículo por nombreArt
                ConexionBD.EjecutarComando("INSERT INTO INVENTARIO(nombreArt, descripcion, precio, stock)" +
                    $" VALUES('{nombre}', '{descripcion}', {precio}, {stock})");

                MessageBox.Show("Se ha agregado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Metodo para eliminar productos
        public static void EliminarProducto(string id)
        {
            try
            {
                ConexionBD.EjecutarComando($"DELETE FROM INVENTARIO WHERE idArticulo = {id}");

                MessageBox.Show("Se ha eliminado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Metodo para actualizar stock de un producto
        public static void ActualizarProducto(string id, string stock)
        {
            try
            {
                ConexionBD.EjecutarComando($"UPDATE INVENTARIO SET stock = {stock} WHERE idArticulo = {id}");

                MessageBox.Show("Se ha actualizado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
