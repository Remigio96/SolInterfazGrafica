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
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void btnVolverContacto_Click(object sender, EventArgs e)
        {
            Cliente mv = new Cliente();
            mv.ShowDialog();
            this.Close(); // Cierra el formulario actual (Contacto)

        }
    }
}
