using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Caracteristicas_System
{
    class clsConexion
    {
        string conecxionSting = ConfigurationManager.ConnectionStrings["Caracteristicas_System.Properties.Settings.db_a74d2a_projectfinalConnectionString"].ToString();

        //Metodo para ejecutar las consultas en la DB
        public void conectarComando(string comando)
        {
            //Conectamos con el servidos
            //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conectar);
            
            try
            {
                SqlConnection conexion = new SqlConnection(conecxionSting);
                //Abrimos la conexión con la DB
                conexion.Open();
                MessageBox.Show("Bien");
                //Ejecutamos los comandos
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                
                //Cerramos la conexión con la DB
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("mal" + ex.Message);               
            }

        }

        //Creamos metodo para consultar los productos creados
        public string ConsultarProducto(string comando)
        {
            
            SqlConnection conexion = new SqlConnection(conecxionSting);
            try
            {
                
                //Abrimos la conexión con la DB
                conexion.Open();
              // MessageBox.Show("Bien");
                //Ejecutamos los comandos
                SqlCommand cmd = new SqlCommand(comando, conexion);
             // cmd.ExecuteNonQuery();
                SqlDataReader reg = cmd.ExecuteReader();

                //Verificamos si existe campo en la DB
                if (reg.Read())
                {
                    return reg["strNombre"].ToString();
                }
                else
                {
                    return null;
                }
                //Cerramos la conexión con la DB
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("mal" + ex.Message);
                return null;
            }

            
        }

        public Button ConectarBoton(string comando)
        {
           
            SqlConnection conexion = new SqlConnection(conecxionSting);
            SqlCommand cmd = new SqlCommand(comando, conexion);

            //Estamos tomando la conexión y la consultada de la variable "traer todo"
            SqlDataAdapter data = new SqlDataAdapter(cmd);

            //Representación de una tabla en memoria 
            Button table = new Button();

            //Poblamos tabla con los datos consignados en la data 
            // data.Fill(table);

            return table;
        }

        public void MostrarTabla(string comando, DataGridView datagrid)
        {
            //Conectamos con el servidor
            
            SqlConnection conexion = new SqlConnection(conecxionSting);

            SqlCommand cmd = new SqlCommand(comando, conexion);
            //Estamos tomando la conexión y la consultada de la variable "traer todo"
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            //Representación de una tabla en memoria 
            DataTable tabla = new DataTable();
            //llenamos tabla con los datos consigandos en la data 
            data.Fill(tabla);
            //Mostramos en el datagrid
            datagrid.DataSource = tabla;

        }
    }
}
