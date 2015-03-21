using System;
using System.Windows.Forms;
using Holamundoforms.Bo;
using Holamundoforms.Dao;



namespace Holamundoforms.Catalogos 
{
    public partial class proveedores : Form
    {
        public proveedores()
        {
            InitializeComponent();
        }
    
     
    
       private bool HAY_DATOS_VACIOS_EN_TEXTBOXES()
        {
            bool HAY_TEXTBOX_VACIOS = false;
            foreach (Control ctrl in this.Controls) //PARA CADA CONTROL DENTRO DEL FORMULARIO
            {
                if ((object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox))) & (!HAY_TEXTBOX_VACIOS))
                {
                    if (ctrl.Text.Trim() == String.Empty)
                    {
                        HAY_TEXTBOX_VACIOS = true; break;
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
            //NUEVO OBJETO DE LA CLASE PRODUCTO de la carpeta BO (Cat_proveedores)             
            Cat_proveedores oProveedores = new Cat_proveedores();

            //Nuevo OBJETO DE LA CLASE DAO_producto de la carpeta DAO             
            DAO_Proveedores oProvedores= new DAO_Proveedores();

            //LLENAR PROPIEDADES DEL OBJETO PRODUCTO, CON CADA DATO CAPTURADO EN LA PANTALLA             
            //Objeto.Propiedad = Pantalla.ComponenteVisual.Valor;  

            oProveedores.Rfc = this.prove_rfc.Text.Trim();
            oProveedores.Razon_social = this.prove_razon_social.Text.Trim();
            oProveedores.Calle = int.Parse(this.prove_calle.Text.Trim());
            oProveedores.Numero_exterior = int.Parse(this.provee_num_exterior.Text.Trim());
            oProveedores.Num_interior = int.Parse(this.provee_num_interior.Text.Trim());
            oProveedores.Referencia = this.provee_referencia.Text.Trim();
            oProveedores.Colonia = this.provee_colonia.Text.Trim();
            oProveedores.Municipio = this.provee_municipio.Text.Trim();
            oProveedores.Estado = this.provee_estado.Text.Trim();
            oProveedores.Codigo_postal = int.Parse(this.provee_codigo_postal.Text.Trim());
            oProveedores.Telefono = int.Parse(this.provee_telefono.Text.Trim());
            oProveedores.Correo = this.prove_correo.Text.Trim();

            //LLAMAMOS AL METODO DE LA CLASE DAO QUE HACE EL INSERT, le enviamos como parametro el objeto oAlmacen que              
            //ya llenamos con los valores de la pantalla             
            i = oProvedores.agregarNuevoRegistro(oProveedores);

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
            oProveedores = null;
            oProvedores = null;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormsAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
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

        private void proveedores_Load(object sender, EventArgs e)
        {

        }

    }
}

       
