using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caracteristicas_System.Json
{
    public class clsProducto
    {

        private string nombre;
        private int precio;
        private List<Ingredientes> ingredientes = new List<Ingredientes>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public List<Ingredientes> Ingredientes { get => ingredientes; set => ingredientes = value; }

        public clsProducto() 
        {
            this.nombre = "";
            this.precio = 0;
            this.ingredientes = null;

        }

        public clsProducto(string nombre, int precio, List<Ingredientes> ingredientes)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.ingredientes = ingredientes;
        }
    }
}
