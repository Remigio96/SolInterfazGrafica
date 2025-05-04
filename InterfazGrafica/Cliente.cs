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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void rbCasadoCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnContactosCliente_Click(object sender, EventArgs e)
        {
            Contacto mv = new Contacto();
            mv.ShowDialog();

        }
    }
}
