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
    public partial class FormularioContacto : Form
    {
        private List<Contacto> listaContactos = new List<Contacto>();
        public FormularioContacto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += FormularioContacto_FormClosed;
        }

        private void btnVolverContacto_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void FormularioContacto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["FormularioCliente"]?.Show();
        }


        private void btnLimpiarContacto_Click(object sender, EventArgs e)
        {
            txtClienteContacto.Clear();
            txtRutContacto.Clear();
            txtDescripcionContacto.Clear();
            txtNombresContacto.Clear();
            txtApellidosContacto.Clear();
            txtCorreoContacto.Clear();
            txtTelefonoContacto.Clear();
            txtDomicilioContacto.Clear();
            cmbCiudadContacto.SelectedIndex = -1;
            cmbComunaContacto.SelectedIndex = -1;
            rbSolteroContacto.Checked = false;
            rbCasadoContacto.Checked = false;
            rbViudoContacto.Checked = false;
        }

        private void FormularioContacto_Load(object sender, EventArgs e)
        {
            // Poblamos cmbCiudadContacto
            string[] ciudades = {
                "Arica", "Putre", "Iquique", "Alto Hospicio", "Pozo Almonte", "Calama", "Tocopilla", "Antofagasta", "Mejillones", "Taltal",
                "Copiapó", "Vallenar", "Chañaral", "Diego de Almagro", "La Serena", "Coquimbo", "Ovalle", "Illapel", "Salamanca", "Los Vilos",
                "Valparaíso", "Viña del Mar", "Quillota", "San Antonio", "La Calera", "San Felipe", "Los Andes", "Rancagua", "San Fernando",
                "Santa Cruz", "Santiago", "Puente Alto", "Maipú", "San Bernardo", "Melipilla", "Talagante", "Curacaví", "Talca", "Linares",
                "Cauquenes", "Chillán", "San Carlos", "Los Ángeles", "Concepción", "Talcahuano", "Coronel", "Lota", "Tomé", "Cañete", "Lebu",
                "Temuco", "Padre Las Casas", "Villarrica", "Pucón", "Valdivia", "La Unión", "Osorno", "Puerto Montt", "Puerto Varas", "Ancud",
                "Castro", "Quellón", "Coyhaique", "Puerto Aysén", "Cochrane", "Punta Arenas", "Puerto Natales", "Porvenir", "Puerto Williams"
            };
            cmbCiudadContacto.Items.AddRange(ciudades);

            // Poblamos cmbComunaContacto
            string[] comunas = {
                "Arica", "Camarones", "Putre", "General Lagos", "Iquique", "Alto Hospicio", "Huara", "Camiña", "Colchane", "Pica", "Pozo Almonte",
                "Antofagasta", "Mejillones", "Sierra Gorda", "Taltal", "Calama", "Ollagüe", "San Pedro de Atacama", "Tocopilla", "María Elena",
                "Chañaral", "Diego de Almagro", "Copiapó", "Caldera", "Tierra Amarilla", "Vallenar", "Huasco", "Freirina", "Alto del Carmen",
                "La Serena", "Coquimbo", "Andacollo", "La Higuera", "Vicuña", "Paihuano", "Ovalle", "Monte Patria", "Combarbalá", "Punitaqui",
                "Illapel", "Salamanca", "Los Vilos", "Canela", "Valparaíso", "Viña del Mar", "Concón", "Quilpué", "Villa Alemana", "Casablanca",
                "Quintero", "Puchuncaví", "San Antonio", "Cartagena", "El Tabo", "El Quisco", "Algarrobo", "Santo Domingo", "Quillota", "La Calera",
                "La Cruz", "Nogales", "Hijuelas", "Limache", "Olmué", "San Felipe", "Putaendo", "Santa María", "Catemu", "Panquehue", "Llaillay",
                "Los Andes", "Calle Larga", "Rinconada", "San Esteban", "Rancagua", "Machalí", "Graneros", "Rengo", "Requínoa", "Mostazal",
                "Doñihue", "Olivar", "Coinco", "Coltauco", "Quinta de Tilcoco", "Malloa", "San Vicente", "Peumo", "Las Cabras", "Pichidegua",
                "San Fernando", "Chimbarongo", "Nancagua", "Placilla", "Palmilla", "Santa Cruz", "Lolol", "Paredones", "Pumanque", "Marchigüe",
                "La Estrella", "Navidad", "Pichilemu", "Talca", "Maule", "San Clemente", "Pelarco", "Río Claro", "Pencahue", "Curepto", "Constitución",
                "San Rafael", "San Javier", "Villa Alegre", "Yerbas Buenas", "Linares", "Colbún", "Longaví", "Retiro", "Parral", "Cauquenes",
                "Chanco", "Pelluhue", "Chillán", "Chillán Viejo", "Bulnes", "Quillón", "San Ignacio", "El Carmen", "Pinto", "Coihueco", "San Carlos",
                "Ñiquén", "San Fabián", "San Nicolás", "Yungay", "Trehuaco", "Cobquecura", "Quirihue", "Ninhue", "Portezuelo", "Ránquil", "Coelemu",
                "Concepción", "Talcahuano", "Hualpén", "Chiguayante", "San Pedro de la Paz", "Coronel", "Lota", "Tomé", "Penco", "Florida", "Hualqui",
                "Santa Juana", "Cabrero", "Yumbel", "Laja", "San Rosendo", "Los Ángeles", "Mulchén", "Nacimiento", "Negrete", "Quilaco", "Quilleco",
                "Santa Bárbara", "Tucapel", "Alto Biobío", "Curanilahue", "Lebu", "Arauco", "Cañete", "Los Álamos", "Tirúa", "Temuco", "Padre Las Casas",
                "Cunco", "Melipeuco", "Vilcún", "Freire", "Pitrufquén", "Gorbea", "Loncoche", "Villarrica", "Pucón", "Curarrehue", "Toltén",
                "Teodoro Schmidt", "Carahue", "Nueva Imperial", "Saavedra", "Cholchol", "Galvarino", "Lautaro", "Perquenco", "Traiguén", "Victoria",
                "Ercilla", "Collipulli", "Lonquimay", "Angol", "Renaico", "Los Sauces", "Purén", "Lumaco", "Valdivia", "Corral", "Mariquina", "Lanco",
                "Máfil", "Panguipulli", "La Unión", "Río Bueno", "Paillaco", "Futrono", "Lago Ranco", "Osorno", "San Juan de la Costa", "San Pablo",
                "Puyehue", "Puerto Octay", "Río Negro", "Purranque", "Frutillar", "Llanquihue", "Puerto Varas", "Puerto Montt", "Maullín", "Calbuco",
                "Cochamó", "Hualaihué", "Chaitén", "Futaleufú", "Palena", "Ancud", "Castro", "Chonchi", "Curaco de Vélez", "Dalcahue", "Puqueldón",
                "Queilén", "Quellón", "Quemchi", "Quinchao", "Coyhaique", "Lago Verde", "Aysén", "Cisnes", "Guaitecas", "Cochrane", "O'Higgins",
                "Tortel", "Chile Chico", "Río Ibáñez", "Punta Arenas", "Río Verde", "Laguna Blanca", "San Gregorio", "Puerto Natales", "Torres del Paine",
                "Porvenir", "Primavera", "Timaukel", "Cabo de Hornos (Puerto Williams)"
            };
            cmbComunaContacto.Items.AddRange(comunas);
        }

        private void btnIngresarContacto_Click(object sender, EventArgs e)
        {
            // Limpia errores anteriores
            errorProvider1.Clear();

            bool valido = true;

            // Validación individual con ErrorProvider
            if (string.IsNullOrWhiteSpace(txtClienteContacto.Text))
            {
                errorProvider1.SetError(txtClienteContacto, "Ingrese el nombre del cliente");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtRutContacto.Text))
            {
                errorProvider1.SetError(txtRutContacto, "Ingrese el RUT");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcionContacto.Text))
            {
                errorProvider1.SetError(txtDescripcionContacto, "Ingrese una descripción");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombresContacto.Text))
            {
                errorProvider1.SetError(txtNombresContacto, "Ingrese nombres");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidosContacto.Text))
            {
                errorProvider1.SetError(txtApellidosContacto, "Ingrese apellidos");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreoContacto.Text))
            {
                errorProvider1.SetError(txtCorreoContacto, "Ingrese correo");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefonoContacto.Text))
            {
                errorProvider1.SetError(txtTelefonoContacto, "Ingrese teléfono");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDomicilioContacto.Text))
            {
                errorProvider1.SetError(txtDomicilioContacto, "Ingrese domicilio");
                valido = false;
            }
            if (cmbCiudadContacto.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCiudadContacto, "Seleccione una ciudad");
                valido = false;
            }
            if (cmbComunaContacto.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbComunaContacto, "Seleccione una comuna");
                valido = false;
            }
            if (!rbSolteroContacto.Checked && !rbCasadoContacto.Checked && !rbViudoContacto.Checked)
            {
                errorProvider1.SetError(rbViudoContacto, "Seleccione estado civil");
                valido = false;
            }

            if (!valido)
            {
                return;
            }

            // Crear nuevo contacto
            Contacto nuevoContacto = new Contacto
            {
                Cliente = txtClienteContacto.Text,
                Rut = txtRutContacto.Text,
                Descripcion = txtDescripcionContacto.Text,
                Nombres = txtNombresContacto.Text,
                Apellidos = txtApellidosContacto.Text,
                Correo = txtCorreoContacto.Text,
                Telefono = txtTelefonoContacto.Text,
                EstadoCivil = rbSolteroContacto.Checked ? "Soltero" : rbCasadoContacto.Checked ? "Casado" : "Viudo",
                Domicilio = txtDomicilioContacto.Text,
                Ciudad = cmbCiudadContacto.SelectedItem.ToString(),
                Comuna = cmbComunaContacto.SelectedItem.ToString()
            };

            listaContactos.Add(nuevoContacto);

            MessageBox.Show("Contacto ingresado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
