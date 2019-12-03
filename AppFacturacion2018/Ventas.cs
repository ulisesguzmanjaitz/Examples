using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AppFacturacion2018
{
    public partial class Ventas : Form
    {
        private Image facturaModelo;

        public Ventas()
        {
            InitializeComponent();
            facturaModelo = AppFacturacion2018.Properties.Resources.Template_Factura;
        }
        DB DB = new DB();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DB.IniciarConexion();
            DB.Autocompletar("select nombre from dbo.producto", "nombre", textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string descripcion = DB.LeerDato("descripción", "select descripción from dbo.producto where nombre ='" + textBox1.Text + "'");
            string IdProd = DB.LeerDato("idproducto", "select idproducto from dbo.producto where nombre ='" + textBox1.Text + "'");
            string Precio = DB.LeerDato("Stock_Precio", "Select top 1 Stock_Precio from dbo.fichaStock where idProducto = " + IdProd + " order by fecha desc");
            string Total = "0";

            Total = (float.Parse(Precio) * float.Parse(textBox2.Text)).ToString();

            dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, textBox2.Text, descripcion, Precio.Replace(',', '.'), Total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string refidproducto = DB.LeerDato("idproducto", "select idproducto from dbo.producto where nombre ='" + textBox1.Text + "'");
            string PrecioV = DB.LeerDato("Stock_Precio", "Select top 1 Stock_Precio from dbo.fichaStock where idProducto = " + refidproducto + " order by fecha desc");
            string CantidadV = "0";

            string tipoPago = "EFECTIVO";
            string idpersona = DB.LeerDato("idpersona", "select idpersona from dbo.persona where NomApe ='" + textBox3.Text + "'");
            string nomApe = DB.LeerDato("NomApe", "select NomApe from dbo.persona where NomApe ='" + textBox3.Text + "'");
            string cuil_cuit = DB.LeerDato("cuil_cuit", "select cuil_cuit from dbo.persona where NomApe ='" + textBox3.Text + "'");
            string refidcliente = DB.LeerDato("idcliente", "select idcliente from dbo.cliente where refidpersona ='" + idpersona + "'");
            string refidtipoPago = DB.LeerDato("tipoPago", "select tipoPago from dbo.modoPago where tipoPago ='" + tipoPago + "'");


            string ssql = "INSERT INTO [dbo].[factura] ([fecha],[refidcliente],[refidtipoPago]) ";
            ssql = ssql + "VALUES(getdate(),'" + refidcliente + "','" + refidtipoPago + "') ";
            DB.Ejecutar(ssql);

            string refidfactura = DB.LeerDato("idfactura", "select top 1 idfactura from dbo.factura where refidcliente = " + refidcliente + "order by idfactura desc ");
            string tipoactividad = DB.LeerDato("refidtipoactividad", "select refidtipoactividad from cliente where idcliente = " + refidcliente + " ");
            string descActividad = DB.LeerDato("descripcion", "select descripcion from actividad where tipo = '" + tipoactividad + "' ");

            CantidadV = (float.Parse(PrecioV) * float.Parse(textBox2.Text)).ToString();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    PrecioV = row.Cells[2].Value.ToString();
                    CantidadV = row.Cells[0].Value.ToString();

                    ssql = "INSERT INTO [dbo].[detalle] ([precioV],[cantidadV],[refidfactura],[refidproducto]) ";
                    ssql = ssql + "VALUES(" + PrecioV + "," + CantidadV + "," + refidfactura + "," + refidproducto + ") ";
                    DB.Ejecutar(ssql);
                }
            }


            int[] x = { 20, 150, 370 , 440 };
            int firstY = 308;
            int y = 308;
            int total_X = 455;
            int total_Y = 655;
            double Total = 0;
            double SubTotal = 0;
            double PorcentajeIVA = 0;
            Image facturaActual = facturaModelo;
            Graphics g = Graphics.FromImage(facturaActual);
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;
            formatter.Alignment = StringAlignment.Center;
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font font3 = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Font font2 = new Font("Microsoft Sans Serif", 28, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

      
            g.DrawString(nomApe, font, brush, new Point(150, 170), formatter);
            g.DrawString(cuil_cuit, font, brush, new Point(400,230), formatter);
            g.DrawString("0000"+ refidfactura, font, brush, new Point(400, 255), formatter);
            g.DrawString(descActividad, font, brush, new Point(150, 255), formatter);

            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                        g.DrawString(dataGridView1.Rows[i - 1].Cells[j].Value.ToString(), font, brush, new Point(x[j], firstY), formatter);
                    else
                        g.DrawString(dataGridView1.Rows[i - 1].Cells[j].Value.ToString(), font, brush, new Point(x[j], y), formatter);
                }

                y += 24;
                Total += Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[3].Value.ToString());
            }

            font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            g.DrawString(Total.ToString(),font,brush,new Point(total_X,total_Y),formatter);
            

            if (tipoactividad == "RI")
            {
                g.DrawString("A", font2, brush, new Point(265, 30), formatter);
                SubTotal= Total-((Total * 21) / 100);
                PorcentajeIVA = ((Total * 21) / 100);
                g.DrawString("21", font, brush, new Point(390, 615), formatter);
                g.DrawString(SubTotal.ToString(), font3, brush, new Point(455, 600), formatter);
                g.DrawString(PorcentajeIVA.ToString(), font3, brush, new Point(455, 625), formatter);
            }
            else
            {
                g.DrawString("C", font, brush, new Point(265, 30), formatter);
                
            }

            Form f2 = new Form();
            f2.Show();
            f2.Validate();
            f2.AutoScroll= true;
            PictureBox pbox = new PictureBox();
            pbox.Image = facturaActual;
            pbox.SizeMode = PictureBoxSizeMode.AutoSize;
            f2.Width = pbox.Width + 17;
            f2.Height = pbox.Height + 37;
            f2.Controls.Add(pbox);

            imprimir(facturaActual);
        
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DB.IniciarConexion();
            DB.Autocompletar("select NomApe from persona", "NomApe", textBox3);
        }

        private Boolean imprimir(Image facturaActual) 
        { 
            try 
            { 
                PrintDocument pd = new PrintDocument(); 
                pd.PrintPage += (sender, e) => e.Graphics.DrawImage(facturaActual, 0, 0); 
                pd.Print(); 
                return true; 
            } 
            catch (Exception) 
            { 
                MessageBox.Show("Error al imprimir la factura. Compruebe que la impresora esté conectada y encendida", "Advertencia"); 
                return false; 
            } 
        }
    }
}
