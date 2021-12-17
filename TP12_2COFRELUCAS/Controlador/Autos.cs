using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TP12_2COFRELUCAS.Controlador
{
    class Pedidos
    {
       
        public Pedidos()
        {
            string path = "Pedidos.txt";
            if (File.Exists(path))
            {
                List<Modelo.Pedidos> ListaPedidos = new List<Modelo.Pedidos>(Convert.ToInt32(path));
            }
            else
            {
                MessageBox.Show("No se pudo leer el archivo Pedidos.txt");
            }
        }


    }
}
