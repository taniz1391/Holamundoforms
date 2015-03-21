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
    public partial class CLIENTES : Form
    {
        public CLIENTES()
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
            //NUEVO OBJETO DE LA CLASE PRODUCTO de la carpeta BO (Cat_clientes)             
            Cat_clientes oCliente = new Cat_clientes();

            //Nuevo OBJETO DE LA CLASE DAO_producto de la carpeta DAO             
            DAO_Clientes oClienteDAO = new DAO_Clientes();

            //LLENAR PROPIEDADES DEL OBJETO PRODUCTO, CON CADA DATO CAPTURADO EN LA PANTALLA             
            //Objeto.Propiedad = Pantalla.ComponenteVisual.Valor;  

            oCliente.Rfc = this.clie_rfc.Text.Trim();
            oCliente.Razon_social = this.clie_razon_social.Text.Trim();
            oCliente.Calle = int.Parse(this.clie_calle.Text.Trim());
            oCliente.Numero_interior1 = int.Parse(this.clie_numero_interior.Text.Trim());
            oCliente.Numero_exterior = int.Parse(this.clie_num_exterior.Text.Trim());
            oCliente.Referencia = this.clie_referencia.Text.Trim();
            oCliente.Colonia = this.clie_colonia.Text.Trim();
            oCliente.Municipio = this.clie_municipio.Text.Trim();
            oCliente.Estado = this.clie_estado.Text.Trim();
            oCliente.Codigo_postal = int.Parse(this.clie_codigo_postal.Text.Trim());
            oCliente.Telefono = int.Parse(this.clie_telefono.Text.Trim());
            oCliente.Correo = this.clie_correo.Text.Trim();

            //LLAMAMOS AL METODO DE LA CLASE DAO QUE HACE EL INSERT, le enviamos como parametro el objeto oCliente que              
            //ya llenamos con los valores de la pantalla             
            i = oClienteDAO.agregarNuevoRegistro(oCliente);

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
            oCliente = null;
            oClienteDAO = null;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
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

        private void button1_entrar_Click(object sender, EventArgs e)
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

        private void CLIENTES_Load(object sender, EventArgs e)
        {

        }
    
        }
  
    }
    




    
