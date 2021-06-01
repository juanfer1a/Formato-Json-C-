using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
namespace Caracteristicas_System
{
    public class clsinventario
    {
        public object myVideoObject;
        string Nombre;
        int precio;
        List<string> ingredientes;

        public clsinventario()
        {

        }

        public clsinventario(object myVideo)
        {
            myVideoObject = myVideo;
        }

       

    }
}
