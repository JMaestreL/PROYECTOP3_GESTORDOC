using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Documento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public TipoDocumento Tipo { get; set; }
        public string Autor { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string RutaArchivo { get; set; }
    }
}
