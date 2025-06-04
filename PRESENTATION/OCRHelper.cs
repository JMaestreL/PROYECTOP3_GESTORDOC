using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace PRESENTATION
{
    public static class OCRHelper
    {
        public static string ExtraerTexto(string rutaImagen)
        {
            using (var engine = new TesseractEngine("./tessdata", "spa", EngineMode.Default))
            using (var img = Pix.LoadFromFile(rutaImagen))
            using (var page = engine.Process(img))
            {
                return page.GetText();
            }
        }
    }
}
