using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ENTITY;

namespace DAL
{
    public class UsuarioDAL
    {
        public static bool ValidarLogin(string usuario, string contraseña)
        {
            string sql = "SELECT COUNT(*) FROM USUARIO WHERE NOMBRE_USUARIO = :usuario AND CONTRASEÑA = :contraseña";

            using (OracleConnection conn = new OracleConnection(Conexion.ObtenerCadenaConexion()))
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(":usuario", usuario);
                cmd.Parameters.Add(":contraseña", contraseña);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Nuevo: obtener usuario por nombre de usuario (para cargar datos en Mi Cuenta)
        public static Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            Usuario user = null;
            using (var conn = new OracleConnection(Conexion.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT ID_USUARIO, NOMBRE, CORREO, ROL, ESTADO, NOMBRE_USUARIO FROM USUARIO WHERE NOMBRE_USUARIO = :usuario";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":usuario", nombreUsuario);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new Usuario
                            {
                                Id = Convert.ToInt32(dr["ID_USUARIO"]),
                                Nombre = dr["NOMBRE"].ToString(),
                                Correo = dr["CORREO"].ToString(),
                                Rol = dr["ROL"].ToString(),
                                
                                NombreUsuario = dr["NOMBRE_USUARIO"].ToString()
                            };
                        }
                    }
                }
            }
            return user;
        }

        // Nuevo: actualizar datos básicos del usuario
        public static bool ActualizarUsuario(Usuario user)
        {
            using (var conn = new OracleConnection(Conexion.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"UPDATE USUARIO SET NOMBRE = :nombre, CORREO = :correo WHERE ID_USUARIO = :id";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":nombre", user.Nombre);
                    cmd.Parameters.Add(":correo", user.Correo);
                    cmd.Parameters.Add(":id", user.Id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
