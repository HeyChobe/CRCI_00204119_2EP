using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            //CORRECCIÓN: Se cambió la ruta de acceso a la imagen para que cargue en el Form Login
            pictureBox1.BackgroundImage = Image.FromFile("C:/Users/Ely Montes/Desktop/Preparcial/Recursos/UCA.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            ActualizarControlers();
        }

        private void ActualizarControlers()
        {
            comboBox1.ValueMember = "Contrasena";
            comboBox1.DataSource = ControladorUsuario.GetUsuarios();
            comboBox1.DisplayMember = "NombreUsuario";
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
            {       
                var obtenerUsuario = (Usuario)comboBox1.SelectedItem;

                ActualizarControlers();
                
                ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
                        txtNewPassword.Text);
            }
            else
                MessageBox.Show("Contrasena actual incorrecta");
        }
    }
}
