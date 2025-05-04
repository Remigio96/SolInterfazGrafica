using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace InterfazGrafica
{
    public partial class FormularioAcceso : Form
    {
        public FormularioAcceso()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarAcceso_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            Acceso usuario = new Acceso()
            {
                Usuario = txtUsuario.Text,
                Clave = txtClave.Text
            };

            AccesoNegocio logicaAcceso = new AccesoNegocio();

            if (logicaAcceso.ValidarAcceso(usuario))
            {
                FormularioCliente formularioCliente = new FormularioCliente();
                formularioCliente.Show();
                this.Hide();
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos";
                lblMensaje.Visible = true;
            }
        }


        private void submenu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloAcesso_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            bool esValido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Ingrese su nombre de usuario");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                errorProvider1.SetError(txtClave, "Ingrese su contraseña");
                esValido = false;
            }

            return esValido;
        }

    }
}
