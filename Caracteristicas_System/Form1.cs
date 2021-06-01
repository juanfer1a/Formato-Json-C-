using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
//Para poder usuar los Json(También descargar el Nuget)
using Newtonsoft.Json;
using System.IO;

namespace Caracteristicas_System
{
    public partial class Form1 : Form
    {
        private static string documento = Application.StartupPath + @"\Productos2.json";


        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;

        }


        //Creacion del documento. Json    


        private void Btn_Especificaciones_Click(object sender, EventArgs e)
        {
            var productos = GetProductos();
            SerializarJsonDocumento(productos);
        }

        public static void SerializarJsonDocumento(List<Json.clsProducto> productos)
        {
            string productosCreados = JsonConvert.SerializeObject(productos.ToArray(), Formatting.Indented);

            File.WriteAllText(documento, productosCreados);

        }

        //Creación del Json(mirar la carpeta en el explorador de soluciones)
        public static List<Json.clsProducto> GetProductos()
        {

            List<Json.clsProducto> productos = new List<Json.clsProducto>
            {
                new Json.clsProducto
                {
                    Nombre = "Andres",
                    Precio = 456,
                    Ingredientes = new List<Json.Ingredientes>
                    {
                         new Json.Ingredientes {Nombre="pan bimbo",Unidad = "Unidad",Cantidad = 1 },
                         new Json.Ingredientes { Nombre = "Carne", Unidad = "Unidad", Cantidad = 1 }

                    }

                }

            };

            return productos;
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }



        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uno");

            //listBox1.Items.Add("Dos");
            //listBox1.Items.Add("three");
            //listBox1.Items.Add("four");
            //listBox1.Items.Add("five");
            //listBox1.Items.Add("sex");

            //label1.Text=listBox1.Items.Count();

            //if (txtName.Text != "")
            //{

            //    try
            //    {
            //        //Hacemos un query a la base de datos
            //        string producto = "SELECT strNombre FROM tblEmpleado WHERE idCedula ='" + txtName.Text + "'";

            //        //Verificamos si se encuentra tal dato en la DB
            //        if (cn.ConsultarProducto(producto) == null)
            //        {

            //            MessageBox.Show("Tal producto no existe");
            //        }
            //        else
            //        {
            //            //Creamos el objeto boton
            //            Button temp = new Button();
            //            //Enviamos el objeto Button
            //            btns.Botones(temp,producto);

            //            //Hacemos visible el objeto en la consola

            //            Controls.Add(cn.ConectarBoton(txtName.Text));


            //            MessageBox.Show(""+botones);


            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("No se genero el botón adecuadamente " + ex.Message);
            //    } 
            //}
            //else
            //{
            //    MessageBox.Show("Favor llenar el campo");
            //}

            //LISTBOX
            //  string  name = "SELECT * FROM tblEmpleado WHERE idCedula ='" + txtName.Text + "'";
            //  listBox1.Items.Add(cn.ConsultarProducto(name));
            // Add parts to the list.


        }
        public void contarItems()
        {

        }
    }
}
