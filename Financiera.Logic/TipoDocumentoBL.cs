using Financiera.Data;
using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Logic
{
    public static class TipoDocumentoBL
    {
        public static List<TipoDocumento> Listar()
        {
            var tipoDocumentoData = new TipoDocumentoData();
            return tipoDocumentoData.Listar();
        }
    }
}
