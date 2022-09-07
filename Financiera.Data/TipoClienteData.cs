using System;
using System.Collections.Generic;
using System.Text;
using Financiera.Dominio;
using System.Data.SqlClient;


namespace Financiera.Data
{
    public class TipoClienteData
    {
        string cadenaConexion = "server=localhost; database=Financiera; Integrated Security=true";
        public List<TipoCliente> Listar()
        {
            var listado = new List<TipoCliente>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * From TipoCliente", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            TipoCliente tipo;
                            while (lector.Read())
                            {
                                tipo = new TipoCliente();
                                tipo.ID = int.Parse(lector[0].ToString());
                                tipo.Nombre = lector[1].ToString();
                                listado.Add(tipo);
                            }
                        }
                    }
                }
            }
            return listado;
        }

     
    }
}
    
