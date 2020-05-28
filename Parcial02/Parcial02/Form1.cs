using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
  
  public partial class Form1 : Form
  {
    private UserControl current;
    private String Admin="";
    public Form1(String u, bool a)
    {
      InitializeComponent();
      BackColor=ColorTranslator.FromHtml("#3e1b5a");
      
      if(a)
      {
        label1.Text = u + "[Admin]";
        current= new Administrador();
        tableLayoutPanel1.Controls.Add(current, 0, 1);
        tableLayoutPanel1.SetColumnSpan(current,2);
      }
      else
      {
        label1.Text = u + "[Usuario]";
        current= new UsuarioNormal(u);
        tableLayoutPanel1.Controls.Add(current, 0, 1);
        tableLayoutPanel1.SetColumnSpan(current,2);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Login win = new Login();
      win.Show();
      this.Hide();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}
