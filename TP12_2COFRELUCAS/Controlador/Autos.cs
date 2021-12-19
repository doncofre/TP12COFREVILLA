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
                 Modelo.Pedidos Pedidos = new Modelo.Pedidos(path); // no se por que hubo error

                List<Modelo.Pedidos> sublist = new List<Modelo.Pedidos>();
                using (Modelo.DBContainer db = new Modelo.DBContainer())
                {
                    var oLista = from a in db.PedidosDB select a;
                    foreach ( )
                    


                    foreach (Modelo.Pedidos pe in sublist)
                    {
                        db.Pedidos.Add(pe);
                    }
                }
                    




            }
            else
            {
                MessageBox.Show("No se pudo leer el archivo Pedidos.txt");
            }
        }


    }

    class Stock
    {
        public Stock()
        {
            string path = "Stock.txt";
            if (File.Exists(path))
            {
                Modelo.Stock Pedidos = new Modelo.Stock(path); // no se por que hubo error
            }
            else
            {
                MessageBox.Show("No se pudo leer el archivo Pedidos.txt");
            }
        }
    }
    class StockPiezas
    {
        public StockPiezas()
        {
            string path = "StockPiezas.txt";
            if (File.Exists(path))
            {
                Modelo.StockPiezas Pedidos = new Modelo.StockPiezas(path); // no se por que hubo error
            }
            else
            {
                MessageBox.Show("No se pudo leer el archivo Pedidos.txt");
            }
        }
    }
    class Composicion
    {
        public Composicion()
        {
            string path = "Composicion.txt";
            if (File.Exists(path))
            {
                Modelo.Composicion Pedidos = new Modelo.Composicion(path); // no se por que hubo error
            }
            else
            {
                MessageBox.Show("No se pudo leer el archivo Pedidos.txt");
            }
        }
    }
}
