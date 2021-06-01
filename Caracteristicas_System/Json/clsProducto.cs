using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caracteristicas_System.Json
{
    public class clsProducto
    {
        
        public string nombre;
        public int precio;
        public List<Ingredientes> ingredientes = new List<Ingredientes>();

        public clsProducto() { 
        
        }
   
    }
}
