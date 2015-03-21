namespace Holamundoforms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_operacion = new System.Windows.Forms.ComboBox();
            this.NUD_numero1 = new System.Windows.Forms.NumericUpDown();
            this.NUD_numero2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_sumar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero #1:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_operacion);
            this.groupBox1.Controls.Add(this.NUD_numero1);
            this.groupBox1.Controls.Add(this.NUD_numero2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos de la sumadora";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operación:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CB_operacion
            // 
            this.CB_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_operacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_operacion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CB_operacion.FormattingEnabled = true;
            this.CB_operacion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Divide #1/#2"});
            this.CB_operacion.Location = new System.Drawing.Point(143, 114);
            this.CB_operacion.Name = "CB_operacion";
            this.CB_operacion.Size = new System.Drawing.Size(121, 29);
            this.CB_operacion.TabIndex = 6;
            this.CB_operacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NUD_numero1
            // 
            this.NUD_numero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUD_numero1.DecimalPlaces = 2;
            this.NUD_numero1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_numero1.Location = new System.Drawing.Point(144, 35);
            this.NUD_numero1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NUD_numero1.Name = "NUD_numero1";
            this.NUD_numero1.Size = new System.Drawing.Size(120, 24);
            this.NUD_numero1.TabIndex = 5;
            this.NUD_numero1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // NUD_numero2
            // 
            this.NUD_numero2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUD_numero2.DecimalPlaces = 2;
            this.NUD_numero2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_numero2.Location = new System.Drawing.Point(144, 73);
            this.NUD_numero2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NUD_numero2.Name = "NUD_numero2";
            this.NUD_numero2.Size = new System.Drawing.Size(120, 24);
            this.NUD_numero2.TabIndex = 4;
            this.NUD_numero2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero #2:";
            // 
            // BTN_sumar
            // 
            this.BTN_sumar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_sumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_sumar.FlatAppearance.BorderSize = 2;
            this.BTN_sumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_sumar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_sumar.ForeColor = System.Drawing.Color.Tomato;
            this.BTN_sumar.Location = new System.Drawing.Point(179, 199);
            this.BTN_sumar.Name = "BTN_sumar";
            this.BTN_sumar.Size = new System.Drawing.Size(97, 33);
            this.BTN_sumar.TabIndex = 2;
            this.BTN_sumar.Text = "Sumar";
            this.BTN_sumar.UseVisualStyleBackColor = false;
            this.BTN_sumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(552, 305);
            this.Controls.Add(this.BTN_sumar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suamdora op ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUD_numero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_sumar;
        private System.Windows.Forms.NumericUpDown NUD_numero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_operacion;
    }
}

