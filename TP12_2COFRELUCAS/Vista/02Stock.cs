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
    public partial class _02Stock : Form
    {
        public _02Stock()
        {
            InitializeComponent();
            Mostrar();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Mostrar()
        {
            string path = "Stock.txt";
            if (File.Exists(path) == true)
            {
                Modelo.Stock obj = new Modelo.Stock(path);
                dgvStock.DataSource = obj.stc;
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
