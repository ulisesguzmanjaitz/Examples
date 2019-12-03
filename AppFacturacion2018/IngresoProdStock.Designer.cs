namespace AppFacturacion2018
{
    partial class IngresoProdStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEntradaUnidad = new System.Windows.Forms.TextBox();
            this.txtEntradaPrecio = new System.Windows.Forms.TextBox();
            this.txtEntradaTotal = new System.Windows.Forms.TextBox();
            this.lblEntradaUnidad = new System.Windows.Forms.Label();
            this.lblEntradaPrecio = new System.Windows.Forms.Label();
            this.lblEntradaTotal = new System.Windows.Forms.Label();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdSalida = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtEntradaUnidad
            // 
            this.txtEntradaUnidad.Location = new System.Drawing.Point(15, 103);
            this.txtEntradaUnidad.Name = "txtEntradaUnidad";
            this.txtEntradaUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaUnidad.TabIndex = 0;
            // 
            // txtEntradaPrecio
            // 
            this.txtEntradaPrecio.Location = new System.Drawing.Point(121, 103);
            this.txtEntradaPrecio.Name = "txtEntradaPrecio";
            this.txtEntradaPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaPrecio.TabIndex = 1;
            // 
            // txtEntradaTotal
            // 
            this.txtEntradaTotal.Location = new System.Drawing.Point(227, 103);
            this.txtEntradaTotal.Name = "txtEntradaTotal";
            this.txtEntradaTotal.ReadOnly = true;
            this.txtEntradaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaTotal.TabIndex = 2;
            // 
            // lblEntradaUnidad
            // 
            this.lblEntradaUnidad.AutoSize = true;
            this.lblEntradaUnidad.Location = new System.Drawing.Point(18, 87);
            this.lblEntradaUnidad.Name = "lblEntradaUnidad";
            this.lblEntradaUnidad.Size = new System.Drawing.Size(84, 13);
            this.lblEntradaUnidad.TabIndex = 8;
            this.lblEntradaUnidad.Text = "Entrada Unidad:";
            // 
            // lblEntradaPrecio
            // 
            this.lblEntradaPrecio.AutoSize = true;
            this.lblEntradaPrecio.Location = new System.Drawing.Point(123, 87);
            this.lblEntradaPrecio.Name = "lblEntradaPrecio";
            this.lblEntradaPrecio.Size = new System.Drawing.Size(80, 13);
            this.lblEntradaPrecio.TabIndex = 9;
            this.lblEntradaPrecio.Text = "Entrada Precio:";
            // 
            // lblEntradaTotal
            // 
            this.lblEntradaTotal.AutoSize = true;
            this.lblEntradaTotal.Location = new System.Drawing.Point(228, 87);
            this.lblEntradaTotal.Name = "lblEntradaTotal";
            this.lblEntradaTotal.Size = new System.Drawing.Size(74, 13);
            this.lblEntradaTotal.TabIndex = 10;
            this.lblEntradaTotal.Text = "Entrada Total:";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Checked = true;
            this.rbEntrada.Location = new System.Drawing.Point(17, 50);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 11;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarProd.Location = new System.Drawing.Point(15, 163);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarProd.TabIndex = 13;
            this.txtBuscarProd.TextChanged += new System.EventHandler(this.txtBuscarProd_TextChanged);
            this.txtBuscarProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProd_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(126, 163);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(201, 20);
            this.txtDescProd.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripción:";
            // 
            // rdSalida
            // 
            this.rdSalida.AutoSize = true;
            this.rdSalida.Location = new System.Drawing.Point(85, 50);
            this.rdSalida.Name = "rdSalida";
            this.rdSalida.Size = new System.Drawing.Size(54, 17);
            this.rdSalida.TabIndex = 12;
            this.rdSalida.Text = "Salida";
            this.rdSalida.UseVisualStyleBackColor = true;
            this.rdSalida.CheckedChanged += new System.EventHandler(this.rdSalida_CheckedChanged);
            // 
            // IngresoProdStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this.rdSalida);
            this.Controls.Add(this.rbEntrada);
            this.Controls.Add(this.lblEntradaTotal);
            this.Controls.Add(this.lblEntradaPrecio);
            this.Controls.Add(this.lblEntradaUnidad);
            this.Controls.Add(this.txtEntradaTotal);
            this.Controls.Add(this.txtEntradaPrecio);
            this.Controls.Add(this.txtEntradaUnidad);
            this.Name = "IngresoProdStock";
            this.Text = "IngresoProdStock";
            this.Load += new System.EventHandler(this.IngresoProdStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaUnidad;
        private System.Windows.Forms.TextBox txtEntradaPrecio;
        private System.Windows.Forms.TextBox txtEntradaTotal;
        private System.Windows.Forms.Label lblEntradaUnidad;
        private System.Windows.Forms.Label lblEntradaPrecio;
        private System.Windows.Forms.Label lblEntradaTotal;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdSalida;
    }
}