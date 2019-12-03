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
    public partial class IngresoProdStock : Form
    {
        DB DB = new DB();
        public IngresoProdStock()
        {
            InitializeComponent();
        }

        private void IngresoProdStock_Load(object sender, EventArgs e)
        {
            if (rbEntrada.Checked)
            {
                lblEntradaUnidad.Text = "Entrada Unidad";
                lblEntradaPrecio.Text = "Entrada Precio";
                lblEntradaTotal.Text = "Entrada Total";

            }
            else
            {
                lblEntradaUnidad.Text = "Salida Unidad";
                lblEntradaPrecio.Text = "Salida Precio";
                lblEntradaTotal.Text = "Salida Total";
            }
        }

        private void rdSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSalida.Checked)
            {
                lblEntradaUnidad.Text = "Salida Unidad";
                lblEntradaPrecio.Text = "Salida Precio";
                lblEntradaTotal.Text = "Salida Total";

            }
            else
            {
                lblEntradaUnidad.Text = "Entrada Unidad";
                lblEntradaPrecio.Text = "Entrada Precio";
                lblEntradaTotal.Text = "Entrada Total";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idProd = DB.LeerDato("idproducto", "select idproducto from dbo.producto where nombre like '%" + txtBuscarProd.Text + "%' ");

            string total = DB.LeerDato("total", "select count(idproducto)as total from dbo.fichaStock where idproducto like '%" + idProd + "%' ");
            string Stock_Unidad = DB.LeerDato("Stock_Unidad", "select Stock_Unidad from dbo.fichaStock where idproducto like '%" + idProd + "%' order by IdFichaStock desc");
            string Stock_Total = DB.LeerDato("Stock_Total", "select Stock_Total from dbo.fichaStock where idproducto like '%" + idProd + "%' order by IdFichaStock desc ");
            string Stock_Precio= "0";
            
            if (total  == "0")
            {
                txtEntradaTotal.Text = (float.Parse(txtEntradaUnidad.Text) * float.Parse(txtEntradaPrecio.Text)).ToString();
                string INSERT = "INSERT INTO fichaStock(idProducto,Fecha,Entrada_Unidad,Entrada_Precio,Entrada_Total,Salida_Unidad,Salida_Precio,Salida_Total,Stock_Unidad,Stock_Precio,Stock_Total)";
                string VALUES = "VALUES(" + idProd + ",getdate()," + txtEntradaUnidad.Text + "," + (txtEntradaPrecio.Text).Replace(',', '.') + "," + (txtEntradaTotal.Text).Replace(',', '.') + ",0,0,0," + txtEntradaUnidad.Text + "," + (txtEntradaPrecio.Text).Replace(',', '.') + "," + (txtEntradaTotal.Text).Replace(',', '.') + ")";
                string SSQL = INSERT + VALUES;
                if (true)
                {

                    DB.Ejecutar(SSQL);

                }

            }
            else
            {
                txtEntradaTotal.Text = (float.Parse(txtEntradaUnidad.Text) * float.Parse(txtEntradaPrecio.Text)).ToString();
                Stock_Unidad = (float.Parse(Stock_Unidad) + float.Parse(txtEntradaUnidad.Text)).ToString();
                Stock_Total = (float.Parse(Stock_Total) + float.Parse(txtEntradaTotal.Text)).ToString();
                Stock_Precio = (float.Parse(Stock_Total) / float.Parse(Stock_Unidad)).ToString();

                
                string INSERT = "INSERT INTO fichaStock(idProducto,Fecha,Entrada_Unidad,Entrada_Precio,Entrada_Total,Salida_Unidad,Salida_Precio,Salida_Total,Stock_Unidad,Stock_Precio,Stock_Total)";
                string VALUES = "VALUES(" + idProd + ",getdate()," + txtEntradaUnidad.Text + "," + (txtEntradaPrecio.Text).Replace(',', '.') + "," + (txtEntradaTotal.Text).Replace(',', '.') + ",0,0,0," + Stock_Unidad + "," + (Stock_Precio).Replace(',', '.') + "," + (Stock_Total).Replace(',', '.') + ")";
                string SSQL = INSERT + VALUES;
                if (true)
                {

                    DB.Ejecutar(SSQL);

                }
            }


            
        }

        private void txtBuscarProd_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBuscarProd_TextChanged(object sender, EventArgs e)
        {
            DB.IniciarConexion();
            DB.Autocompletar("select nombre from dbo.producto", "nombre", txtBuscarProd);

            txtDescProd.Text = DB.LeerDato("descripción", "select descripción from dbo.producto where nombre like '%" + txtBuscarProd.Text + "%' ");


        }


    }
}
