using Financiera.Data;
using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Logic
{
    public static class TipoClienteBL
    {
        public static List<TipoCliente> Listar()
        {
            var tipoClienteData = new TipoClienteData();
            return tipoClienteData.Listar();
        }
    }
}
