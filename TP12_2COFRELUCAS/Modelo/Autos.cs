using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TP12_2COFRELUCAS.Modelo
{
    class Pedidos
    {
        public string NModelo { get; set; }
        public string NConsesionaria { get; set; }
        public string CantPedida { get; set; }
        public List<Modelo.Pedidos> Mod { get; set; }
        public bool verdad2 { get; set; } = true;
        public Pedidos()
        {

        }
        public Pedidos(string path)
        {
            Mod = new List<Modelo.Pedidos>();
            Modelo.Pedidos obj;
            string linea;
            string[] arr = new string [3];
            char separador = ',';
            StreamReader Leer = new StreamReader(path);
            linea = Leer.ReadLine();
            while (linea != null)
            {
                obj = new Modelo.Pedidos();
                arr = linea.Split(separador);
                bool verdad = Methods.DevuelveEntero(arr[2]);
                if (verdad == true)
                {
                    obj.NModelo = arr[0];
                    obj.NConsesionaria = arr[1];
                    obj.CantPedida = arr[2];
                    Mod.Add(obj);
                }
                else
                {
                    verdad2 = false;
                }
                linea = Leer.ReadLine();

            }
            Leer.Close();
        }

    }
    class Stock
    {
        public string NModelo { get; set; }
        public string Descripcion { get; set; }
        public string stock { get; set; }
        public List<Modelo.Stock> stc { get; set; }
        public bool verdad2 { get; set; } = true;
        public Stock()
        {

        }
        public Stock(string path)
        {
            stc = new List<Modelo.Stock>();
            Modelo.Stock obj;
            string linea;
            string[] arr = new string[3];
            char separador = ',';
            StreamReader Leer = new StreamReader(path);
            linea = Leer.ReadLine();
            while (linea != null)
            {
                obj = new Modelo.Stock();
                arr = linea.Split(separador);
                bool verdad = Methods.DevuelveEntero(arr[2]);
                if (verdad == true)
                {
                    obj.NModelo = arr[0];
                    obj.Descripcion = arr[1];
                    obj.stock = arr[2];
                    stc.Add(obj);
                }
                else
                {
                    verdad2 = false;
                }
                linea = Leer.ReadLine();

            }
            Leer.Close();
        }
    }
    class StockPiezas
    {
        public string NroPieza { get; set; }
        public string Descripcion { get; set; }
        public string Stock { get; set; }
        public List<Modelo.StockPiezas> stcp { get; set; }
        public bool verdad2 { get; set; } = true;

        public StockPiezas()
        {

        }
        public StockPiezas(string path)
        {
            stcp = new List<Modelo.StockPiezas>();
            Modelo.StockPiezas obj;
            string linea;
            string[] arr = new string[3];
            char separador = ',';
            StreamReader Leer = new StreamReader(path);
            linea = Leer.ReadLine();
            while (linea != null)
            {
                obj = new Modelo.StockPiezas();
                arr = linea.Split(separador);
                bool verdad = Methods.DevuelveEntero(arr[2]);
                if (verdad == true)
                {
                    obj.NroPieza = arr[0];
                    obj.Descripcion = arr[1];
                    obj.Stock = arr[2];
                    stcp.Add(obj);
                }
                else
                {
                    verdad2 = false;
                }
                linea = Leer.ReadLine();

            }
            Leer.Close();
        }




    }
    class Composicion
    {
        public string NModelo { get; set; }
        public string NPieza { get; set; }
        public string CantUsar { get; set; }
        public List<Modelo.Composicion> Com { get; set; }
        public bool verdad2 { get; set; } = true;

        public Composicion()
        {

        }
        public Composicion(string path)
        {
            Com = new List<Modelo.Composicion>();
            Modelo.Composicion obj;
            string linea;
            string[] arr = new string[3];
            char separador = ',';
            StreamReader Leer = new StreamReader(path);
            linea = Leer.ReadLine();
            while (linea != null)
            {
                obj = new Modelo.Composicion();
                arr = linea.Split(separador);
                bool verdad = Methods.DevuelveEntero(arr[2]);
                if (verdad == true)
                {
                    obj.NModelo = arr[0];
                    obj.NPieza = arr[1];
                    obj.CantUsar = arr[2];
                    Com.Add(obj);
                }
                else
                {
                    verdad2 = false;
                }
                linea = Leer.ReadLine();

            }
            Leer.Close();
        }

    }
    class Afabricar
    {
        public string NModelo { get; set; }
        public int AFabricar { get; set; }
    }
    /*
    public class Methods
    {
        public static bool DevuelveEntero(string numero)
        {
            int num = -1;
            bool verdad = Int32.TryParse(numero, out num);
            if (num >= 0)
            {
                return verdad;
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

        void CargarModelo(Modelo.Pedidos objP, Modelo.Stock objS, Modelo.StockPiezas objSP, Modelo.Composicion objC)
        {
            CargarPedidos(objP);
            CargarStock(objS);
            CargarStockPiezas(objSP);
            CargarComposicion(objC);
        }
        void CargarPedidos(Modelo.Pedidos obj)
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
        void CargarStock(Modelo.Stock obj)
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
        void CargarStockPiezas(Modelo.StockPiezas obj)
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
        void CargarComposicion(Modelo.Composicion obj)
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

    */













    }

