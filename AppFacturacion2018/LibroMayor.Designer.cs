namespace AppFacturacion2018
{
    partial class LibroMayor
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
            this.cmBox_Cuenta = new System.Windows.Forms.ComboBox();
            this.cmBox_SubRubro = new System.Windows.Forms.ComboBox();
            this.txt_TotalDebeCuenta = new System.Windows.Forms.TextBox();
            this.txt_totalHaberCuenta = new System.Windows.Forms.TextBox();
            this.txt_CodigoCuenta = new System.Windows.Forms.TextBox();
            this.txt_totalSaldo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_TotalDebeCuenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalHaberCuenta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGV_Asientos = new System.Windows.Forms.DataGridView();
            this.DGV_Saldos = new System.Windows.Forms.DataGridView();
            this.cmBox_Rubro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DetalleCuenta = new System.Windows.Forms.TextBox();
            this.lbl_DetalleCuenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Saldos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBox_Cuenta
            // 
            this.cmBox_Cuenta.Enabled = false;
            this.cmBox_Cuenta.FormattingEnabled = true;
            this.cmBox_Cuenta.Location = new System.Drawing.Point(594, 66);
            this.cmBox_Cuenta.Name = "cmBox_Cuenta";
            this.cmBox_Cuenta.Size = new System.Drawing.Size(121, 21);
            this.cmBox_Cuenta.TabIndex = 1;
            this.cmBox_Cuenta.SelectionChangeCommitted += new System.EventHandler(this.cmBox_Cuenta_SelectionChangeCommitted);
            // 
            // cmBox_SubRubro
            // 
            this.cmBox_SubRubro.Enabled = false;
            this.cmBox_SubRubro.FormattingEnabled = true;
            this.cmBox_SubRubro.Location = new System.Drawing.Point(594, 39);
            this.cmBox_SubRubro.Name = "cmBox_SubRubro";
            this.cmBox_SubRubro.Size = new System.Drawing.Size(121, 21);
            this.cmBox_SubRubro.TabIndex = 2;
            this.cmBox_SubRubro.SelectionChangeCommitted += new System.EventHandler(this.cmBox_Rubro_SelectionChangeCommitted);
            // 
            // txt_TotalDebeCuenta
            // 
            this.txt_TotalDebeCuenta.Enabled = false;
            this.txt_TotalDebeCuenta.Location = new System.Drawing.Point(101, 298);
            this.txt_TotalDebeCuenta.Name = "txt_TotalDebeCuenta";
            this.txt_TotalDebeCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalDebeCuenta.TabIndex = 3;
            // 
            // txt_totalHaberCuenta
            // 
            this.txt_totalHaberCuenta.Enabled = false;
            this.txt_totalHaberCuenta.Location = new System.Drawing.Point(306, 298);
            this.txt_totalHaberCuenta.Name = "txt_totalHaberCuenta";
            this.txt_totalHaberCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_totalHaberCuenta.TabIndex = 4;
            // 
            // txt_CodigoCuenta
            // 
            this.txt_CodigoCuenta.Enabled = false;
            this.txt_CodigoCuenta.Location = new System.Drawing.Point(377, 41);
            this.txt_CodigoCuenta.Name = "txt_CodigoCuenta";
            this.txt_CodigoCuenta.Size = new System.Drawing.Size(83, 20);
            this.txt_CodigoCuenta.TabIndex = 5;
            // 
            // txt_totalSaldo
            // 
            this.txt_totalSaldo.Enabled = false;
            this.txt_totalSaldo.Location = new System.Drawing.Point(576, 298);
            this.txt_totalSaldo.Name = "txt_totalSaldo";
            this.txt_totalSaldo.Size = new System.Drawing.Size(100, 20);
            this.txt_totalSaldo.TabIndex = 6;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(328, 44);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Codigo.TabIndex = 7;
            this.lbl_Codigo.Text = "Codigo:";
            // 
            // lbl_TotalDebeCuenta
            // 
            this.lbl_TotalDebeCuenta.AutoSize = true;
            this.lbl_TotalDebeCuenta.Location = new System.Drawing.Point(32, 301);
            this.lbl_TotalDebeCuenta.Name = "lbl_TotalDebeCuenta";
            this.lbl_TotalDebeCuenta.Size = new System.Drawing.Size(63, 13);
            this.lbl_TotalDebeCuenta.TabIndex = 8;
            this.lbl_TotalDebeCuenta.Text = "Total Debe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cuenta:";
            // 
            // lbl_totalHaberCuenta
            // 
            this.lbl_totalHaberCuenta.AutoSize = true;
            this.lbl_totalHaberCuenta.Location = new System.Drawing.Point(234, 301);
            this.lbl_totalHaberCuenta.Name = "lbl_totalHaberCuenta";
            this.lbl_totalHaberCuenta.Size = new System.Drawing.Size(66, 13);
            this.lbl_totalHaberCuenta.TabIndex = 11;
            this.lbl_totalHaberCuenta.Text = "Total Haber:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saldo:";
            // 
            // DGV_Asientos
            // 
            this.DGV_Asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Asientos.Location = new System.Drawing.Point(7, 103);
            this.DGV_Asientos.Name = "DGV_Asientos";
            this.DGV_Asientos.Size = new System.Drawing.Size(459, 180);
            this.DGV_Asientos.TabIndex = 13;
            // 
            // DGV_Saldos
            // 
            this.DGV_Saldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Saldos.Location = new System.Drawing.Point(472, 103);
            this.DGV_Saldos.Name = "DGV_Saldos";
            this.DGV_Saldos.Size = new System.Drawing.Size(245, 180);
            this.DGV_Saldos.TabIndex = 14;
            // 
            // cmBox_Rubro
            // 
            this.cmBox_Rubro.FormattingEnabled = true;
            this.cmBox_Rubro.Location = new System.Drawing.Point(594, 12);
            this.cmBox_Rubro.Name = "cmBox_Rubro";
            this.cmBox_Rubro.Size = new System.Drawing.Size(121, 21);
            this.cmBox_Rubro.TabIndex = 15;
            this.cmBox_Rubro.SelectionChangeCommitted += new System.EventHandler(this.cmBox_TipoCuenta_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo  de Cuenta:";
            // 
            // txt_DetalleCuenta
            // 
            this.txt_DetalleCuenta.Enabled = false;
            this.txt_DetalleCuenta.Location = new System.Drawing.Point(101, 41);
            this.txt_DetalleCuenta.Name = "txt_DetalleCuenta";
            this.txt_DetalleCuenta.ReadOnly = true;
            this.txt_DetalleCuenta.Size = new System.Drawing.Size(221, 20);
            this.txt_DetalleCuenta.TabIndex = 18;
            // 
            // lbl_DetalleCuenta
            // 
            this.lbl_DetalleCuenta.AutoSize = true;
            this.lbl_DetalleCuenta.Location = new System.Drawing.Point(15, 44);
            this.lbl_DetalleCuenta.Name = "lbl_DetalleCuenta";
            this.lbl_DetalleCuenta.Size = new System.Drawing.Size(80, 13);
            this.lbl_DetalleCuenta.TabIndex = 19;
            this.lbl_DetalleCuenta.Text = "Detalle Cuenta:";
            // 
            // LibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 329);
            this.Controls.Add(this.txt_DetalleCuenta);
            this.Controls.Add(this.lbl_DetalleCuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmBox_Rubro);
            this.Controls.Add(this.DGV_Saldos);
            this.Controls.Add(this.DGV_Asientos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_totalHaberCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_TotalDebeCuenta);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.txt_totalSaldo);
            this.Controls.Add(this.txt_CodigoCuenta);
            this.Controls.Add(this.txt_totalHaberCuenta);
            this.Controls.Add(this.txt_TotalDebeCuenta);
            this.Controls.Add(this.cmBox_SubRubro);
            this.Controls.Add(this.cmBox_Cuenta);
            this.Name = "LibroMayor";
            this.Text = "LibroMayor";
            this.Load += new System.EventHandler(this.LibroMayor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Saldos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBox_Cuenta;
        private System.Windows.Forms.ComboBox cmBox_SubRubro;
        private System.Windows.Forms.TextBox txt_TotalDebeCuenta;
        private System.Windows.Forms.TextBox txt_totalHaberCuenta;
        private System.Windows.Forms.TextBox txt_CodigoCuenta;
        private System.Windows.Forms.TextBox txt_totalSaldo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_TotalDebeCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totalHaberCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGV_Asientos;
        private System.Windows.Forms.DataGridView DGV_Saldos;
        private System.Windows.Forms.ComboBox cmBox_Rubro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DetalleCuenta;
        private System.Windows.Forms.Label lbl_DetalleCuenta;
    }
}