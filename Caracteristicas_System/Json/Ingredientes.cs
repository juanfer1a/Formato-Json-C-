using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caracteristicas_System.Json
{
    public class Ingredientes
    {
        string nombre;
        string unidad;
        double cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Unidad { get => unidad; set => unidad = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        //public string ingrediente;
        //public string ingrediente1;
        //public string ingrediente2;
        //public string ingrediente3;
        //public string ingrediente4;
        //public string ingrediente5;
        //public string ingrediente6;
    }
}
