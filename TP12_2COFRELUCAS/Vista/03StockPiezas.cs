using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP12_2COFRELUCAS.Vista
{
    public partial class _03StockPiezas : Form
    {
        public _03StockPiezas()
        {
            InitializeComponent();
            Mostrar();
        }


        private void dgvStockPiezas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void Mostrar()
        {
            string path = "StockPiezas.txt";
            if (File.Exists(path) == true)
            {
                Modelo.StockPiezas obj = new Modelo.StockPiezas(path);
                dgvStockPiezas.DataSource = obj.stcp;
                if (obj.verdad2 == false)
                {
                    MessageBox.Show("Algunos datos no se pudieron cargar, Revise el archivo");
                }
            }
            else if (File.Exists(path) == false)
            {
                MessageBox.Show("No hay archivos para recopilar informacion");
            }
        }
    }
}
