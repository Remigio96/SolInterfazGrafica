using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class AccesoNegocio
    {
        // Simularemos un usuario registrado
        private readonly string usuarioValido = "admin";
        private readonly string claveValida = "1234";

        public bool ValidarAcceso(Acceso acceso)
        {
            // Validación simple de usuario y contraseña
            return acceso.Usuario == usuarioValido && acceso.Clave == claveValida;
        }
    }
}
