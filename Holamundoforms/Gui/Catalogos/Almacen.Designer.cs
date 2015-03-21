namespace Holamundoforms
{
    partial class almacen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_nuevousuario = new System.Windows.Forms.Button();
            this.BTN_salir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Cod_productos = new System.Windows.Forms.TextBox();
            this.Num_almacen = new System.Windows.Forms.TextBox();
            this.almacen_proveedores = new System.Windows.Forms.Label();
            this.codi_productos = new System.Windows.Forms.Label();
            this.Stock_minimo1 = new System.Windows.Forms.Label();
            this.alma_cantidad = new System.Windows.Forms.Label();
            this.cantidad_alma = new System.Windows.Forms.NumericUpDown();
            this.stock_minimo_alma = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_alma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_minimo_alma)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.BTN_Registrar);
            this.panel1.Controls.Add(this.BTN_Entrar);
            this.panel1.Controls.Add(this.BTN_nuevousuario);
            this.panel1.Controls.Add(this.BTN_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 83);
            this.panel1.TabIndex = 9;
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Registrar.Image = global::Holamundoforms.Properties.Resources.Other_Tasks_Metro_icon;
            this.BTN_Registrar.Location = new System.Drawing.Point(172, 9);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(64, 64);
            this.BTN_Registrar.TabIndex = 12;
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.BackgroundImage = global::Holamundoforms.Properties.Resources.entrar;
            this.BTN_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Entrar.Location = new System.Drawing.Point(12, 7);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(64, 68);
            this.BTN_Entrar.TabIndex = 4;
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click_2);
            // 
            // BTN_nuevousuario
            // 
            this.BTN_nuevousuario.BackgroundImage = global::Holamundoforms.Properties.Resources.nuevo;
            this.BTN_nuevousuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_nuevousuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_nuevousuario.Location = new System.Drawing.Point(359, 9);
            this.BTN_nuevousuario.Name = "BTN_nuevousuario";
            this.BTN_nuevousuario.Size = new System.Drawing.Size(64, 64);
            this.BTN_nuevousuario.TabIndex = 9;
            this.BTN_nuevousuario.UseVisualStyleBackColor = true;
            // 
            // BTN_salir
            // 
            this.BTN_salir.BackgroundImage = global::Holamundoforms.Properties.Resources.salir;
            this.BTN_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_salir.Location = new System.Drawing.Point(501, 9);
            this.BTN_salir.Name = "BTN_salir";
            this.BTN_salir.Size = new System.Drawing.Size(64, 64);
            this.BTN_salir.TabIndex = 11;
            this.BTN_salir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 59);
            this.panel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Almacen";
            // 
            // Cod_productos
            // 
            this.Cod_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cod_productos.Location = new System.Drawing.Point(232, 116);
            this.Cod_productos.MaxLength = 16;
            this.Cod_productos.Name = "Cod_productos";
            this.Cod_productos.Size = new System.Drawing.Size(159, 31);
            this.Cod_productos.TabIndex = 15;
            // 
            // Num_almacen
            // 
            this.Num_almacen.Location = new System.Drawing.Point(232, 79);
            this.Num_almacen.Name = "Num_almacen";
            this.Num_almacen.Size = new System.Drawing.Size(159, 20);
            this.Num_almacen.TabIndex = 14;
            // 
            // almacen_proveedores
            // 
            this.almacen_proveedores.AutoSize = true;
            this.almacen_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almacen_proveedores.ForeColor = System.Drawing.Color.Lime;
            this.almacen_proveedores.Location = new System.Drawing.Point(16, 79);
            this.almacen_proveedores.Name = "almacen_proveedores";
            this.almacen_proveedores.Size = new System.Drawing.Size(105, 20);
            this.almacen_proveedores.TabIndex = 16;
            this.almacen_proveedores.Text = "No.Almacen";
            // 
            // codi_productos
            // 
            this.codi_productos.AutoSize = true;
            this.codi_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codi_productos.ForeColor = System.Drawing.Color.Lime;
            this.codi_productos.Location = new System.Drawing.Point(12, 122);
            this.codi_productos.Name = "codi_productos";
            this.codi_productos.Size = new System.Drawing.Size(196, 24);
            this.codi_productos.TabIndex = 17;
            this.codi_productos.Text = "Codigo de producto";
            // 
            // Stock_minimo1
            // 
            this.Stock_minimo1.AutoSize = true;
            this.Stock_minimo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_minimo1.ForeColor = System.Drawing.Color.Lime;
            this.Stock_minimo1.Location = new System.Drawing.Point(16, 205);
            this.Stock_minimo1.Name = "Stock_minimo1";
            this.Stock_minimo1.Size = new System.Drawing.Size(135, 24);
            this.Stock_minimo1.TabIndex = 18;
            this.Stock_minimo1.Text = "Stock minimo";
            // 
            // alma_cantidad
            // 
            this.alma_cantidad.AutoSize = true;
            this.alma_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alma_cantidad.ForeColor = System.Drawing.Color.Lime;
            this.alma_cantidad.Location = new System.Drawing.Point(16, 162);
            this.alma_cantidad.Name = "alma_cantidad";
            this.alma_cantidad.Size = new System.Drawing.Size(89, 24);
            this.alma_cantidad.TabIndex = 19;
            this.alma_cantidad.Text = "cantidad";
            // 
            // cantidad_alma
            // 
            this.cantidad_alma.Location = new System.Drawing.Point(232, 168);
            this.cantidad_alma.Name = "cantidad_alma";
            this.cantidad_alma.Size = new System.Drawing.Size(159, 20);
            this.cantidad_alma.TabIndex = 20;
            // 
            // stock_minimo_alma
            // 
            this.stock_minimo_alma.Location = new System.Drawing.Point(232, 205);
            this.stock_minimo_alma.Name = "stock_minimo_alma";
            this.stock_minimo_alma.Size = new System.Drawing.Size(159, 20);
            this.stock_minimo_alma.TabIndex = 21;
            // 
            // almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(631, 342);
            this.Controls.Add(this.stock_minimo_alma);
            this.Controls.Add(this.cantidad_alma);
            this.Controls.Add(this.alma_cantidad);
            this.Controls.Add(this.Stock_minimo1);
            this.Controls.Add(this.codi_productos);
            this.Controls.Add(this.almacen_proveedores);
            this.Controls.Add(this.Cod_productos);
            this.Controls.Add(this.Num_almacen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "almacen";
            this.Text = "Almacen";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_alma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_minimo_alma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.Button BTN_nuevousuario;
        private System.Windows.Forms.Button BTN_salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cod_productos;
        private System.Windows.Forms.TextBox Num_almacen;
        private System.Windows.Forms.Label almacen_proveedores;
        private System.Windows.Forms.Label codi_productos;
        private System.Windows.Forms.Label Stock_minimo1;
        private System.Windows.Forms.Label alma_cantidad;
        private System.Windows.Forms.NumericUpDown cantidad_alma;
        private System.Windows.Forms.NumericUpDown stock_minimo_alma;
    }
}