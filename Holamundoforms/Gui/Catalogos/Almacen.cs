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



namespace Holamundoforms
{
    public partial class almacen : Form
    {
        public almacen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Formalmacen_Load(object sender, EventArgs e)
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
            //NUEVO OBJETO DE LA CLASE PRODUCTO de la carpeta BO (Almacen)
            Almacen oAlmacenes = new Almacen();
            //Nuevo OBJETO DE LA CLASE DAO_producto de la carpeta DAO
            dao_Almacen oAlmacenDAO = new dao_Almacen();
            //LLENAR PROPIEDADES DEL OBJETO PRODUCTO, CON CADA DATO CAPTURADO EN LA PANTALLA
            //Objeto.Propiedad = Pantalla.ComponenteVisual.Valor;
            oAlmacenes.Num_almacen = int.Parse(this.Num_almacen.Text.Trim());
            oAlmacenes.Cod_producto = this.codi_productos.Text.Trim();
            oAlmacenes.Cantidad = (double)this.cantidad_alma.Value;
            oAlmacenes.Stock_minimo = (double)this.stock_minimo_alma.Value;
            
            //LLAMAMOS AL METODO DE LA CLASE DAO QUE HACE EL INSERT, le enviamos como parametro el objeto oProducto que
            //ya llenamos con los valores de la pantalla
            i = oAlmacenDAO.agregarNuevoRegistro(oAlmacenes);
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
            oAlmacenes = null;
            oAlmacenDAO = null;
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
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

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Entrar_Click_1(object sender, EventArgs e)
        {

        }

        private void BTN_Entrar_Click_2(object sender, EventArgs e)
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

    
    