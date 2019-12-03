namespace AppFacturacion2018
{
    partial class Cuentas
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
            this.btn_CerrarAsiento = new System.Windows.Forms.Button();
            this.cmBox_Rubro = new System.Windows.Forms.ComboBox();
            this.DGV_Asientos = new System.Windows.Forms.DataGridView();
            this.N_Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle_Cueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmBox_SubRubro = new System.Windows.Forms.ComboBox();
            this.btn_LibroMayor = new System.Windows.Forms.Button();
            this.txt_TotalDebeCuenta = new System.Windows.Forms.TextBox();
            this.txt_totalHaberCuenta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_MontoCuenta = new System.Windows.Forms.TextBox();
            this.btn_AgregarDetalle = new System.Windows.Forms.Button();
            this.txt_CodigoCuenta = new System.Windows.Forms.TextBox();
            this.cmBox_Transaccion = new System.Windows.Forms.ComboBox();
            this.cmBox_Cuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_DetalleCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CerrarAsiento
            // 
            this.btn_CerrarAsiento.Location = new System.Drawing.Point(491, 289);
            this.btn_CerrarAsiento.Name = "btn_CerrarAsiento";
            this.btn_CerrarAsiento.Size = new System.Drawing.Size(102, 23);
            this.btn_CerrarAsiento.TabIndex = 1;
            this.btn_CerrarAsiento.Text = "Cerrar Asiento";
            this.btn_CerrarAsiento.UseVisualStyleBackColor = true;
            this.btn_CerrarAsiento.Click += new System.EventHandler(this.btn_CerrarAsiento_Click);
            // 
            // cmBox_Rubro
            // 
            this.cmBox_Rubro.FormattingEnabled = true;
            this.cmBox_Rubro.Location = new System.Drawing.Point(20, 16);
            this.cmBox_Rubro.Name = "cmBox_Rubro";
            this.cmBox_Rubro.Size = new System.Drawing.Size(142, 21);
            this.cmBox_Rubro.TabIndex = 2;
            this.cmBox_Rubro.Text = "Seleccione Tipo Cuenta";
            this.cmBox_Rubro.SelectionChangeCommitted += new System.EventHandler(this.cmBox_TipoCuenta_SelectionChangeCommitted);
            // 
            // DGV_Asientos
            // 
            this.DGV_Asientos.AllowUserToAddRows = false;
            this.DGV_Asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Asientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Asiento,
            this.Codigo,
            this.Detalle_Cueta,
            this.Debe,
            this.Haber,
            this.CuentaID});
            this.DGV_Asientos.Location = new System.Drawing.Point(29, 144);
            this.DGV_Asientos.Name = "DGV_Asientos";
            this.DGV_Asientos.Size = new System.Drawing.Size(693, 131);
            this.DGV_Asientos.TabIndex = 3;
            // 
            // N_Asiento
            // 
            this.N_Asiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.N_Asiento.HeaderText = "Nº Asiento";
            this.N_Asiento.Name = "N_Asiento";
            this.N_Asiento.ReadOnly = true;
            this.N_Asiento.Width = 82;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Detalle_Cueta
            // 
            this.Detalle_Cueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Detalle_Cueta.HeaderText = "Detalle Cueta";
            this.Detalle_Cueta.Name = "Detalle_Cueta";
            this.Detalle_Cueta.ReadOnly = true;
            this.Detalle_Cueta.Width = 96;
            // 
            // Debe
            // 
            this.Debe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            this.Debe.Width = 58;
            // 
            // Haber
            // 
            this.Haber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            this.Haber.Width = 61;
            // 
            // CuentaID
            // 
            this.CuentaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CuentaID.HeaderText = "CuentaID";
            this.CuentaID.Name = "CuentaID";
            this.CuentaID.Visible = false;
            // 
            // cmBox_SubRubro
            // 
            this.cmBox_SubRubro.Enabled = false;
            this.cmBox_SubRubro.FormattingEnabled = true;
            this.cmBox_SubRubro.Location = new System.Drawing.Point(20, 43);
            this.cmBox_SubRubro.Name = "cmBox_SubRubro";
            this.cmBox_SubRubro.Size = new System.Drawing.Size(142, 21);
            this.cmBox_SubRubro.TabIndex = 4;
            this.cmBox_SubRubro.Text = "Seleccione Rubro";
            this.cmBox_SubRubro.SelectionChangeCommitted += new System.EventHandler(this.cmBox_Rubro_SelectionChangeCommitted);
            // 
            // btn_LibroMayor
            // 
            this.btn_LibroMayor.Location = new System.Drawing.Point(620, 288);
            this.btn_LibroMayor.Name = "btn_LibroMayor";
            this.btn_LibroMayor.Size = new System.Drawing.Size(102, 23);
            this.btn_LibroMayor.TabIndex = 5;
            this.btn_LibroMayor.Text = "LibroMayor";
            this.btn_LibroMayor.UseVisualStyleBackColor = true;
            this.btn_LibroMayor.Click += new System.EventHandler(this.btn_CerrarLibroDiario_Click);
            // 
            // txt_TotalDebeCuenta
            // 
            this.txt_TotalDebeCuenta.Location = new System.Drawing.Point(95, 290);
            this.txt_TotalDebeCuenta.Name = "txt_TotalDebeCuenta";
            this.txt_TotalDebeCuenta.ReadOnly = true;
            this.txt_TotalDebeCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalDebeCuenta.TabIndex = 6;
            // 
            // txt_totalHaberCuenta
            // 
            this.txt_totalHaberCuenta.Location = new System.Drawing.Point(289, 290);
            this.txt_totalHaberCuenta.Name = "txt_totalHaberCuenta";
            this.txt_totalHaberCuenta.ReadOnly = true;
            this.txt_totalHaberCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_totalHaberCuenta.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txt_MontoCuenta
            // 
            this.txt_MontoCuenta.Enabled = false;
            this.txt_MontoCuenta.Location = new System.Drawing.Point(53, 67);
            this.txt_MontoCuenta.Name = "txt_MontoCuenta";
            this.txt_MontoCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_MontoCuenta.TabIndex = 10;
            this.txt_MontoCuenta.TextChanged += new System.EventHandler(this.txt_MontoCuenta_TextChanged);
            // 
            // btn_AgregarDetalle
            // 
            this.btn_AgregarDetalle.Enabled = false;
            this.btn_AgregarDetalle.Location = new System.Drawing.Point(378, 65);
            this.btn_AgregarDetalle.Name = "btn_AgregarDetalle";
            this.btn_AgregarDetalle.Size = new System.Drawing.Size(102, 23);
            this.btn_AgregarDetalle.TabIndex = 11;
            this.btn_AgregarDetalle.Text = "Agregar Detalle";
            this.btn_AgregarDetalle.UseVisualStyleBackColor = true;
            this.btn_AgregarDetalle.Click += new System.EventHandler(this.btn_AgregarDetalle_Click);
            // 
            // txt_CodigoCuenta
            // 
            this.txt_CodigoCuenta.Location = new System.Drawing.Point(380, 15);
            this.txt_CodigoCuenta.Name = "txt_CodigoCuenta";
            this.txt_CodigoCuenta.ReadOnly = true;
            this.txt_CodigoCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_CodigoCuenta.TabIndex = 12;
            // 
            // cmBox_Transaccion
            // 
            this.cmBox_Transaccion.Enabled = false;
            this.cmBox_Transaccion.FormattingEnabled = true;
            this.cmBox_Transaccion.Location = new System.Drawing.Point(170, 66);
            this.cmBox_Transaccion.Name = "cmBox_Transaccion";
            this.cmBox_Transaccion.Size = new System.Drawing.Size(145, 21);
            this.cmBox_Transaccion.TabIndex = 15;
            this.cmBox_Transaccion.Text = "Seleccione Transacción";
            this.cmBox_Transaccion.SelectedIndexChanged += new System.EventHandler(this.cmBox_Transaccion_SelectedIndexChanged);
            // 
            // cmBox_Cuenta
            // 
            this.cmBox_Cuenta.Enabled = false;
            this.cmBox_Cuenta.FormattingEnabled = true;
            this.cmBox_Cuenta.Location = new System.Drawing.Point(20, 70);
            this.cmBox_Cuenta.Name = "cmBox_Cuenta";
            this.cmBox_Cuenta.Size = new System.Drawing.Size(142, 21);
            this.cmBox_Cuenta.TabIndex = 16;
            this.cmBox_Cuenta.Text = "Seleccione Cuenta";
            this.cmBox_Cuenta.SelectionChangeCommitted += new System.EventHandler(this.CmBox_Cuenta_SelectionChangeCommitted);
            this.cmBox_Cuenta.SelectedIndexChanged += new System.EventHandler(this.cmBox_Cuenta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total Debe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AgregarDetalle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_DetalleCuenta);
            this.groupBox1.Controls.Add(this.txt_MontoCuenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_CodigoCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmBox_Transaccion);
            this.groupBox1.Location = new System.Drawing.Point(29, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txt_DetalleCuenta
            // 
            this.txt_DetalleCuenta.Location = new System.Drawing.Point(93, 15);
            this.txt_DetalleCuenta.Name = "txt_DetalleCuenta";
            this.txt_DetalleCuenta.ReadOnly = true;
            this.txt_DetalleCuenta.Size = new System.Drawing.Size(221, 20);
            this.txt_DetalleCuenta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Detalle Cuenta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmBox_SubRubro);
            this.groupBox2.Controls.Add(this.cmBox_Cuenta);
            this.groupBox2.Controls.Add(this.cmBox_Rubro);
            this.groupBox2.Location = new System.Drawing.Point(544, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Haber:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_totalHaberCuenta);
            this.Controls.Add(this.txt_TotalDebeCuenta);
            this.Controls.Add(this.btn_LibroMayor);
            this.Controls.Add(this.DGV_Asientos);
            this.Controls.Add(this.btn_CerrarAsiento);
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CerrarAsiento;
        private System.Windows.Forms.ComboBox cmBox_Rubro;
        private System.Windows.Forms.DataGridView DGV_Asientos;
        private System.Windows.Forms.ComboBox cmBox_SubRubro;
        private System.Windows.Forms.Button btn_LibroMayor;
        private System.Windows.Forms.TextBox txt_TotalDebeCuenta;
        private System.Windows.Forms.TextBox txt_totalHaberCuenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_MontoCuenta;
        private System.Windows.Forms.Button btn_AgregarDetalle;
        private System.Windows.Forms.TextBox txt_CodigoCuenta;
        private System.Windows.Forms.ComboBox cmBox_Transaccion;
        private System.Windows.Forms.ComboBox cmBox_Cuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DetalleCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle_Cueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaID;
        private System.Windows.Forms.Button button1;
    }
}