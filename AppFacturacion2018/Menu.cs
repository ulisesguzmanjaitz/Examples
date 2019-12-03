using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppFacturacion2018
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_ABMProductos_Click(object sender, EventArgs e)
        {
            Productos fmrProd = new Productos();
            fmrProd.ShowDialog();
            
        }

        private void btn_IngresoStock_Click(object sender, EventArgs e)
        {
            IngresoProdStock fmrIngProdStock = new IngresoProdStock();
            fmrIngProdStock.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas fmrVentas = new Ventas();
            fmrVentas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes fmrClientes = new Clientes();
            fmrClientes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cuentas fmrCuentas = new Cuentas();
            fmrCuentas.ShowDialog();
        }

        private void btn_Balance_Click(object sender, EventArgs e)
        {
            Balance fmrBalance = new Balance();
            fmrBalance.ShowDialog();
        }
    }
}
