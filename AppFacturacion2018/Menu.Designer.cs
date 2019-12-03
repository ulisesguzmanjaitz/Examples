namespace AppFacturacion2018
{
    partial class Menu
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
            this.btn_ABMProductos = new System.Windows.Forms.Button();
            this.btn_IngresoStock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Balance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ABMProductos
            // 
            this.btn_ABMProductos.Location = new System.Drawing.Point(12, 35);
            this.btn_ABMProductos.Name = "btn_ABMProductos";
            this.btn_ABMProductos.Size = new System.Drawing.Size(97, 33);
            this.btn_ABMProductos.TabIndex = 0;
            this.btn_ABMProductos.Text = "ABM_Productos";
            this.btn_ABMProductos.UseVisualStyleBackColor = true;
            this.btn_ABMProductos.Click += new System.EventHandler(this.btn_ABMProductos_Click);
            // 
            // btn_IngresoStock
            // 
            this.btn_IngresoStock.Location = new System.Drawing.Point(13, 114);
            this.btn_IngresoStock.Name = "btn_IngresoStock";
            this.btn_IngresoStock.Size = new System.Drawing.Size(96, 33);
            this.btn_IngresoStock.TabIndex = 1;
            this.btn_IngresoStock.Text = "IngresoStock";
            this.btn_IngresoStock.UseVisualStyleBackColor = true;
            this.btn_IngresoStock.Click += new System.EventHandler(this.btn_IngresoStock_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "ABM_Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cuentas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Balance
            // 
            this.btn_Balance.Location = new System.Drawing.Point(125, 199);
            this.btn_Balance.Name = "btn_Balance";
            this.btn_Balance.Size = new System.Drawing.Size(97, 33);
            this.btn_Balance.TabIndex = 5;
            this.btn_Balance.Text = "Balance";
            this.btn_Balance.UseVisualStyleBackColor = true;
            this.btn_Balance.Click += new System.EventHandler(this.btn_Balance_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 244);
            this.Controls.Add(this.btn_Balance);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_IngresoStock);
            this.Controls.Add(this.btn_ABMProductos);
            this.Name = "Menu";
            this.Text = "MenuWarmachine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ABMProductos;
        private System.Windows.Forms.Button btn_IngresoStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Balance;
    }
}