namespace Holamundoforms
{
    partial class Cat_usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usu_contrasenia = new System.Windows.Forms.TextBox();
            this.usu_nombre_completo = new System.Windows.Forms.TextBox();
            this.usu_usuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.usu_tipo_usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE COMPLETO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO DE USUARIO";
            // 
            // usu_contrasenia
            // 
            this.usu_contrasenia.Location = new System.Drawing.Point(156, 99);
            this.usu_contrasenia.Name = "usu_contrasenia";
            this.usu_contrasenia.Size = new System.Drawing.Size(100, 20);
            this.usu_contrasenia.TabIndex = 6;
            // 
            // usu_nombre_completo
            // 
            this.usu_nombre_completo.Location = new System.Drawing.Point(156, 58);
            this.usu_nombre_completo.Name = "usu_nombre_completo";
            this.usu_nombre_completo.Size = new System.Drawing.Size(100, 20);
            this.usu_nombre_completo.TabIndex = 7;
            // 
            // usu_usuario
            // 
            this.usu_usuario.Location = new System.Drawing.Point(156, 19);
            this.usu_usuario.Name = "usu_usuario";
            this.usu_usuario.Size = new System.Drawing.Size(100, 20);
            this.usu_usuario.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // usu_tipo_usuario
            // 
            this.usu_tipo_usuario.Location = new System.Drawing.Point(156, 145);
            this.usu_tipo_usuario.Name = "usu_tipo_usuario";
            this.usu_tipo_usuario.Size = new System.Drawing.Size(100, 20);
            this.usu_tipo_usuario.TabIndex = 13;
            // 
            // Cat_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.usu_tipo_usuario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usu_usuario);
            this.Controls.Add(this.usu_nombre_completo);
            this.Controls.Add(this.usu_contrasenia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cat_usuarios";
            this.Text = "USUARIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usu_contrasenia;
        private System.Windows.Forms.TextBox usu_nombre_completo;
        private System.Windows.Forms.TextBox usu_usuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox usu_tipo_usuario;
    }
}