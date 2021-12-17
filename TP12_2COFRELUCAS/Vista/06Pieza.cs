using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP12_2COFRELUCAS.Vista
{
    public partial class _06Pieza : Form
    {
        Modelo.Pedidos objP = new Modelo.Pedidos("Pedidos.txt");
        Modelo.Stock objS = new Modelo.Stock("Stock.txt");
        Modelo.StockPiezas objSP = new Modelo.StockPiezas("StockPiezas.txt");
        Modelo.Composicion objC = new Modelo.Composicion("Composicion.txt");

        public _06Pieza()
        {
            InitializeComponent();
            Modelo.Methods.CargarModelo(objP, objS, objSP, objC);
            Mostrar();
        }

        private void dgvPieza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Mostrar()
        {
            Modelo.SeAdeudan[] objSA = new Modelo.SeAdeudan[20];
            Modelo.Piezas piez = new Modelo.Piezas(objP, objS, objSP, objC, objSA);
            Modelo.ModeloFab mod = new Modelo.ModeloFab(objP, objS, objSP, objC, objSA);
            dgvPieza.DataSource = piez.ListPieza;
        }
    }
}
