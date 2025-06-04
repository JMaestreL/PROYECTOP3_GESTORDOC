using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public static class DocumentoBLL
    {
        public static bool Guardar(Documento doc)
        {
            if (string.IsNullOrWhiteSpace(doc.Titulo) || doc.Tipo == null || string.IsNullOrWhiteSpace(doc.RutaArchivo))
                return false;
            return DocumentoDAL.GuardarDocumento(doc);
        }

        public static List<TipoDocumento> ObtenerTipos()
        {
            return DocumentoDAL.ObtenerTiposDocumento();
        }


        public static List<Documento> BuscarDocumentos(string titulo, string autor, int? idTipo)
        {
            return DocumentoDAL.BuscarDocumentos(titulo, autor, idTipo);
        }

        public static List<Documento> ObtenerTodos()
        {
            return DocumentoDAL.ObtenerTodos();
        }
    }


}
