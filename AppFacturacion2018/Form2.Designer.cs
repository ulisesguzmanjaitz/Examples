namespace AppFacturacion2018
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Egresos = new System.Windows.Forms.Label();
            this.lbl_Ingresos = new System.Windows.Forms.Label();
            this.lbl_PatrimonioNeto = new System.Windows.Forms.Label();
            this.lbl_Pasivos = new System.Windows.Forms.Label();
            this.lbl_Activos = new System.Windows.Forms.Label();
            this.txt_TotalEgresos = new System.Windows.Forms.TextBox();
            this.lbl_TotalEgresos = new System.Windows.Forms.Label();
            this.lbl_TotalPatrimonioNeto = new System.Windows.Forms.Label();
            this.lbl_TotalIngresos = new System.Windows.Forms.Label();
            this.lbl_TotalPasivo = new System.Windows.Forms.Label();
            this.lb_TotalActivos = new System.Windows.Forms.Label();
            this.txt_TotalIngresos = new System.Windows.Forms.TextBox();
            this.txt_TotalPatrimonioNeto = new System.Windows.Forms.TextBox();
            this.txt_TotalPasivo = new System.Windows.Forms.TextBox();
            this.txt_TotalActivos = new System.Windows.Forms.TextBox();
            this.DGV_Egresos = new System.Windows.Forms.DataGridView();
            this.DGV_Ingresos = new System.Windows.Forms.DataGridView();
            this.DGV_PatrimonioNeto = new System.Windows.Forms.DataGridView();
            this.DGV_Pasivos = new System.Windows.Forms.DataGridView();
            this.DGV_Activos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Egresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PatrimonioNeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pasivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Activos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Recargar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Egresos
            // 
            this.lbl_Egresos.AutoSize = true;
            this.lbl_Egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Egresos.Location = new System.Drawing.Point(554, 209);
            this.lbl_Egresos.Name = "lbl_Egresos";
            this.lbl_Egresos.Size = new System.Drawing.Size(52, 13);
            this.lbl_Egresos.TabIndex = 48;
            this.lbl_Egresos.Text = "Egresos";
            // 
            // lbl_Ingresos
            // 
            this.lbl_Ingresos.AutoSize = true;
            this.lbl_Ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingresos.Location = new System.Drawing.Point(554, 10);
            this.lbl_Ingresos.Name = "lbl_Ingresos";
            this.lbl_Ingresos.Size = new System.Drawing.Size(55, 13);
            this.lbl_Ingresos.TabIndex = 47;
            this.lbl_Ingresos.Text = "Ingresos";
            // 
            // lbl_PatrimonioNeto
            // 
            this.lbl_PatrimonioNeto.AutoSize = true;
            this.lbl_PatrimonioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PatrimonioNeto.Location = new System.Drawing.Point(316, 209);
            this.lbl_PatrimonioNeto.Name = "lbl_PatrimonioNeto";
            this.lbl_PatrimonioNeto.Size = new System.Drawing.Size(97, 13);
            this.lbl_PatrimonioNeto.TabIndex = 46;
            this.lbl_PatrimonioNeto.Text = "Patrimonio Neto";
            // 
            // lbl_Pasivos
            // 
            this.lbl_Pasivos.AutoSize = true;
            this.lbl_Pasivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pasivos.Location = new System.Drawing.Point(316, 13);
            this.lbl_Pasivos.Name = "lbl_Pasivos";
            this.lbl_Pasivos.Size = new System.Drawing.Size(51, 13);
            this.lbl_Pasivos.TabIndex = 45;
            this.lbl_Pasivos.Text = "Pasivos";
            // 
            // lbl_Activos
            // 
            this.lbl_Activos.AutoSize = true;
            this.lbl_Activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activos.Location = new System.Drawing.Point(89, 13);
            this.lbl_Activos.Name = "lbl_Activos";
            this.lbl_Activos.Size = new System.Drawing.Size(49, 13);
            this.lbl_Activos.TabIndex = 44;
            this.lbl_Activos.Text = "Activos";
            // 
            // txt_TotalEgresos
            // 
            this.txt_TotalEgresos.Location = new System.Drawing.Point(666, 357);
            this.txt_TotalEgresos.Name = "txt_TotalEgresos";
            this.txt_TotalEgresos.Size = new System.Drawing.Size(89, 20);
            this.txt_TotalEgresos.TabIndex = 43;
            // 
            // lbl_TotalEgresos
            // 
            this.lbl_TotalEgresos.AutoSize = true;
            this.lbl_TotalEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalEgresos.Location = new System.Drawing.Point(618, 360);
            this.lbl_TotalEgresos.Name = "lbl_TotalEgresos";
            this.lbl_TotalEgresos.Size = new System.Drawing.Size(44, 13);
            this.lbl_TotalEgresos.TabIndex = 42;
            this.lbl_TotalEgresos.Text = "Total: ";
            // 
            // lbl_TotalPatrimonioNeto
            // 
            this.lbl_TotalPatrimonioNeto.AutoSize = true;
            this.lbl_TotalPatrimonioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPatrimonioNeto.Location = new System.Drawing.Point(382, 358);
            this.lbl_TotalPatrimonioNeto.Name = "lbl_TotalPatrimonioNeto";
            this.lbl_TotalPatrimonioNeto.Size = new System.Drawing.Size(44, 13);
            this.lbl_TotalPatrimonioNeto.TabIndex = 41;
            this.lbl_TotalPatrimonioNeto.Text = "Total: ";
            // 
            // lbl_TotalIngresos
            // 
            this.lbl_TotalIngresos.AutoSize = true;
            this.lbl_TotalIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalIngresos.Location = new System.Drawing.Point(621, 161);
            this.lbl_TotalIngresos.Name = "lbl_TotalIngresos";
            this.lbl_TotalIngresos.Size = new System.Drawing.Size(44, 13);
            this.lbl_TotalIngresos.TabIndex = 40;
            this.lbl_TotalIngresos.Text = "Total: ";
            // 
            // lbl_TotalPasivo
            // 
            this.lbl_TotalPasivo.AutoSize = true;
            this.lbl_TotalPasivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPasivo.Location = new System.Drawing.Point(382, 162);
            this.lbl_TotalPasivo.Name = "lbl_TotalPasivo";
            this.lbl_TotalPasivo.Size = new System.Drawing.Size(44, 13);
            this.lbl_TotalPasivo.TabIndex = 39;
            this.lbl_TotalPasivo.Text = "Total: ";
            // 
            // lb_TotalActivos
            // 
            this.lb_TotalActivos.AutoSize = true;
            this.lb_TotalActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalActivos.Location = new System.Drawing.Point(155, 360);
            this.lb_TotalActivos.Name = "lb_TotalActivos";
            this.lb_TotalActivos.Size = new System.Drawing.Size(44, 13);
            this.lb_TotalActivos.TabIndex = 38;
            this.lb_TotalActivos.Text = "Total: ";
            // 
            // txt_TotalIngresos
            // 
            this.txt_TotalIngresos.Location = new System.Drawing.Point(669, 158);
            this.txt_TotalIngresos.Name = "txt_TotalIngresos";
            this.txt_TotalIngresos.Size = new System.Drawing.Size(86, 20);
            this.txt_TotalIngresos.TabIndex = 37;
            // 
            // txt_TotalPatrimonioNeto
            // 
            this.txt_TotalPatrimonioNeto.Location = new System.Drawing.Point(428, 355);
            this.txt_TotalPatrimonioNeto.Name = "txt_TotalPatrimonioNeto";
            this.txt_TotalPatrimonioNeto.Size = new System.Drawing.Size(89, 20);
            this.txt_TotalPatrimonioNeto.TabIndex = 36;
            // 
            // txt_TotalPasivo
            // 
            this.txt_TotalPasivo.Location = new System.Drawing.Point(428, 159);
            this.txt_TotalPasivo.Name = "txt_TotalPasivo";
            this.txt_TotalPasivo.Size = new System.Drawing.Size(89, 20);
            this.txt_TotalPasivo.TabIndex = 35;
            // 
            // txt_TotalActivos
            // 
            this.txt_TotalActivos.Location = new System.Drawing.Point(201, 357);
            this.txt_TotalActivos.Name = "txt_TotalActivos";
            this.txt_TotalActivos.Size = new System.Drawing.Size(89, 20);
            this.txt_TotalActivos.TabIndex = 34;
            // 
            // DGV_Egresos
            // 
            this.DGV_Egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Egresos.Location = new System.Drawing.Point(549, 235);
            this.DGV_Egresos.Name = "DGV_Egresos";
            this.DGV_Egresos.RowHeadersVisible = false;
            this.DGV_Egresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Egresos.Size = new System.Drawing.Size(206, 120);
            this.DGV_Egresos.TabIndex = 33;
            // 
            // DGV_Ingresos
            // 
            this.DGV_Ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ingresos.Location = new System.Drawing.Point(549, 36);
            this.DGV_Ingresos.Name = "DGV_Ingresos";
            this.DGV_Ingresos.RowHeadersVisible = false;
            this.DGV_Ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Ingresos.Size = new System.Drawing.Size(206, 120);
            this.DGV_Ingresos.TabIndex = 32;
            // 
            // DGV_PatrimonioNeto
            // 
            this.DGV_PatrimonioNeto.AllowUserToAddRows = false;
            this.DGV_PatrimonioNeto.AllowUserToDeleteRows = false;
            this.DGV_PatrimonioNeto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_PatrimonioNeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PatrimonioNeto.Location = new System.Drawing.Point(311, 232);
            this.DGV_PatrimonioNeto.Name = "DGV_PatrimonioNeto";
            this.DGV_PatrimonioNeto.ReadOnly = true;
            this.DGV_PatrimonioNeto.RowHeadersVisible = false;
            this.DGV_PatrimonioNeto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PatrimonioNeto.Size = new System.Drawing.Size(206, 120);
            this.DGV_PatrimonioNeto.TabIndex = 31;
            // 
            // DGV_Pasivos
            // 
            this.DGV_Pasivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Pasivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pasivos.Location = new System.Drawing.Point(311, 36);
            this.DGV_Pasivos.Name = "DGV_Pasivos";
            this.DGV_Pasivos.RowHeadersVisible = false;
            this.DGV_Pasivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Pasivos.Size = new System.Drawing.Size(206, 120);
            this.DGV_Pasivos.TabIndex = 30;
            // 
            // DGV_Activos
            // 
            this.DGV_Activos.AllowUserToAddRows = false;
            this.DGV_Activos.AllowUserToDeleteRows = false;
            this.DGV_Activos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Activos.Location = new System.Drawing.Point(84, 36);
            this.DGV_Activos.Name = "DGV_Activos";
            this.DGV_Activos.ReadOnly = true;
            this.DGV_Activos.RowHeadersVisible = false;
            this.DGV_Activos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Activos.Size = new System.Drawing.Size(206, 319);
            this.DGV_Activos.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Egresos);
            this.Controls.Add(this.lbl_Ingresos);
            this.Controls.Add(this.lbl_PatrimonioNeto);
            this.Controls.Add(this.lbl_Pasivos);
            this.Controls.Add(this.lbl_Activos);
            this.Controls.Add(this.txt_TotalEgresos);
            this.Controls.Add(this.lbl_TotalEgresos);
            this.Controls.Add(this.lbl_TotalPatrimonioNeto);
            this.Controls.Add(this.lbl_TotalIngresos);
            this.Controls.Add(this.lbl_TotalPasivo);
            this.Controls.Add(this.lb_TotalActivos);
            this.Controls.Add(this.txt_TotalIngresos);
            this.Controls.Add(this.txt_TotalPatrimonioNeto);
            this.Controls.Add(this.txt_TotalPasivo);
            this.Controls.Add(this.txt_TotalActivos);
            this.Controls.Add(this.DGV_Egresos);
            this.Controls.Add(this.DGV_Ingresos);
            this.Controls.Add(this.DGV_PatrimonioNeto);
            this.Controls.Add(this.DGV_Pasivos);
            this.Controls.Add(this.DGV_Activos);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Egresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PatrimonioNeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pasivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Activos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Egresos;
        private System.Windows.Forms.Label lbl_Ingresos;
        private System.Windows.Forms.Label lbl_PatrimonioNeto;
        private System.Windows.Forms.Label lbl_Pasivos;
        private System.Windows.Forms.Label lbl_Activos;
        private System.Windows.Forms.TextBox txt_TotalEgresos;
        private System.Windows.Forms.Label lbl_TotalEgresos;
        private System.Windows.Forms.Label lbl_TotalPatrimonioNeto;
        private System.Windows.Forms.Label lbl_TotalIngresos;
        private System.Windows.Forms.Label lbl_TotalPasivo;
        private System.Windows.Forms.Label lb_TotalActivos;
        private System.Windows.Forms.TextBox txt_TotalIngresos;
        private System.Windows.Forms.TextBox txt_TotalPatrimonioNeto;
        private System.Windows.Forms.TextBox txt_TotalPasivo;
        private System.Windows.Forms.TextBox txt_TotalActivos;
        private System.Windows.Forms.DataGridView DGV_Egresos;
        private System.Windows.Forms.DataGridView DGV_Ingresos;
        private System.Windows.Forms.DataGridView DGV_PatrimonioNeto;
        private System.Windows.Forms.DataGridView DGV_Pasivos;
        private System.Windows.Forms.DataGridView DGV_Activos;
    }
}