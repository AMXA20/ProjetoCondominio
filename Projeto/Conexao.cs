using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Projeto
{
    class Conexao
    {
        public SqlConnection con = new SqlConnection(@"Server=ALEXANDRE-PC\SQLEXPRESS;Database=bdCondominio;Integrated Security=SSPI;");

        public String conectar()
        {
            try
            {
                con.Open();
                return "Funfa";
            }
            catch (SqlException e)
            {
                return (e.ToString());
            }
        }

        public String desconectar()
        {
            try
            {
                con.Close();
                return ("Desfunfa");
            }
            catch (SqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
