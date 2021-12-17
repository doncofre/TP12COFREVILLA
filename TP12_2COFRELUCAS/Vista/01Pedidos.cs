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
    public partial class _01Pedidos : Form
    {
        public _01Pedidos()
        {
            InitializeComponent();
            Mostrar();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        void Mostrar()
        {
            string path = "Pedidos.txt";
            if (File.Exists(path))
            {
                Modelo.Pedidos obj = new Modelo.Pedidos(path);
                dgvPedidos.DataSource = obj.Mod;
                if (obj.verdad2 == false)
                {
                    MessageBox.Show("Algunos datos no se pudieron cargar, Revise el archivo");
                }
            }
            else
            {
                MessageBox.Show("No hay archivos para recopilar informacion");
            }
        }
    }
}
