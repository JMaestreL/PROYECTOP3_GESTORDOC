using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ENTITY;
using Oracle.ManagedDataAccess.Client;


namespace DAL
{
    public static class DocumentoDAL
    {
        public static bool GuardarDocumento(Documento doc)
        {
            using (var conn = new OracleConnection(Conexion.ObtenerCadenaConexion()))
            {
                conn.Open();
                string query = @"INSERT INTO DOCUMENTO (TITULO, ID_TIPO, AUTOR, DESCRIPCION, FECHA_CREACION, RUTA_ARCHIVO)
                             VALUES (:titulo, :id_tipo, :autor, :descripcion, :fecha, :ruta)";
                using (var cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":titulo", doc.Titulo);
                    cmd.Parameters.Add(":id_tipo", doc.Tipo.Id);
                    cmd.Parameters.Add(":autor", doc.Autor);
                    cmd.Parameters.Add(":descripcion", doc.Descripcion);
                    cmd.Parameters.Add(":fecha", doc.FechaCreacion);
                    cmd.Parameters.Add(":ruta", doc.RutaArchivo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<TipoDocumento> ObtenerTiposDocumento()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();
            using (var conn = new OracleConnection(Conexion.ObtenerCadenaConexion()))
            {
                conn.Open();
                string query = "SELECT ID_TIPO, NOMBRE FROM TIPO_DOCUMENTO ORDER BY NOMBRE";
                using (var cmd = new OracleCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new TipoDocumento
                        {
                            Id = Convert.ToInt32(reader["ID_TIPO"]),
                            Nombre = reader["NOMBRE"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public static List<Documento> BuscarDocumentos(string titulo, string autor, int? idTipo)
        {
            List<Documento> lista = new List<Documento>();

            using (OracleConnection conn = new OracleConnection(Conexion.ObtenerCadenaConexion()))
            {
                conn.Open();

                string sql = @"
                    SELECT d.ID_DOCUMENTO, d.Titulo, d.ID_TIPO, t.Nombre AS TipoNombre, d.Autor, d.Descripcion, d.FECHA_CREACION, d.RUTA_ARCHIVO
                    FROM DOCUMENTO d
                    INNER JOIN TIPO_DOCUMENTO t ON d.ID_TIPO = t.ID_TIPO
                    WHERE 1=1 ";

                if (!string.IsNullOrEmpty(titulo))
                    sql += " AND LOWER(d.Titulo) LIKE :titulo ";
                if (!string.IsNullOrEmpty(autor))
                    sql += " AND LOWER(d.Autor) LIKE :autor ";
                if (idTipo.HasValue)
                    sql += " AND d.ID_TIPO = :idTipo ";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(titulo))
                        cmd.Parameters.Add(new OracleParameter("titulo", "%" + titulo.ToLower() + "%"));
                    if (!string.IsNullOrEmpty(autor))
                        cmd.Parameters.Add(new OracleParameter("autor", "%" + autor.ToLower() + "%"));
                    if (idTipo.HasValue)
                        cmd.Parameters.Add(new OracleParameter("idTipo", idTipo.Value));

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Documento doc = new Documento
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("ID_DOCUMENTO")),
                                Titulo = dr.GetString(dr.GetOrdinal("Titulo")),
                                Tipo = new TipoDocumento
                                {
                                    Id = dr.GetInt32(dr.GetOrdinal("ID_TIPO")),
                                    Nombre = dr.GetString(dr.GetOrdinal("TipoNombre"))
                                },
                                Autor = dr.GetString(dr.GetOrdinal("Autor")),
                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")),
                                FechaCreacion = dr.GetDateTime(dr.GetOrdinal("FECHA_CREACION")),
                                RutaArchivo = dr.GetString(dr.GetOrdinal("RUTA_ARCHIVO"))
                            };
                            lista.Add(doc);
                        }
                    }
                }
            }

            return lista;
        }

        public static List<Documento> ObtenerTodos()
        {
            List<Documento> lista = new List<Documento>();

            using (OracleConnection conn = new OracleConnection(Conexion.ObtenerCadenaConexion()))
            {
                conn.Open();

                string sql = @"
                    SELECT d.ID_DOCUMENTO, d.Titulo, d.ID_TIPO, t.Nombre AS TipoNombre, d.Autor, d.Descripcion, d.FECHA_CREACION, d.RUTA_ARCHIVO
                    FROM DOCUMENTO d
                    INNER JOIN TIPO_DOCUMENTO t ON d.ID_TIPO = t.ID_TIPO";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Documento doc = new Documento
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("ID_DOCUMENTO")),
                                Titulo = dr.GetString(dr.GetOrdinal("Titulo")),
                                Tipo = new TipoDocumento
                                {
                                    Id = dr.GetInt32(dr.GetOrdinal("ID_TIPO")),
                                    Nombre = dr.GetString(dr.GetOrdinal("TipoNombre"))
                                },
                                Autor = dr.GetString(dr.GetOrdinal("Autor")),
                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")),
                                FechaCreacion = dr.GetDateTime(dr.GetOrdinal("FECHA_CREACION")),
                                RutaArchivo = dr.GetString(dr.GetOrdinal("RUTA_ARCHIVO"))
                            };
                            lista.Add(doc);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
