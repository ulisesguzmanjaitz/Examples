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
    public partial class BalanceDetalleCuentas : Form
    {
        String Description;
        int Opt;

        DB DB = new DB();
        public BalanceDetalleCuentas()
        {
            InitializeComponent();
            DB.IniciarConexion();
        }

        private void BalanceDetalleCuentas_Load(object sender, EventArgs e)
        {
            string ssql = "";

            

            

            switch (Opt)
            {
                case 1:
                    ssql = ssql + "SELECT C.Descripcion, isNull(SUM(A.S_Deudor + A.S_Acredor),0) as Total ";
                    ssql = ssql + "FROM Cuentas C ";
                    ssql = ssql + "INNER JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID  ";
                    ssql = ssql + "INNER JOIN ASIENTOS A ON A.CuentaID= C.CuentasID ";
                    ssql = ssql + "WHERE SR.Descripcion like '" + Description + "'";
                    ssql = ssql + "GROUP BY C.Descripcion ";
                    break;
                default:
                    ssql = ssql + "SELECT C.Descripcion, isNull(SUM(A.S_Deudor + A.S_Acredor),0) as Total ";
                    ssql = ssql + "FROM Cuentas C ";
                    ssql = ssql + "INNER JOIN Rubro R ON R.RubroID = C.RubroID  ";
                    ssql = ssql + "INNER JOIN ASIENTOS A ON A.CuentaID= C.CuentasID ";
                    ssql = ssql + "WHERE C.Descripcion like '" + Description + "'";
                    ssql = ssql + "GROUP BY C.Descripcion ";
                    break;
            }

            DB.CargaDGV(DGV_Cuentas_Activos, ssql, "Cuentas");
            CalcularTotales(DGV_Cuentas_Activos, txt_TotalCuentasActivos);

        }

        public void ObtenerID (string Description,int Opt)
        {
            this.Description = Description;
            this.Opt= Opt;
        }

        private void CalcularTotales(DataGridView DGV, TextBox TXT)
        {
            double total = 0;
            for (int i = 0; i <= DGV.Rows.Count - 1; i++)
            {//1
                total = total + Convert.ToDouble(DGV.Rows[i].Cells[1].Value.ToString());
            }
            TXT.Text = total.ToString();
        }

    }
}
