using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDatosPersonales
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!esCampoValido(txtApellido) || !esCampoValido(txtNombre) || !esCampoValido(txtEdad) || !esCampoValido(txtDireccion))
             return;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string edad = txtEdad.Text; 
            
            txtResultado.Text = $"Apellido y Nombre: {apellido}, {nombre}\r\nEdad: {edad}\r\nDireccion: {direccion}";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool esCampoValido(TextBox campoTexto)
        {
            if (string.IsNullOrWhiteSpace(campoTexto.Text))
            {
                campoTexto.BackColor = Color.Red;
                return false;
            }
            else
            {
                campoTexto.BackColor = SystemColors.Window; 
                return true;
            }
        }
    }
}
