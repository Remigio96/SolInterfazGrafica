using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FormularioCliente : Form
    {
        // AQUÍ: Declaración de la lista
        private List<Cliente> listaClientes = new List<Cliente>();

        public FormularioCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void rbCasadoCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnContactosCliente_Click(object sender, EventArgs e)
        {
            FormularioContacto contacto = new FormularioContacto();
            contacto.Show();
            this.Hide(); // Cierra FormularioCliente
        }


        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            // Opciones para cmbPersonalidadCliente
            cmbPersonalidadCliente.Items.Add("Jurídica");
            cmbPersonalidadCliente.Items.Add("Natural");

            // Opciones para cmbCiudadCliente
            string[] ciudades = {
        "Arica", "Putre", "Iquique", "Alto Hospicio", "Pozo Almonte", "Calama", "Tocopilla", "Antofagasta", "Mejillones", "Taltal",
        "Copiapó", "Vallenar", "Chañaral", "Diego de Almagro", "La Serena", "Coquimbo", "Ovalle", "Illapel", "Salamanca", "Los Vilos",
        "Valparaíso", "Viña del Mar", "Quillota", "San Antonio", "La Calera", "San Felipe", "Los Andes", "Rancagua", "San Fernando", "Santa Cruz",
        "Santiago", "Puente Alto", "Maipú", "San Bernardo", "Melipilla", "Talagante", "Curacaví", "Talca", "Linares", "Cauquenes", "Chillán",
        "San Carlos", "Los Ángeles", "Concepción", "Talcahuano", "Coronel", "Lota", "Tomé", "Cañete", "Lebu", "Temuco", "Padre Las Casas",
        "Villarrica", "Pucón", "Valdivia", "La Unión", "Osorno", "Puerto Montt", "Puerto Varas", "Ancud", "Castro", "Quellón", "Coyhaique",
        "Puerto Aysén", "Cochrane", "Punta Arenas", "Puerto Natales", "Porvenir", "Puerto Williams"
    };
            cmbCiudadCliente.Items.AddRange(ciudades);

            // Opciones para cmbComunaCliente
            string[] comunas = {
    "Arica", "Camarones", "Putre", "General Lagos", "Iquique", "Alto Hospicio", "Huara", "Camiña", "Colchane", "Pica", "Pozo Almonte",
    "Antofagasta", "Mejillones", "Sierra Gorda", "Taltal", "Calama", "Ollagüe", "San Pedro de Atacama", "Tocopilla", "María Elena",
    "Chañaral", "Diego de Almagro", "Copiapó", "Caldera", "Tierra Amarilla", "Vallenar", "Huasco", "Freirina", "Alto del Carmen",
    "La Serena", "Coquimbo", "Andacollo", "La Higuera", "Vicuña", "Paihuano", "Ovalle", "Monte Patria", "Combarbalá", "Punitaqui",
    "Río Hurtado", "Illapel", "Salamanca", "Los Vilos", "Canela", "Valparaíso", "Viña del Mar", "Concón", "Quilpué", "Villa Alemana",
    "Casablanca", "Quintero", "Puchuncaví", "San Antonio", "Cartagena", "El Tabo", "El Quisco", "Algarrobo", "Santo Domingo",
    "Quillota", "La Calera", "La Cruz", "Nogales", "Hijuelas", "Limache", "Olmué", "San Felipe", "Putaendo", "Santa María", "Catemu",
    "Panquehue", "Llaillay", "Los Andes", "Calle Larga", "Rinconada", "San Esteban", "Rancagua", "Machalí", "Graneros", "Rengo",
    "Requínoa", "Mostazal", "Doñihue", "Olivar", "Coinco", "Coltauco", "Quinta de Tilcoco", "Malloa", "San Vicente", "Peumo",
    "Las Cabras", "Pichidegua", "San Fernando", "Chimbarongo", "Nancagua", "Placilla", "Palmilla", "Santa Cruz", "Lolol", "Paredones",
    "Pumanque", "Marchigüe", "La Estrella", "Navidad", "Pichilemu", "Talca", "Maule", "San Clemente", "Pelarco", "Río Claro",
    "Pencahue", "Curepto", "Constitución", "San Rafael", "San Javier", "Villa Alegre", "Yerbas Buenas", "Linares", "Colbún",
    "Longaví", "Retiro", "Parral", "Cauquenes", "Chanco", "Pelluhue", "Chillán", "Chillán Viejo", "Bulnes", "Quillón", "San Ignacio",
    "El Carmen", "Pinto", "Coihueco", "San Carlos", "Ñiquén", "San Fabián", "San Nicolás", "Yungay", "Trehuaco", "Cobquecura",
    "Quirihue", "Ninhue", "Portezuelo", "Ránquil", "Coelemu", "Concepción", "Talcahuano", "Hualpén", "Chiguayante", "San Pedro de la Paz",
    "Coronel", "Lota", "Tomé", "Penco", "Florida", "Hualqui", "Santa Juana", "Cabrero", "Yumbel", "Laja", "San Rosendo", "Los Ángeles",
    "Mulchén", "Nacimiento", "Negrete", "Quilaco", "Quilleco", "Santa Bárbara", "Tucapel", "Alto Biobío", "Curanilahue", "Lebu",
    "Arauco", "Cañete", "Los Álamos", "Tirúa", "Temuco", "Padre Las Casas", "Cunco", "Melipeuco", "Vilcún", "Freire", "Pitrufquén",
    "Gorbea", "Loncoche", "Villarrica", "Pucón", "Curarrehue", "Toltén", "Teodoro Schmidt", "Carahue", "Nueva Imperial", "Saavedra",
    "Cholchol", "Galvarino", "Lautaro", "Perquenco", "Traiguén", "Victoria", "Ercilla", "Collipulli", "Lonquimay", "Angol",
    "Renaico", "Los Sauces", "Purén", "Lumaco", "Valdivia", "Corral", "Mariquina", "Lanco", "Máfil", "Panguipulli", "La Unión",
    "Río Bueno", "Paillaco", "Futrono", "Lago Ranco", "Osorno", "San Juan de la Costa", "San Pablo", "Puyehue", "Puerto Octay",
    "Río Negro", "Purranque", "Frutillar", "Llanquihue", "Puerto Varas", "Puerto Montt", "Maullín", "Calbuco", "Cochamó", "Hualaihué",
    "Chaitén", "Futaleufú", "Palena", "Ancud", "Castro", "Chonchi", "Curaco de Vélez", "Dalcahue", "Puqueldón", "Queilén", "Quellón",
    "Quemchi", "Quinchao", "Coyhaique", "Lago Verde", "Aysén", "Cisnes", "Guaitecas", "Cochrane", "O'Higgins", "Tortel", "Chile Chico",
    "Río Ibáñez", "Punta Arenas", "Río Verde", "Laguna Blanca", "San Gregorio", "Puerto Natales", "Torres del Paine", "Porvenir",
    "Primavera", "Timaukel", "Cabo de Hornos (Puerto Williams)"
};

            cmbComunaCliente.Items.AddRange(comunas);
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposCliente())
                return;

            Cliente nuevoCliente = new Cliente
            {
                Rut = txtRutCliente.Text,
                Nombres = txtNombresCliente.Text,
                Apellidos = txtApellidosCliente.Text,
                Correo = txtCorreoCliente.Text,
                Telefono = txtTelefonoCliente.Text,
                Descripcion = txtDescripcionCliente.Text,
                Domicilio = txtDomicilioCliente.Text,
                Ciudad = cmbCiudadCliente.SelectedItem.ToString(),
                Comuna = cmbComunaCliente.SelectedItem.ToString(),
                Personalidad = cmbPersonalidadCliente.SelectedItem.ToString(),
                EstadoCivil = rbSolteroCliente.Checked ? "Soltero" : rbCasadoCliente.Checked ? "Casado" : "Viudo"
            };

            listaClientes.Add(nuevoCliente);
            MessageBox.Show("Cliente ingresado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool ValidarCamposCliente()
        {
            bool esValido = true;
            errorProvider1.Clear();

            // TextBox
            if (string.IsNullOrWhiteSpace(txtRutCliente.Text))
            {
                errorProvider1.SetError(txtRutCliente, "Ingrese el RUT");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombresCliente.Text))
            {
                errorProvider1.SetError(txtNombresCliente, "Ingrese nombres");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidosCliente.Text))
            {
                errorProvider1.SetError(txtApellidosCliente, "Ingrese apellidos");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoCliente.Text))
            {
                errorProvider1.SetError(txtCorreoCliente, "Ingrese correo");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefonoCliente.Text))
            {
                errorProvider1.SetError(txtTelefonoCliente, "Ingrese teléfono");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionCliente.Text))
            {
                errorProvider1.SetError(txtDescripcionCliente, "Ingrese descripción");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDomicilioCliente.Text))
            {
                errorProvider1.SetError(txtDomicilioCliente, "Ingrese domicilio");
                esValido = false;
            }

            // ComboBox
            if (cmbCiudadCliente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCiudadCliente, "Seleccione ciudad");
                esValido = false;
            }

            if (cmbComunaCliente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbComunaCliente, "Seleccione comuna");
                esValido = false;
            }

            if (cmbPersonalidadCliente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPersonalidadCliente, "Seleccione personalidad");
                esValido = false;
            }

            // RadioButtons
            if (!rbSolteroCliente.Checked && !rbCasadoCliente.Checked && !rbViudoCliente.Checked)
            {
                errorProvider1.SetError(rbViudoCliente, "Seleccione estado civil");
                esValido = false;
            }

            return esValido;
        }


        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtRutCliente.Clear();
            txtNombresCliente.Clear();
            txtApellidosCliente.Clear();
            txtCorreoCliente.Clear();
            txtTelefonoCliente.Clear();
            txtDescripcionCliente.Clear();
            txtDomicilioCliente.Clear();

            cmbCiudadCliente.SelectedIndex = -1;
            cmbComunaCliente.SelectedIndex = -1;
            cmbPersonalidadCliente.SelectedIndex = -1;

            rbSolteroCliente.Checked = false;
            rbCasadoCliente.Checked = false;
            rbViudoCliente.Checked = false;
        }

        private void lblCiudadCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
