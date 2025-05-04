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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarAcceso_Click(object sender, EventArgs e)
        {
            Acceso usuario = new Acceso()
            {
                Usuario = txtUsuario.Text,
                Clave = txtClave.Text
            };

            AccesoNegocio logicaAcceso = new AccesoNegocio();

            if (logicaAcceso.ValidarAcceso(usuario))
            {
                // Instancia del formulario (NO la entidad Cliente)
                FormularioCliente formularioCliente = new FormularioCliente();
                formularioCliente.Show();
                this.Hide(); // o this.Close();
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos";
                lblMensaje.Visible = true;
            }
        }
    }
}
