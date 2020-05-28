using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Login : Form
    {
        
        public Login()
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
                    String User = textBox2.Text;
                    
                    var pass = ConectionBD.ExecuteQuery($"SELECT password FROM APPUSER " +
                                                        $"WHERE username = '{textBox2.Text}'");
                    var passw = pass.Rows[0];
                    String passWord = passw[0].ToString();

                    if (textBox1.Text.Equals(passWord))
                    {
                        var ad = ConectionBD.ExecuteQuery($"SELECT userType FROM APPUSER " +
                                                          $"WHERE username = '{textBox2.Text}'");
                        var adm = ad.Rows[0];
                        bool admin = Convert.ToBoolean(adm[0].ToString());
                         
                        MessageBox.Show("Bienvenido "+textBox2.Text);
                        Form1 win= new Form1(User,admin);
                        win.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CambiarContraseña win = new CambiarContraseña();
            win.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}