using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public static class TipoDocumentoBLL
    {
        public static List<TipoDocumento> ObtenerTipos()
        {
            return DocumentoDAL.ObtenerTiposDocumento();
        }
    }
}
