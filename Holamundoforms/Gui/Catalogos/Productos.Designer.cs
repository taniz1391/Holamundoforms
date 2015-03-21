namespace Holamundoforms.Catalogos
{
    partial class Form1Productos
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
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_nuevousuario = new System.Windows.Forms.Button();
            this.BTN_salir = new System.Windows.Forms.Button();
            this.cod_producto = new System.Windows.Forms.TextBox();
            this.nombre_completo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUD_numero1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Fecha_Registro = new System.Windows.Forms.DateTimePicker();
            this.button1_enter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.BTN_Agregar);
            this.panel1.Controls.Add(this.BTN_Entrar);
            this.panel1.Controls.Add(this.BTN_nuevousuario);
            this.panel1.Controls.Add(this.BTN_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 83);
            this.panel1.TabIndex = 8;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Agregar.Image = global::Holamundoforms.Properties.Resources.Other_Tasks_Metro_icon;
            this.BTN_Agregar.Location = new System.Drawing.Point(172, 9);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(64, 64);
            this.BTN_Agregar.TabIndex = 12;
            this.BTN_Agregar.UseVisualStyleBackColor = true;
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
            // cod_producto
            // 
            this.cod_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_producto.Location = new System.Drawing.Point(223, 12);
            this.cod_producto.MaxLength = 15;
            this.cod_producto.Name = "cod_producto";
            this.cod_producto.Size = new System.Drawing.Size(159, 31);
            this.cod_producto.TabIndex = 9;
            this.cod_producto.TextChanged += new System.EventHandler(this.cod_producto_TextChanged);
            // 
            // nombre_completo
            // 
            this.nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_completo.Location = new System.Drawing.Point(223, 61);
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.Size = new System.Drawing.Size(318, 31);
            this.nombre_completo.TabIndex = 12;
            this.nombre_completo.TextChanged += new System.EventHandler(this.nombre_completo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha_Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio $";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(40, 61);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(136, 18);
            this.nombre.TabIndex = 17;
            this.nombre.Text = "Nombre Completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codigo de Producto";
            // 
            // NUD_numero1
            // 
            this.NUD_numero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUD_numero1.DecimalPlaces = 2;
            this.NUD_numero1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_numero1.Location = new System.Drawing.Point(223, 119);
            this.NUD_numero1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NUD_numero1.Name = "NUD_numero1";
            this.NUD_numero1.Size = new System.Drawing.Size(120, 24);
            this.NUD_numero1.TabIndex = 19;
            this.NUD_numero1.ValueChanged += new System.EventHandler(this.NUD_numero1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(223, 159);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Fecha_Registro
            // 
            this.Fecha_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Registro.Location = new System.Drawing.Point(223, 214);
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.Size = new System.Drawing.Size(243, 20);
            this.Fecha_Registro.TabIndex = 21;
            this.Fecha_Registro.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1_enter
            // 
            this.button1_enter.Location = new System.Drawing.Point(501, 254);
            this.button1_enter.Name = "button1_enter";
            this.button1_enter.Size = new System.Drawing.Size(75, 23);
            this.button1_enter.TabIndex = 22;
            this.button1_enter.UseVisualStyleBackColor = true;
            this.button1_enter.Click += new System.EventHandler(this.button1_enter_Click);
            // 
            // Form1Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(663, 405);
            this.Controls.Add(this.button1_enter);
            this.Controls.Add(this.Fecha_Registro);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.NUD_numero1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre_completo);
            this.Controls.Add(this.cod_producto);
            this.Controls.Add(this.panel1);
            this.Name = "Form1Productos";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.Form1Productos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.Button BTN_nuevousuario;
        private System.Windows.Forms.Button BTN_salir;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.TextBox cod_producto;
        private System.Windows.Forms.TextBox nombre_completo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUD_numero1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker Fecha_Registro;
        private System.Windows.Forms.Button button1_enter;
    }
}