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
    public partial class LibroMayor : Form
    {
        DB DB = new DB();
        public LibroMayor()
        {
            InitializeComponent();
            DB.IniciarConexion();
        }

        private void LibroMayor_Load(object sender, EventArgs e)
        {
            DB.CargarCB("Descripcion", "SELECT * FROM  Rubro", cmBox_Rubro);
            lbl_totalHaberCuenta.Text = "0";
            lbl_TotalDebeCuenta.Text = "0";
        }

        private void cmBox_TipoCuenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmBox_SubRubro.Items.Clear();
            DB.CargarCB("Descripcion", "SELECT * FROM Subrubros WHERE RubrosID = " + (cmBox_Rubro.SelectedIndex + 1).ToString() + " ", cmBox_SubRubro);

            if (cmBox_SubRubro.Items.Count == 0)
            {
                cmBox_Cuenta.Items.Clear();
                DB.CargarCB("Descripcion", "SELECT CodigoCuenta,Descripcion FROM cuentas WHERE RubroID = " + (cmBox_Rubro.SelectedIndex + 1).ToString() + " ", cmBox_Cuenta);
                cmBox_Cuenta.Enabled = true;
                cmBox_SubRubro.Enabled = false;
            }
            else
            {
                cmBox_Cuenta.Enabled = false;
                cmBox_SubRubro.Enabled = true;
            }
        }

        private void cmBox_Rubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ssql = "";

            ssql = "SELECT CodigoCuenta,C.Descripcion FROM Cuentas C ";
            ssql = ssql + "INNER JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID ";
            ssql = ssql + "WHERE CodigoSubRubro = " + (cmBox_SubRubro.SelectedIndex + 1).ToString() + " AND SR.RubrosID = " + (cmBox_Rubro.SelectedIndex + 1).ToString();

            cmBox_Cuenta.Items.Clear();
            DB.CargarCB("Descripcion", ssql, cmBox_Cuenta);
            cmBox_Cuenta.Enabled = true;
        }

        private void cmBox_Cuenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int ID_Cuenta;
            //Obtengo ID de la cuenta que necesito realizar el asiento
            if (cmBox_SubRubro.Items.Count == 0)
            {
                ID_Cuenta = Convert.ToInt32(DB.LeerDato("CuentasID", "SELECT CuentasID FROM cuentas WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND RubroID = " + (cmBox_Rubro.SelectedIndex + 1).ToString() + " "));
            }
            else
            {
                ID_Cuenta = Convert.ToInt32(DB.LeerDato("CuentasID", "SELECT CuentasID FROM cuentas WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND SubRubroID = " + (cmBox_SubRubro.SelectedIndex + 1).ToString() + " "));
            }

            if (cmBox_SubRubro.Items.Count == 0)
            {
                txt_DetalleCuenta.Text = DB.LeerDato("Descripcion", "SELECT Descripcion FROM cuentas WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND RubroID = " + (cmBox_Rubro.SelectedIndex + 1).ToString() + " ");
                txt_CodigoCuenta.Text = DB.LeerDato("CodigoCuenta", "SELECT CodigoCuenta FROM cuentas WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND RubroID = " + (cmBox_Rubro.SelectedIndex + 1).ToString() + " ");
            }
            else
            {
                txt_DetalleCuenta.Text = DB.LeerDato("Descripcion", "SELECT c.Descripcion FROM cuentas c INNER JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND SR.CodigoSubRubro = " + (cmBox_SubRubro.SelectedIndex + 1).ToString() + " AND SR.RubrosID = " + (cmBox_Rubro.SelectedIndex + 1).ToString());
                txt_CodigoCuenta.Text = DB.LeerDato("CodigoCuenta", "SELECT c.CodigoCuenta FROM cuentas c INNER JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND SR.CodigoSubRubro = " + (cmBox_SubRubro.SelectedIndex + 1).ToString() + " AND SR.RubrosID = " + (cmBox_Rubro.SelectedIndex + 1).ToString());
            }

            DB.CargaDGV(DGV_Asientos, "SELECT CodigoAsiento,Fecha,Debe,Haber FROM Asientos WHERE CuentaID = " + ID_Cuenta, "Asientos");
            DB.CargaDGV(DGV_Saldos, "SELECT S_Acredor,S_Deudor FROM Asientos WHERE CuentaID = " + ID_Cuenta, "Asientos");
        }

    }
}
