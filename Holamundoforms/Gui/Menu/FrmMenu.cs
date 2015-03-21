using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Holamundoforms.Catalogos;




namespace Holamundoforms.Gui.menu
  
{
    public partial class MENU: Form
    {
        public MENU()
        {
            InitializeComponent();

        }

        private void MENU_Load(object sender, EventArgs e)
        {
            FrmPrincipal Holamundoforms = new FrmPrincipal();
            Holamundoforms.ShowDialog();
           Holamundoforms.Dispose(); 
        }

        private void BTN_PUNTODEVENTA_Click(object sender, EventArgs e)
        {
            Cat_usuarios miusuario = new Cat_usuarios();
            miusuario.ShowDialog();
            miusuario.Dispose();

        }

        private void BTN_PRODUCTOS_Click(object sender, EventArgs e)
        {
            Form1Productos misproductos = new Form1Productos();
           misproductos.ShowDialog();
            misproductos.Dispose();


        }

        private void BTN_CLIENTE_Click(object sender, EventArgs e)
        {
            CLIENTES miclientes = new CLIENTES();    
          miclientes.ShowDialog();
          miclientes.Dispose();


        }

        private void BTN_ALMACEN_Click(object sender, EventArgs e)
        {
          almacen mialmacen = new almacen();
          mialmacen.ShowDialog();
          mialmacen.Dispose(); 
            

        }

        private void BTN_PROVEEDORES_Click(object sender, EventArgs e)
        {
            proveedores miProveedor = new proveedores();
            miProveedor.ShowDialog();
            miProveedor.Dispose();

        }

        private void BTN_SUCURSALES_Click(object sender, EventArgs e)
        {
            Sucursales misucursal = new Sucursales();
            misucursal.ShowDialog();
            misucursal.Dispose();

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
                Application.Exit();
        }
        

        }

        }


