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
    public partial class Cuentas : Form
    {
        DB DB = new DB();
        public Cuentas()
        {
            InitializeComponent();
            DB.IniciarConexion();
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            DB.CargarCB("Descripcion", "SELECT * FROM  Rubro ", cmBox_Rubro);
            DB.CargarCB("Descripcion", "SELECT * FROM  TipoTransaccion", cmBox_Transaccion);
            txt_totalHaberCuenta.Text = "0";
            txt_TotalDebeCuenta.Text = "0";
            //dateTimePicker1.MinDate = Convert.ToDateTime(DB.LeerDato("Fecha","SELECT TOP 1 * FROM ASIENTOS ORDER BY AsientosID DESC"));
            dateTimePicker1.MaxDate = (DateTime.Today).AddDays(1);
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

        private void CmBox_Cuenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
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
        }

        private void txt_MontoCuenta_TextChanged(object sender, EventArgs e)
        {
            if (txt_MontoCuenta.Text != "")
            {
                btn_AgregarDetalle.Enabled = true;
            }
            else
            {
                btn_AgregarDetalle.Enabled = false;
            }
        }

        private void btn_AgregarDetalle_Click(object sender, EventArgs e)
        {
            int ID_Cuenta;
            string N_Asiento = GenerarNumeroAsiento();
            
            //Obtengo ID de la cuenta que necesito realizar el asiento
            if (cmBox_SubRubro.Items.Count == 0)
            {
                ID_Cuenta = Convert.ToInt32(DB.LeerDato("CuentasID", "SELECT CuentasID FROM cuentas WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND RubroID = " + (cmBox_Rubro.SelectedIndex + 1).ToString() + " "));
            }
            else
            {
                ID_Cuenta = Convert.ToInt32(DB.LeerDato("CuentasID", "SELECT CuentasID FROM cuentas c INNER JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID WHERE CodigoCuenta = " + "'00" + (cmBox_Cuenta.SelectedIndex + 1).ToString() + "' AND SR.CodigoSubRubro = " + (cmBox_SubRubro.SelectedIndex + 1).ToString() + "AND SR.RubrosID = " + (cmBox_Rubro.SelectedIndex + 1).ToString()));
            }
            string aux = txt_MontoCuenta.Text;
            txt_MontoCuenta.Text = aux.Replace('.',',');
            if (cmBox_Transaccion.Text == "Debe")
            {
                DGV_Asientos.Rows.Add(N_Asiento, txt_CodigoCuenta.Text, txt_DetalleCuenta.Text, txt_MontoCuenta.Text, "0", ID_Cuenta);
                txt_TotalDebeCuenta.Text = (double.Parse(txt_TotalDebeCuenta.Text) + double.Parse(txt_MontoCuenta.Text)).ToString();
            }
            else
            {
                DGV_Asientos.Rows.Add(N_Asiento, txt_CodigoCuenta.Text, txt_DetalleCuenta.Text, "0", txt_MontoCuenta.Text, ID_Cuenta);
                txt_totalHaberCuenta.Text = (double.Parse(txt_totalHaberCuenta.Text) + double.Parse(txt_MontoCuenta.Text)).ToString();
            }

            ReiniciarControles();
        }

        private void cmBox_Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBox_Transaccion.Enabled = true;
        }

        private void cmBox_Transaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MontoCuenta.Enabled = true;
        }

        private void btn_CerrarLibroDiario_Click(object sender, EventArgs e)
        {
            LibroMayor fmrLibroDiario = new LibroMayor();
            fmrLibroDiario.ShowDialog();
        }

        private void btn_CerrarAsiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_totalHaberCuenta.Text != txt_TotalDebeCuenta.Text)
                {
                    MessageBox.Show("Hay una diferencia en los totales del DEBE y el HABER... Verificar antes de continuar");
                }
                else
                {
                    if (ValidarSaldoCuentas())
                    {
                        for (int i = 0; i < DGV_Asientos.Rows.Count; i++)
                        {
                            Asiento asiento = new Asiento();
                            CargarAsiento(ref asiento, i);
                            InsertarAsiento(asiento);
                        }
                        MessageBox.Show("Se genero el Asiento de foma correcta");
                        dateTimePicker1.MinDate = Convert.ToDateTime(DB.LeerDato("Fecha", "SELECT TOP 1 * FROM ASIENTOS ORDER BY AsientosID DESC"));
                        DGV_Asientos.Rows.Clear();
                       
                    }
                    else
                    {
                        MessageBox.Show("Verifique el tipo de saldo por cuenta para la sumatoria de los DEBES y los HABERES...");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error al intentar guardar el Asiento... Error: " + ex);
                //throw;
            }
        }

        private string ObtenerTipoSaldo(string CuentaID)
        {
            string TipoSaldo,ssql;

            ssql = " SELECT TipoSaldo FROM Cuentas C ";
            ssql = ssql + "LEFT JOIN SubRubros SR ON SR.SubRubrosID = C.SubRubroID ";
            ssql = ssql + "LEFT JOIN Rubro R ON (R.RubroID = SR.RubrosID) or (R.RubroID =  C.RubroID) ";
            ssql = ssql + "WHERE CuentasID = " + CuentaID;

            TipoSaldo = DB.LeerDato("TipoSaldo", ssql);
            

            return TipoSaldo;
        }

        private void CargarAsiento(ref Asiento asiento,int i)
        {
            string aux = "0";
            
            //Obtengo CuentaID,Debe Y haber de cada registro
            asiento.Cuenta_ID = DGV_Asientos.Rows[i].Cells[5].Value.ToString();

            //Obtengo Debe Y haber de cada registro
            asiento.CodigoAsiento = DGV_Asientos.Rows[i].Cells[0].Value.ToString();
            asiento.Debe = (DGV_Asientos.Rows[i].Cells[3].Value.ToString()).Replace(',', '.');
            asiento.Haber = (DGV_Asientos.Rows[i].Cells[4].Value.ToString()).Replace(',', '.');
            asiento.Fecha = dateTimePicker1.Value;

            if (Convert.ToDouble(asiento.Debe) < Convert.ToDouble(asiento.Haber))
            {
                aux = asiento.Haber;
            }
            else
            {
                aux = asiento.Debe;
            }

            //Obtengo el tipo de saldo para cada cuenta 
            if ("Acreedor" == ObtenerTipoSaldo(asiento.Cuenta_ID))
            {
                asiento.S_Acredor = aux.Replace(',', '.');
            }
            else
            {
                asiento.S_Deudor = aux.Replace(',', '.');
            }

            
        }

        private void InsertarAsiento(Asiento asiento)
        {
            try
            {
                string ssql = "";
                //Inserto la linea correspondiente a una de las cuentas del asiento a generar.
                ssql = "INSERT INTO ASIENTOS (CodigoAsiento,Fecha,Debe,Haber,S_Acredor,S_Deudor,CuentaID)";
                ssql = ssql + "Values('" + asiento.CodigoAsiento + "','" + asiento.Fecha + "'," + asiento.Debe + "," + asiento.Haber + "," + asiento.S_Acredor + "," + asiento.S_Deudor + "," + asiento.Cuenta_ID + ")";
                DB.Ejecutar(ssql);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error en 'InsertarAsiento'... Error: " + ex);
                throw;
            }
        }
        private void ReiniciarControles()
        {
            cmBox_Rubro.Text = "Seleccione Tipo Cuenta";

            cmBox_SubRubro.Text = "Seleccione SubRubro";
            cmBox_SubRubro.Items.Clear();
            cmBox_SubRubro.Enabled = false;

            cmBox_Cuenta.Text = "Seleccione Cuenta";
            cmBox_Cuenta.Items.Clear();
            cmBox_Cuenta.Enabled = false;

            cmBox_Transaccion.Text = "Seleccione Transacción";
            cmBox_Transaccion.Enabled = false;

            txt_CodigoCuenta.Text = "";
            txt_DetalleCuenta.Text = "";
            txt_MontoCuenta.Text = "0";
            txt_MontoCuenta.Enabled = false;
            btn_AgregarDetalle.Enabled = false;
        }
        private string GenerarNumeroAsiento()
        {
            string ssql = "", N_Asiento  = "";

            ssql = "SELECT TOP 1 AsientosID FROM ASIENTOS ORDER BY CodigoAsiento DESC";
            N_Asiento = DB.LeerDato("AsientosID", ssql);
            if (N_Asiento == "-1")
            {
                N_Asiento = "0001";
            }
            else
            {
                N_Asiento = string.Format("{0:0000}", (Convert.ToInt32(N_Asiento) + 1));
            }
            return N_Asiento;
        }

        private Boolean CalcularSaldoConDebeYHaberPorCuenta(String Cuenta_ID)
        {
            Double Sumatoria_Debe = 0;
            Double Sumatoria_Haber = 0;
            string Debe = "0";
            string Haber = "0";
            string TipoSaldo = "";
            string TipoSaldoCuenta = "";

            TipoSaldoCuenta = ObtenerTipoSaldo(Cuenta_ID);
            
            for (int i = 0; i < DGV_Asientos.Rows.Count; i++)
            {
                if (Cuenta_ID == DGV_Asientos.Rows[i].Cells[5].Value.ToString())
                {
                    Debe = DGV_Asientos.Rows[i].Cells[3].Value.ToString();
                    Haber = DGV_Asientos.Rows[i].Cells[4].Value.ToString();

                    Sumatoria_Debe =Sumatoria_Debe + Convert.ToDouble(Debe);
                    Sumatoria_Haber = Sumatoria_Haber + Convert.ToDouble(Haber);



                    
                }
            }

            if (Convert.ToDouble(Sumatoria_Debe) > Convert.ToDouble(Sumatoria_Haber))
            {
                TipoSaldo = "Deudor";
            }
            else if ((Convert.ToDouble(Sumatoria_Debe) < Convert.ToDouble(Sumatoria_Haber)))
            {
                TipoSaldo = "Acreedor";
            }
            else
            {
                TipoSaldo = "Nulo";
            }

            if (TipoSaldoCuenta != TipoSaldo)
            {
                if (TipoSaldo != "Nulo")
                {
                    return false;
                }else { return true; }
            }
            else { return true; }
        }

        private List<string> ObtenerListaDeCuentasID()
        {
            List<string> ListCuentasID = new List<string>();

            for (int i = 0; i < DGV_Asientos.Rows.Count; i++)
            {
                if (!ListCuentasID.Contains(DGV_Asientos.Rows[i].Cells[5].Value.ToString()))
                {
                    ListCuentasID.Add(DGV_Asientos.Rows[i].Cells[5].Value.ToString());
                }
            }
            return ListCuentasID;
        }

        private Boolean ValidarSaldoCuentas()
        {
            List<string> L_CuentasID = new List<string>();
            L_CuentasID = ObtenerListaDeCuentasID();

            foreach (string L in L_CuentasID)
            {
                if (!CalcularSaldoConDebeYHaberPorCuenta(L))
                {
                    return false;
                }
               
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balance fmrBalance = new Balance();
            fmrBalance.ShowDialog();
        }
    }
}
