namespace AppFacturacion2018
{
    partial class BalanceDetalleCuentas
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
            this.lbl_Activos = new System.Windows.Forms.Label();
            this.lb_TotalActivos = new System.Windows.Forms.Label();
            this.txt_TotalCuentasActivos = new System.Windows.Forms.TextBox();
            this.DGV_Cuentas_Activos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cuentas_Activos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Activos
            // 
            this.lbl_Activos.AutoSize = true;
            this.lbl_Activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activos.Location = new System.Drawing.Point(44, 48);
            this.lbl_Activos.Name = "lbl_Activos";
            this.lbl_Activos.Size = new System.Drawing.Size(49, 13);
            this.lbl_Activos.TabIndex = 27;
            this.lbl_Activos.Text = "Activos";
            // 
            // lb_TotalActivos
            // 
            this.lb_TotalActivos.AutoSize = true;
            this.lb_TotalActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalActivos.Location = new System.Drawing.Point(110, 197);
            this.lb_TotalActivos.Name = "lb_TotalActivos";
            this.lb_TotalActivos.Size = new System.Drawing.Size(44, 13);
            this.lb_TotalActivos.TabIndex = 26;
            this.lb_TotalActivos.Text = "Total: ";
            // 
            // txt_TotalCuentasActivos
            // 
            this.txt_TotalCuentasActivos.Location = new System.Drawing.Point(156, 194);
            this.txt_TotalCuentasActivos.Name = "txt_TotalCuentasActivos";
            this.txt_TotalCuentasActivos.Size = new System.Drawing.Size(89, 20);
            this.txt_TotalCuentasActivos.TabIndex = 25;
            // 
            // DGV_Cuentas_Activos
            // 
            this.DGV_Cuentas_Activos.AllowUserToAddRows = false;
            this.DGV_Cuentas_Activos.AllowUserToDeleteRows = false;
            this.DGV_Cuentas_Activos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Cuentas_Activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cuentas_Activos.Location = new System.Drawing.Point(39, 71);
            this.DGV_Cuentas_Activos.Name = "DGV_Cuentas_Activos";
            this.DGV_Cuentas_Activos.ReadOnly = true;
            this.DGV_Cuentas_Activos.RowHeadersVisible = false;
            this.DGV_Cuentas_Activos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Cuentas_Activos.Size = new System.Drawing.Size(206, 120);
            this.DGV_Cuentas_Activos.TabIndex = 24;
            // 
            // BalanceDetalleCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_Activos);
            this.Controls.Add(this.lb_TotalActivos);
            this.Controls.Add(this.txt_TotalCuentasActivos);
            this.Controls.Add(this.DGV_Cuentas_Activos);
            this.Name = "BalanceDetalleCuentas";
            this.Text = "BalanceDetalleCuentas";
            this.Load += new System.EventHandler(this.BalanceDetalleCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cuentas_Activos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Activos;
        private System.Windows.Forms.Label lb_TotalActivos;
        private System.Windows.Forms.TextBox txt_TotalCuentasActivos;
        private System.Windows.Forms.DataGridView DGV_Cuentas_Activos;
    }
}