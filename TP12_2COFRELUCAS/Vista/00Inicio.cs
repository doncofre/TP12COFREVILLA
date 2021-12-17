using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP12_2COFRELUCAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            Form f01 = new Vista._01Pedidos();
            f01.Show();

        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Form f02 = new Vista._02Stock();
            f02.Show();
        }

        private void StockPiezas_Click(object sender, EventArgs e)
        {
            Form f03 = new Vista._03StockPiezas();
            f03.Show();
        }

        private void Composicion_Click(object sender, EventArgs e)
        {
            Form f04 = new Vista._04Composicion();
            f04.Show();
        }

        private void Modelo_Click(object sender, EventArgs e)
        {
            Form f05 = new Vista._05Modelo();
            f05.Show();
        }

        private void Pieza_Click(object sender, EventArgs e)
        {
            Form f06 = new Vista._06Pieza();
            f06.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }



