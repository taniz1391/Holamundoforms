namespace Holamundoforms
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_nuevousuario = new System.Windows.Forms.Button();
            this.BTN_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(65, 95);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(159, 31);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(65, 166);
            this.txtpass.MaxLength = 16;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = 'X';
            this.txtpass.Size = new System.Drawing.Size(159, 31);
            this.txtpass.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.BTN_Entrar);
            this.panel1.Controls.Add(this.BTN_nuevousuario);
            this.panel1.Controls.Add(this.BTN_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 83);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.toolTip1.SetToolTip(this.BTN_Entrar, "Favoritos");
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // BTN_nuevousuario
            // 
            this.BTN_nuevousuario.BackgroundImage = global::Holamundoforms.Properties.Resources.nuevo;
            this.BTN_nuevousuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_nuevousuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_nuevousuario.Location = new System.Drawing.Point(100, 7);
            this.BTN_nuevousuario.Name = "BTN_nuevousuario";
            this.BTN_nuevousuario.Size = new System.Drawing.Size(64, 64);
            this.BTN_nuevousuario.TabIndex = 9;
            this.toolTip1.SetToolTip(this.BTN_nuevousuario, "Nuevo usuario");
            this.BTN_nuevousuario.UseVisualStyleBackColor = true;
            this.BTN_nuevousuario.Click += new System.EventHandler(this.BTN_nuevousuario_Click);
            // 
            // BTN_salir
            // 
            this.BTN_salir.BackgroundImage = global::Holamundoforms.Properties.Resources.salir;
            this.BTN_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_salir.Location = new System.Drawing.Point(512, 7);
            this.BTN_salir.Name = "BTN_salir";
            this.BTN_salir.Size = new System.Drawing.Size(64, 64);
            this.BTN_salir.TabIndex = 11;
            this.toolTip1.SetToolTip(this.BTN_salir, "Salir");
            this.BTN_salir.UseVisualStyleBackColor = true;
            this.BTN_salir.Click += new System.EventHandler(this.BTN_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Holamundoforms.Properties.Resources.Drives_Computer_Metro_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(365, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 169);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.CancelButton = this.BTN_salir;
            this.ClientSize = new System.Drawing.Size(588, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button BTN_nuevousuario;
        private System.Windows.Forms.Button BTN_salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}