using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class UsuarioBLL
    {
        public static bool ValidarLogin(string usuario, string contraseña)
        {
            return UsuarioDAL.ValidarLogin(usuario, contraseña);
        }

        public static Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            return UsuarioDAL.ObtenerPorNombreUsuario(nombreUsuario);
        }

        public static bool ActualizarUsuario(Usuario user)
        {
            // Aquí podrías validar reglas de negocio (ejemplo: email válido)
            if (string.IsNullOrEmpty(user.Nombre) || string.IsNullOrEmpty(user.Correo))
                throw new ArgumentException("Nombre y correo no pueden estar vacíos.");

            return UsuarioDAL.ActualizarUsuario(user);
        }
    }
}
