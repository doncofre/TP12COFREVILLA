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
    public partial class _04Composicion : Form
    {
        public _04Composicion()
        {
            InitializeComponent();
            Mostrar();
        }

        private void dgvComposicion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Mostrar()
        {
            string path = "Composicion.txt";
            if (File.Exists(path) == true)
            {
                Modelo.Composicion obj = new Modelo.Composicion(path);
                dgvComposicion.DataSource = obj.Com;
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
