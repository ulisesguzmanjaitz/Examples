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
    public partial class Clientes : Form
    {
        DB DB = new DB();
        public Clientes()
        {
            InitializeComponent();
            DB.IniciarConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipoactividad = "";
            string ssql = "Insert into persona (nombre,apellido,cuil_cuit,dni) ";
            ssql = ssql + "values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "') ";
            DB.Ejecutar(ssql);

            string idpersona = DB.LeerDato("idpersona", "select top 1 idpersona from persona order by idpersona desc");

            if (rb_RI.Checked)
            {
                tipoactividad = "RI";
            }else { tipoactividad = "CF";}

            ssql = "insert into cliente(razon,refidtipoactividad,refidpersona) ";
            ssql = ssql + "values ('" + textBox2.Text + " " + textBox1.Text + "','" + tipoactividad + "'," + idpersona + ") ";
            DB.Ejecutar(ssql);

        }

        public void CalcularCuil(string DNI,string Genero)
        {
            long num = long.Parse(Genero + DNI);
            long numAux = num;
            long[] numDNI = new long[10];
            long[] numResultado = new long[10];
            long[] numProducto = new long[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            long total = 0;

            for (int i = 9; i >= 0; i--) 
            {
                numDNI[i] = (numAux % 10);
                numAux = (numAux / 10);
                numResultado[i] = (numDNI[i] * numProducto[i]);
                total = total + numResultado[i];
            }

            total = 11-(total - ((total / 11)*11));
            num =  Convert.ToInt64(Convert.ToString(num) + Convert.ToString(total));
            textBox4.Text =  Convert.ToString(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tipo ="";
            if (rb_Empresa.Checked){tipo = "30";}
            if (rb_Femenino.Checked){tipo = "27";}
            if (rb_Masculino.Checked){tipo = "20";}
            CalcularCuil(textBox3.Text, tipo);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
