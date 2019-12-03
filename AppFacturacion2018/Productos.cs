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
    public partial class Productos : Form
    {
        DB DB = new DB();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            

            DB.IniciarConexion();

            DB.CargarCB("tipoCategoria", "select * from categoria", cmbox_Categoria);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DB.Ejecutar("INSERT INTO producto(codigo,nombre,descripción,refidtipoCategoria) VALUES ('" + txt_Codigo.Text + "','" + txt_Nombre.Text + "','" + Txt_desc.Text + "','" + cmbox_Categoria.SelectedItem.ToString() + "')");
            }
        }

        private void cmbox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            try 
            {
                if ((txt_Codigo.Text != "") && (Txt_desc.Text != "") && (txt_Nombre.Text != "") && (cmbox_Categoria.SelectedItem.ToString() != ""))
                {
                    return true;
                }
                else
                {
                    return false;
                }
               

            }
            catch (Exception )
            {
                MessageBox.Show("Fallo ValidarCampo :");
                return false;
            }
        }
    }
}
