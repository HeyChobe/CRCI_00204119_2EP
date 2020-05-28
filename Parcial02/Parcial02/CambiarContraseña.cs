using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
            BackColor=ColorTranslator.FromHtml("#3e1b5a");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("") ||
                    textBox2.Text.Equals(""))
                {
                    MessageBox.Show("No dejes espacios en blancos");
                }
                else
                {
                    var idU = ConectionBD.ExecuteQuery($"SELECT idUser FROM APPUSER " +
                                                       $"WHERE username='{textBox2.Text}'");
                    var idUs = idU.Rows[0];
                    int idUser = Convert.ToInt32(idUs[0].ToString());
                    ConectionBD.ExecuteNonQuery($"UPDATE APPUSER SET password = '{textBox1.Text}' " +
                                                $"WHERE idUser='{idUser}'");
                    MessageBox.Show("Has modificado la contraseña!");
                    Login win=new Login();
                    win.Show();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }
        }

        private void CambiarContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login win=new Login();
            win.Show();
            this.Hide();
        }
    }
}