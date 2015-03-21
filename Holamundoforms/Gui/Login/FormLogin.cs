using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Holamundoforms.BD;
using Holamundoforms.Gui.menu;


namespace Holamundoforms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        //revisar si el usuario esta registrado 
        public void Revisa_usuario_registrado()
        {

        }
        public bool Verifica_usuario_password()
        {
            bool Validar_Usuario = false;
            //Validar que el usuario no sea "Blanco"(que no esta vacio)
            if (String.IsNullOrEmpty(this.txtusuario.Text.Trim() )) // Igual se puedo utilizar este ---> (this.txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese tu nombre de usuario");
                Validar_Usuario = false;
                return Validar_Usuario;
            }

            
            //Validar que  la cotraseña no sea "Blanco"(que no esta vacio)
            if (String.IsNullOrEmpty(this.txtpass.Text.Trim())) 
            {
                //CREAR EL OBJETO QUE ME CONECTA A LA BASE DE DATOS...
                ConexionMYSQL objetoODBC = new ConexionMYSQL();
                //CREAMOS LA SENTENCIA SQL QUE ME DEVUELVE LOS DATOS QUE CONCUERDAN CON LA CONDICION "WHERE"
                string SentenciaSQL;
                SentenciaSQL = "select usuario from sys_usuarios where usuario= '" + txtusuario.Text + "' and contrasenia = '" + txtpass.Text + "'";
                //VALIDAR QUE LA COMBINACION DE USUARIO Y CONTRASEÑA EXISTA
                if (!objetoODBC.MYSQL_EXISTE_DATO(SentenciaSQL))
                {
                    //SI NO EXISTE ESA COMBINACION, LOS DATOS SON INCORRECTOS
                    MessageBox.Show("DATOS DE ACCESO INCORRECTOS!", "ERROR");
                    Validar_Usuario = false;
                    return Validar_Usuario;
                }
                return Validar_Usuario;
            }


            return Validar_Usuario;
        }

       

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //son las dos manera, la primera es con codigo ASCII
            /*if (e.KeyChar == 32)
            {
            } */
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("no se permite espacios");
                e.Handled = true;
            }
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            /*
            if (this.Verifica_usuario_password())
            {
                this.Hide();

                MessageBox.Show("Felicidades, ya vas air al menu principal");


               
            }*/

            MENU mivetana = new MENU();
            mivetana.Show();
        }


        private void BTN_nuevousuario_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario miVentana = new frmNuevoUsuario();
            miVentana.ShowDialog();
            miVentana.Dispose();
            
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }


