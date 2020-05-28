using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public partial class UsuarioNormal : UserControl
    {
        private String User="";
        public UsuarioNormal(String u)
        {
            InitializeComponent();
            User=u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text.Equals(""))
                {
                    MessageBox.Show("No puede dejar campos vacíos!");
                }
                else{
                    var idU = ConectionBD.ExecuteQuery($"SELECT idUser FROM APPUSER " +
                             $"WHERE username='{User}'");
                    var idUs = idU.Rows[0];
                    int idUser = Convert.ToInt32(idUs[0].ToString());
                    ConectionBD.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                                                        $"VALUES('{idUser}','{textBox1.Text}')");
                    MessageBox.Show("Dirección agregada con éxito!");
                    //Actualizando Datos
                    UsuarioNormal_Load(sender,e);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               if(textBox6.Text.Equals(""))
               {
                  MessageBox.Show("No puede dejar campos vacíos!");
               }
               else
               {
                  var idA = ConectionBD.ExecuteQuery($"SELECT idAddress FROM ADDRESS " +
                  $"WHERE address='{comboBox3.SelectedItem}'");
                  var idAs = idA.Rows[0];
                  int idAddress = Convert.ToInt32(idAs[0].ToString());
                  ConectionBD.ExecuteNonQuery($"UPDATE ADDRESS SET address = '{textBox6.Text}' "+
                  $"WHERE idAddress={idAddress}");
                  MessageBox.Show("Dirección modificada con éxito!");
                  //Actualizando Datos
                  UsuarioNormal_Load(sender,e);
               }
            }
            
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var idA = ConectionBD.ExecuteQuery($"SELECT idAddress FROM ADDRESS " +
                                                   $"WHERE address='{comboBox1.SelectedItem}'");
                var idAs = idA.Rows[0];
                int idAddress = Convert.ToInt32(idAs[0].ToString());
                ConectionBD.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress={idAddress}");
                MessageBox.Show("Dirección eliminada con éxito!");
                //Actualizando Datos
                UsuarioNormal_Load(sender,e);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }
         
        }

        private void UsuarioNormal_Load(object sender, EventArgs e)
        {
            try
            {
                var idU = ConectionBD.ExecuteQuery($"SELECT idUser FROM APPUSER " +
                                            $"WHERE username='{User}'");
                var idUs = idU.Rows[0];
                int idUser = Convert.ToInt32(idUs[0].ToString());
                
                
                var address = ConectionBD.ExecuteQuery($"SELECT address FROM ADDRESS " +
                                            $"WHERE idUser='{idUser}'");
                
                                                
                var dt=ConectionBD.ExecuteQuery($"SELECT address FROM ADDRESS " +
                                            $"WHERE idUser='{idUser}'");
               
                                                
                var producto = ConectionBD.ExecuteQuery("SELECT name FROM PRODUCT");
               
                     
                var orden = ConectionBD.ExecuteQuery($"SELECT ao.idOrder " +
                                                  $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                  $"WHERE ao.idProduct = pr.idProduct " +
                                                  $"AND ao.idAddress = ad.idAddress " +
                                                  $"AND ad.idUser = au.idUser " +
                                                  $"AND au.idUser = '{idUser}'");
                                                 
                                                  
                var dt2 = ConectionBD.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                                   $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                   $"WHERE ao.idProduct = pr.idProduct " +
                                                   $"AND ao.idAddress = ad.idAddress " +
                                                   $"AND ad.idUser = au.idUser " +
                                                   $"AND au.idUser = '{idUser}'");
                                                                          
                var addressCombo = new List<String>();
                var productoCombo = new List<String>();
                var ordenCombo = new List<String>();
                
                            
                foreach (DataRow row in address.Rows)
                {
                   addressCombo.Add(row[0].ToString());
                }
                foreach (DataRow row in producto.Rows)
                {
                   productoCombo.Add(row[0].ToString());
                }
                foreach (DataRow row in orden.Rows)
                {
                  ordenCombo.Add(row[0].ToString());
                }

                comboBox3.DataSource = addressCombo;
                comboBox1.DataSource = addressCombo;
                comboBox2.DataSource = productoCombo;
                comboBox4.DataSource = addressCombo;
                comboBox5.DataSource = ordenCombo;
                dataGridView1.DataSource=dt;
                dataGridView2.DataSource = dt2;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }    
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               DateTime date=DateTime.Now;
            
               var idP = ConectionBD.ExecuteQuery($"SELECT idProduct FROM PRODUCT "+
                                     $"WHERE name = '{comboBox2.SelectedItem}'");
               var idProd = idP.Rows[0];
               int idProduct = Convert.ToInt32(idProd[0].ToString());        
            
               var idA = ConectionBD.ExecuteQuery($"SELECT idAddress FROM ADDRESS "+
                                     $"WHERE address = '{comboBox4.SelectedItem}'");
               var idAd = idA.Rows[0];
               int idAddress = Convert.ToInt32(idAd[0].ToString());    
                 
               ConectionBD.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                                      $"VALUES('{date}',{idProduct},'{idAddress}')");
                         
               MessageBox.Show("Orden realizada con éxito!");  
               //Actualizando Datos
               UsuarioNormal_Load(sender,e);          
            }
            catch(Exception exception)
            {
               MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            try{
            ConectionBD.ExecuteNonQuery($"DELETE FROM APPORDER WHERE "+
                            $"idOrder={Convert.ToInt32(comboBox5.SelectedItem)}");
            MessageBox.Show("Orden cancelada con éxito!");                  
            //Actualizando Datos
            UsuarioNormal_Load(sender,e);
            }
            catch(Exception exception)
            {
            MessageBox.Show("Ocurrió un error! Vuelva a intentarlo");
            }
        }
    }
}