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
    public partial class FrmPrincipal : Form
    {
        //propiedades de la clase 
        private double numero1, numero2, Resultado;

        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_operacion.SelectedIndex = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (CB_operacion.SelectedIndex == 3)
            {
                if (NUD_numero2.Value == 0)
                {

                    BTN_sumar.Enabled = false;
                }
                
                else
                {
                    BTN_sumar.Enabled = true;
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtener los valores de pantalla
            
            numero1 = (double) NUD_numero1.Value;
            numero2 = (double)NUD_numero2.Value;

            if(CB_operacion.SelectedIndex == 0)
                Resultado = numero1 + numero2;

            if (CB_operacion.SelectedIndex == 1)
                Resultado = numero1 - numero2;

            if (CB_operacion.SelectedIndex == 2)
                Resultado = numero1 * numero2;

            
            if (CB_operacion.SelectedIndex == 3)
                Resultado = numero1 / numero2;

            


            MessageBox.Show("La suma es: " + Resultado);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CB_operacion.SelectedIndex == 3)
            {
                 if(NUD_numero2.Value == 0)
                 {

                     BTN_sumar.Enabled = false;
                 }

            }
            else
            {
                BTN_sumar.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
