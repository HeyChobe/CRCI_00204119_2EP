using System.Data;
using System.Collections.Generic;
using Preparcial.Modelo;
using System;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorUsuario
    {
        public static List<Usuario> GetUsuarios()
        {
            var usuarios = new List<Usuario>();
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            foreach(DataRow dr in tableUsuarios.Rows)
            {
                usuarios.Add(new Usuario
                    (
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        Convert.ToBoolean(dr[3].ToString())
                    )
                );
            }

            return usuarios;
        }

        public static DataTable GetUsuariosTable()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }

        public static void ActualizarContrasena(string idUsuario, string nueva)
        {
            try
            {
                ConexionBD.EjecutarComando($"UPDATE USUARIO SET contrasenia = '{nueva}' " +
                    $"WHERE idUsuario = {idUsuario}");

                MessageBox.Show("Se ha actualizado la contrasena");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        public static void CrearUsuario(string usuario)
        {
            try
            {
                //CORRECCIÓN: Se cambió nombreUsuario por nombre
                ConexionBD.EjecutarComando("INSERT INTO USUARIO(nombre, contrasenia, tipo)" +
                    $" VALUES('{usuario}', '{usuario}', false)");

                MessageBox.Show("Se ha agregado el nuevo usuario, contrasenia igual al nombre");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
