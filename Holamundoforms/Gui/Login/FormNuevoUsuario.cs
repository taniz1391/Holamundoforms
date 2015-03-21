using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holamundoforms
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            
            FormLogin miVentana = new FormLogin();
            miVentana.ShowDialog();
            this.Close();
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
