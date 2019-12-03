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
    public partial class Balance : Form
    {
        DB DB = new DB();
        public Balance()
        {
            InitializeComponent();
            DB.IniciarConexion();

        }

        private void Balance_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void CalcularTotales(DataGridView DGV,TextBox TXT)
        {
            double total = 0;
            for (int i = 0; i < DGV.Rows.Count- 1; i++)
            {//1
                total = total + Convert.ToDouble(DGV.Rows[i].Cells[1].Value.ToString());
            }
            TXT.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }


        private void cargar()
        {
            string ssql = "";
            //ACTIVOS
            ssql = ssql + "SELECT SR.Descripcion,isNull(SUM(A.S_Deudor + A.S_Acredor),0) as Total FROM Cuentas C ";
            ssql = ssql + "LEFT JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID  ";
            ssql = ssql + "LEFT JOIN Rubro R ON (R.RubroID = SR.RubrosID) or (R.RubroID =  C.RubroID)  ";
            ssql = ssql + "LEFT JOIN ASIENTOS A ON A.CuentaID= C.CuentasID ";
            ssql = ssql + "WHERE R.RubroID = 1 ";
            ssql = ssql + "GROUP BY SR.Descripcion ";


            DB.CargaDGV(DGV_Activos, ssql, "Cuentas");
            CalcularTotales(DGV_Activos, txt_TotalActivos);

            ssql = "";
            //PASIVOS
            ssql = ssql + "SELECT SR.Descripcion,isNull(SUM(A.S_Deudor + A.S_Acredor),0) as Total FROM Cuentas C ";
            ssql = ssql + "LEFT JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID  ";
            ssql = ssql + "LEFT JOIN Rubro R ON (R.RubroID = SR.RubrosID) or (R.RubroID =  C.RubroID)  ";
            ssql = ssql + "LEFT JOIN ASIENTOS A ON A.CuentaID= C.CuentasID ";
            ssql = ssql + "WHERE R.RubroID = 2 ";
            ssql = ssql + "GROUP BY SR.Descripcion ";

            DB.CargaDGV(DGV_Pasivos, ssql, "Cuentas");
            CalcularTotales(DGV_Pasivos, txt_TotalPasivo);
            ssql = "";
            //PatrimonioNeto
            ssql = ssql + "SELECT C.Descripcion,isNull(SUM(A.S_Deudor + A.S_Acredor),0) as Total FROM Cuentas C ";
            ssql = ssql + "LEFT JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID  ";
            ssql = ssql + "LEFT JOIN Rubro R ON (R.RubroID = SR.RubrosID) or (R.RubroID =  C.RubroID)  ";
            ssql = ssql + "LEFT JOIN ASIENTOS A ON A.CuentaID= C.CuentasID ";
            ssql = ssql + "WHERE R.RubroID = 3 ";
            ssql = ssql + "GROUP BY C.Descripcion ";

            DB.CargaDGV(DGV_PatrimonioNeto, ssql, "Cuentas");
            CalcularTotales(DGV_PatrimonioNeto, txt_TotalPatrimonioNeto);

            txt_TotalPasivosYPN.Text = Convert.ToString(Convert.ToDouble(txt_TotalPasivo.Text) + Convert.ToDouble(txt_TotalPatrimonioNeto.Text));
            ssql = "";
            //INGRESOS
            ssql = ssql + "SELECT C.Descripcion,isNull(SUM(A.S_Deudor + A.S_Acredor),0) as Total FROM Cuentas C ";
            ssql = ssql + "LEFT JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID  ";
            ssql = ssql + "LEFT JOIN Rubro R ON (R.RubroID = SR.RubrosID) or (R.RubroID =  C.RubroID)  ";
            ssql = ssql + "LEFT JOIN ASIENTOS A ON A.CuentaID= C.CuentasID ";
            ssql = ssql + "WHERE R.RubroID = 4 ";
            ssql = ssql + "GROUP BY C.Descripcion ";

            DB.CargaDGV(DGV_Ingresos, ssql, "Cuentas");
            CalcularTotales(DGV_Ingresos, txt_TotalIngresos);
            ssql = "";
            //EGRESOS
            ssql = ssql + "SELECT C.Descripcion,isNull(SUM(A.S_Deudor + A.S_Acredor),0) as Total FROM Cuentas C ";
            ssql = ssql + "LEFT JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID  ";
            ssql = ssql + "LEFT JOIN Rubro R ON (R.RubroID = SR.RubrosID) or (R.RubroID =  C.RubroID)  ";
            ssql = ssql + "LEFT JOIN ASIENTOS A ON A.CuentaID= C.CuentasID ";
            ssql = ssql + "WHERE R.RubroID = 5 ";
            ssql = ssql + "GROUP BY C.Descripcion ";

            DB.CargaDGV(DGV_Egresos, ssql, "Cuentas");
            CalcularTotales(DGV_Egresos, txt_TotalEgresos);
        }

        private void DGV_Activos_DoubleClick(object sender, EventArgs e)
        {
            BalanceDetalleCuentas fmrBalanceDetalleCuentas = new BalanceDetalleCuentas();
            fmrBalanceDetalleCuentas.ObtenerID(DGV_Activos.CurrentRow.Cells[0].Value.ToString(),1);
            fmrBalanceDetalleCuentas.ShowDialog();
        }

        private void DGV_Pasivos_DoubleClick(object sender, EventArgs e)
        {
            BalanceDetalleCuentas fmrBalanceDetalleCuentas = new BalanceDetalleCuentas();
            fmrBalanceDetalleCuentas.ObtenerID(DGV_Pasivos.CurrentRow.Cells[0].Value.ToString(),1);
            fmrBalanceDetalleCuentas.ShowDialog();

        }

        private void DGV_PatrimonioNeto_DoubleClick(object sender, EventArgs e)
        {
            BalanceDetalleCuentas fmrBalanceDetalleCuentas = new BalanceDetalleCuentas();
            fmrBalanceDetalleCuentas.ObtenerID(DGV_PatrimonioNeto.CurrentRow.Cells[0].Value.ToString(),2);
            fmrBalanceDetalleCuentas.ShowDialog();

        }

        private void DGV_Egresos_DoubleClick(object sender, EventArgs e)
        {
            BalanceDetalleCuentas fmrBalanceDetalleCuentas = new BalanceDetalleCuentas();
            fmrBalanceDetalleCuentas.ObtenerID(DGV_Egresos.CurrentRow.Cells[0].Value.ToString(),2);
            fmrBalanceDetalleCuentas.ShowDialog();
        }

        private void DGV_Ingresos_DoubleClick(object sender, EventArgs e)
        {
            BalanceDetalleCuentas fmrBalanceDetalleCuentas = new BalanceDetalleCuentas();
            fmrBalanceDetalleCuentas.ObtenerID(DGV_Ingresos.CurrentRow.Cells[0].Value.ToString(),2);
            fmrBalanceDetalleCuentas.ShowDialog();
        }
    }
}
