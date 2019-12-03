using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AppFacturacion2018
{
    class DB
    {
        //Consola
        public SqlConnection ConexionDB;
        public SqlCommand Orden;
        public SqlDataReader Lector;

        public void IniciarConexion()
        {
            string strConexion = "Data Source=PCCASA-PC\\SQLEXPRESS;" +
                            "Initial Catalog=Facturacion;Integrated Security=True";

            ConexionDB = new SqlConnection(strConexion);
            
        }

        //metodo para cargar la coleccion de datos para el autocomplete
        public AutoCompleteStringCollection Autocomplete(string sql,string campo)
        {
            DataTable dt = new DataTable();
            Orden = new SqlCommand(sql, ConexionDB);
            SqlDataAdapter adap = new SqlDataAdapter(Orden);
            adap.Fill(dt);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo]));
            }
            return coleccion;
        }

        public void CargarDatos(string consulta, string campo, TextBox txtBuscar)
        {
            ConexionDB.Open();
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            //string consulta = @"Select distinct [nombre] from [estudiante]";
            SqlCommand cmd = new SqlCommand(consulta, ConexionDB);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    namesCollection.Add(dr[campo].ToString());

            }

            dr.Close();
            ConexionDB.Close();

            txtBuscar.AutoCompleteMode = AutoCompleteMode.Append;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscar.AutoCompleteCustomSource = namesCollection;
        }


        public void Autocompletar(string consulta, string campo, TextBox txtBuscar)
        {
            ConexionDB.Open();

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(consulta, ConexionDB);           
            cmd.Parameters.Add(new SqlParameter(campo, "%" + txtBuscar.Text + "%"));
            //cmd.EndExecuteNonQuery();
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                col.Add(dr.GetString(0));
            }
 

            //dr.Close();
            txtBuscar.AutoCompleteCustomSource = col;
            ConexionDB.Close();

            //txtBuscar.AutoCompleteMode = AutoCompleteMode.Append;
            //txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtBuscar.AutoCompleteCustomSource = namesCollection;
        }

        public void Ejecutar(string sql)
        {
            ConexionDB.Open();
            Orden = new SqlCommand(sql, ConexionDB);
            Orden.ExecuteNonQuery();
            ConexionDB.Close();
        }

        //Carga del data grid view
        public void CargaDGV(DataGridView dgv, string sql, string tabla)
        {
            ConexionDB.Open();
            SqlDataAdapter dstabla = new SqlDataAdapter(sql, ConexionDB);
            DataSet dtabla = new DataSet();
            dstabla.Fill(dtabla, tabla);
            dgv.DataSource = dtabla;
            dgv.DataMember = tabla;
            ConexionDB.Close();
        }

        public void CargarCB(string campo, string sql, ComboBox cb)
        {
            ConexionDB.Open();
            Orden = new SqlCommand(sql, ConexionDB);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                cb.Items.Add(Lector[campo].ToString());
            }
            Lector.Close();
            ConexionDB.Close();
        }

        public void CargarLB(string campo, string sql, ListBox lb)
        {
            ConexionDB.Open();
            Orden = new SqlCommand(sql, ConexionDB);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                lb.Items.Add(Lector[campo].ToString());
            }
            Lector.Close();
            ConexionDB.Close();
        }

        public string LeerDato(string campo, string sql)
        {
            IniciarConexion();
            ConexionDB.Open();
            string dato;
            Orden = new SqlCommand(sql, ConexionDB);
            Lector = Orden.ExecuteReader();
            Lector.Read();
            try
            {
                dato = Lector[campo].ToString();
                Lector.Close();
                ConexionDB.Close();
                return (dato);
            }
            catch
            {
                Lector.Close();
                ConexionDB.Close();
                return ("-1");
            }
        }
    }
    
}