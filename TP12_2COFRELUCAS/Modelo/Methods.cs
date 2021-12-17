using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TP12_2COFRELUCAS.Modelo
{

    class Methods
    {
        public static bool DevuelveEntero(string numero)
        {
            int num = -1;
            bool verdad = Int32.TryParse(numero, out num);
            if (verdad == true)
            {
                if (num >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool DevuelveEntero(string numero, string numero2)
        {
            int num = -1;
            int num2 = -1;
            bool verdad = Int32.TryParse(numero, out num);
            bool verdad2 = Int32.TryParse(numero2, out num2);
            if (verdad = true && verdad2 == true)
            {
                if (num >= 0 && num2 >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool DevuelveEntero(string numero, string numero2, string numero3)
        {
            int num = -1;
            int num2 = -1;
            int num3 = -1;
            bool verdad = Int32.TryParse(numero, out num);
            bool verdad2 = Int32.TryParse(numero2, out num2);
            bool verdad3 = Int32.TryParse(numero3, out num3);
            if (verdad = true && verdad2 == true && verdad3 == true)
            {
                if (num >= 0 && num2 >= 0 && num3 >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void CargarModelo(Modelo.Pedidos objP, Modelo.Stock objS, Modelo.StockPiezas objSP, Modelo.Composicion objC)
        {
            CargarPedidos(objP);
            CargarStock(objS);
            CargarStockPiezas(objSP);
            CargarComposicion(objC);
        }
        public static void CargarPedidos(Modelo.Pedidos obj)
        {
            string path = "Pedidos.txt";
            if (File.Exists(path))
            {
                obj = new Modelo.Pedidos(path);
                if (obj.verdad2 == false)
                {
                    MessageBox.Show("Algunos datos de pedidos no se pudieron cargar, Revise el archivo");
                }
            }
            else
            {
                MessageBox.Show("No hay archivo de pedidos para recopilar informacion");
            }
        }
        public static void CargarStock(Modelo.Stock obj)
        {
            string path = "Stock.txt";
            if (File.Exists(path))
            {
                obj = new Modelo.Stock(path);
                if (obj.verdad2 == false)
                {
                    MessageBox.Show("Algunos datos de Stock no se pudieron cargar, Revise el archivo");
                }
            }
            else
            {
                MessageBox.Show("No hay archivo de Stock para recopilar informacion");
            }
        }
        public static void CargarStockPiezas(Modelo.StockPiezas obj)
        {
            string path = "StockPiezas.txt";
            if (File.Exists(path))
            {
                obj = new Modelo.StockPiezas(path);
                if (obj.verdad2 == false)
                {
                    MessageBox.Show("Algunos datos de StockPiezas no se pudieron cargar, Revise el archivo");
                }
            }
            else
            {
                MessageBox.Show("No hay archivo de Stock para recopilar informacion");
            }


        }
        public static void CargarComposicion(Modelo.Composicion obj)
        {
            string path = "Composicion.txt";
            if (File.Exists(path))
            {
                obj = new Modelo.Composicion(path);
                if (obj.verdad2 == false)
                {
                    MessageBox.Show("Algunos datos de Composicion no se pudieron cargar, Revise el archivo");
                }
            }
            else
            {
                MessageBox.Show("No hay archivo de Composicion para recopilar informacion");
            }
        }
        /*public static int CantidadAutosAFabricar(Modelo.Pedidos objP, Modelo.Stock objS, Modelo.StockPiezas objSP, Modelo.Composicion objC)
        {
            int CantAut = 0, tru = 0;
            bool bandera = false;

            if (objP.Mod != null && objS.stc != null && objSP.stcp != null && objC.Com != null)
            {
                for (int i = 0; i < 200; i++)
                {
                    if (objSP.stcp[i]==null)
                    {
                        break;
                    }

                    objS
                    



                }


            }

            



            return 0;
        }*/


    }
}
    
