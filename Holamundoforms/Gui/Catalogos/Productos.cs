using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Holamundoforms.Bo;
using Holamundoforms.Dao;




     namespace Holamundoforms.Catalogos
     {

    public partial class Form1Productos : Form
    {
        public Form1Productos()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1Productos_Load(object sender, EventArgs e)
        {

        }

        private void cod_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_completo_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUD_numero1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }
        
            private bool HAY_DATOS_VACIOS_EN_TEXTBOXES()
        {
            bool HAY_TEXTBOX_VACIOS = false;
            foreach (Control ctrl in this.Controls) //PARA CADA CONTROL DENTRO DEL FORMULARIO
            {
                if ((object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox))) &
               (!HAY_TEXTBOX_VACIOS))
                {
                    if (ctrl.Text.Trim() == String.Empty)
                    {
                        HAY_TEXTBOX_VACIOS = true;
                        break;
                    }
                }
            }
            return HAY_TEXTBOX_VACIOS;
        }
        public void VALIDA_CARACTERES_EN_TEXTBOXES(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case
                '\'': //COMILLA SENCILLA
                    e.Handled = true;
                    break;
                case
                '\\': // DIAGONAL INVERTIDA
                    e.Handled = true;
                    break;
                case
                'à':
                    e.Handled = true;
                    break;
                case
                'È':
                    e.Handled = true;
                    break;
                case
                '`':
                    e.Handled = true;
                    break;
                case
                '´':
                    e.Handled = true;
                    break;
                case
                '&':
                    e.Handled = true;
                    break;
                case
                'û':
                    e.Handled = true;
                    break;
                case
                '^':
                    e.Handled = true;
                    break;
                case
               '|':
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }
        public void ENVIAR_DATOS_NUEVO_REGISTRO()
        {
            int i = 0;
            //NUEVO OBJETO DE LA CLASE PRODUCTO de la carpeta BO (Productos)
            Productos oProducto = new Productos();

            //Nuevo OBJETO DE LA CLASE DAO_producto de la carpeta DAO
            DAO_productos oproductosDAO = new DAO_productos();

            //LLENAR PROPIEDADES DEL OBJETO PRODUCTO, CON CADA DATO CAPTURADO EN LA PANTALLA
            //Objeto.Propiedad = Pantalla.ComponenteVisual.Valor;
            oProducto.Cod_productos= this.cod_producto.Text.Trim();
            oProducto.Nombre_completo = this.nombre_completo.Text.Trim();
            oProducto.Precio = (double)this.numericUpDown1.Value;
            oProducto.Costo = (double)this.numericUpDown1.Value;
            oProducto.Fecha_ingreso= this.Fecha_Registro.Value;
           
            //LLAMAMOS AL METODO DE LA CLASE DAO QUE HACE EL INSERT, le enviamos como parametro el objeto oProducto que
            //ya llenamos con los valores de la pantalla

            i = oproductosDAO.agregarNuevoRegistro(oProducto);
            //VERIFICAMOS SI SE HA EJECUTADO CORRECTAMENTE LA ACCION SOLICITADA
            if (i == 0)
            {
                MessageBox.Show("El proceso no se pudo realizar");
            }
            else
            {
                MessageBox.Show("El proceso se genero con éxito");
            }
            //MATAMOS A LOS OBJETOS UTILIZADOS
            oProducto = null;
            oproductosDAO = null;
        }

        private void BTN_AGREGAR_REGISTRO_Click(object sender, EventArgs e)
        {
              if (HAY_DATOS_VACIOS_EN_TEXTBOXES()) //SI FALTA POR CAPTURAR UN DATO
              {
             MessageBox.Show("Hay datos sin capturar, favor de revisar su pantalla de datos.", "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }
             else
             {
              DialogResult dr = MessageBox.Show("¿Desea continuar y agregar un nuevo registro?.", "Agregar Nuevo Registro", MessageBoxButtons.YesNo);
               switch (dr)
                {
                 case DialogResult.Yes:
                 ENVIAR_DATOS_NUEVO_REGISTRO();
                 this.Close();
                 break;
                case DialogResult.No:
                break;
              }
           }
        }

        private void button1_enter_Click(object sender, EventArgs e)
        {
            
            if (HAY_DATOS_VACIOS_EN_TEXTBOXES()) //SI FALTA POR CAPTURAR UN DATO 
            {
                MessageBox.Show("Hay datos sin capturar, favor de revisar su pantalla de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Desea continuar y agregar un nuevo registro?.", "Agregar Nuevo Registro", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: ENVIAR_DATOS_NUEVO_REGISTRO();
                        this.Close();
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            
        }

    }
}
            
        
