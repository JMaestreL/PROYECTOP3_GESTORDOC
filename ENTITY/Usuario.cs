using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public string PasswordHash { get; set; } // Opcional para cambiar clave
    }
}
