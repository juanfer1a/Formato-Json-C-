using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace Caracteristicas_System
{
    class clsButtons
    {
        private int y = 50;
        private int conteo = 0;
        clsConexion cn = new clsConexion();

        public clsButtons() 
        { 
        
        }

        //Creamos los botones de forma dinamica
        public void Botones(Button temp, string ProductoBuscar)
        {
            temp.Height = 150;
            temp.Width = 100;
            temp.Location = new Point(50, y);
            //Aumentamos la y para la distancia entre los botones
            y += 50;
            temp.Text = cn.ConsultarProducto(ProductoBuscar).ToString();

        }


    }
}
