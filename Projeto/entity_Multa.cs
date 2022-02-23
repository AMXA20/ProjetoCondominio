using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Projeto
{
    class entity_Multa
    {
        
        public String Multar(Multa m)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbMulta(dataEnvio, descricaoMulta, dataVencimento, codTipoMulta, codApartamento, codCondominio, dataCadastro, status) " +
                    "values('" + m.dataEnvio + "','" + m.descricaoMulta + "','" + m.dataVencimento + "'," + m.codTipoMulta + "," + m.codApartamento + "," + m.codCondominio + ", getdate(), 1 )", conexao.con);
                
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Multado!";
                }
                else
                {
                    return "Erro!";
                }

            }
            catch (SqlException e)
            {
                return (e.ToString());
            }
        }




        public DataTable SelecMulta()
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT tbMulta.codMulta as 'Código', dataEnvio as 'Data de Envio', dataVencimento as 'Data de Vencimento', descricaoMulta as 'Descrição da Multa', descricaoTipoMulta as 'Tipo de Multa', numeroApartamento as 'Número do Apartamento' , nomeCondominio as 'Nome do Condominio' FROM tbMulta INNER JOIN tbTipoMulta ON tbMulta.codTipoMulta = tbTipoMulta.codTipoMulta INNER JOIN tbCondominio ON tbMulta.codCondominio = tbCondominio.codCondominio  INNER JOIN tbApartamento ON tbMulta.codApartamento = tbApartamento.codApartamento  WHERE tbMulta.status = 1", conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public Multa SelecMultaCod(Multa m, int codMulta)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT tbMulta.codMulta, dataEnvio, dataVencimento, descricaoMulta, descricaoTipoMulta, numeroApartamento, blocoApartamento, andarApartamento, nomeCondominio FROM tbMulta INNER JOIN tbTipoMulta ON tbMulta.codTipoMulta = tbTipoMulta.codTipoMulta INNER JOIN tbCondominio ON tbMulta.codCondominio = tbCondominio.codCondominio  INNER JOIN tbApartamento ON tbMulta.codApartamento = tbApartamento.codApartamento  WHERE tbMulta.codMulta =" + codMulta, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                m.dataEnvio = dr["dataEnvio"] + "";
                m.dataVencimento = dr["dataVencimento"]+"";
                m.descricaoMulta = dr["descricaoMulta"] + "";
                m.nomeCondominio = dr["nomeCondominio"] + "";
                m.numeroApartamento = dr["numeroApartamento"] + "";
                m.andarApartamento = dr["andarApartamento"] + "";
                m.blocoApartamento = dr["blocoApartamento"] + "";
                m.descricaoTipoMulta = dr["descricaoTipoMulta"] + "";
               
            }
            return m;
        }

        public String editarMulta(Multa m, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbMulta SET dataVencimento='" + m.dataVencimento + "', codTipoMulta='" + m.codTipoMulta + "', dataEnvio='" + m.dataEnvio + "', descricaoMulta='" + m.descricaoMulta + "', codApartamento='" + m.codApartamento + "' WHERE codMulta=" + cod, conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Multa editada com sucesso!";
                }
                else
                {
                    return "Erro!";
                }

            }
            catch (SqlException e)
            {
                return (e.ToString());
            }
        }

        public String deleteMulta(int codMulta)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbMulta SET status = 0 WHERE codMulta=" + codMulta, conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Deletado com sucesso!";
                }
                else
                {
                    return "Erro!";
                }

            }
            catch (SqlException e)
            {
                return (e.ToString());
            }
        }

        public List<Multa> buscarTodos()
        {

            List<Multa> ms = new List<Multa>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select * from tbMulta WHERE status = 1", c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Multa m = new Multa();
                    m.codMulta = int.Parse(sdr["codMulta"] + "");
                    m.dataEnvio = sdr["dataEnvio"] + "";
                    m.dataVencimento = sdr["dataVencimento"] + "";
                    m.codTipoMulta = int.Parse(sdr["codTipoMulta"] + "");
                    m.codApartamento = int.Parse(sdr["codApartamento"] + "");
                    ms.Add(m);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return ms;
        }

        public DataTable pesquisaMulta(String pesquisa, int cbCat)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            if(cbCat == 0){
                cmd = new SqlCommand("SELECT tbMulta.codMulta , data , dataVencimento , descricaoMulta , numeroApartamento FROM tbMulta INNER JOIN tbTipoMulta ON tbMulta.codTipoMulta = tbTipoMulta.codTipoMulta  INNER JOIN tbApartamento ON tbMulta.codApartamento = tbApartamento.codApartamento  WHERE status = 1 AND data LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 1)
            {
                cmd = new SqlCommand("SELECT tbMulta.codMulta , data , dataVencimento , descricaoMulta , numeroApartamento FROM tbMulta INNER JOIN tbTipoMulta ON tbMulta.codTipoMulta = tbTipoMulta.codTipoMulta  INNER JOIN tbApartamento ON tbMulta.codApartamento = tbApartamento.codApartamento  WHERE status = 1 AND dataVencimento LIKE '" + pesquisa + "%'", conexao.con);
            
            }
            else if (cbCat == 2)
            {
                cmd = new SqlCommand("SELECT tbMulta.codMulta , data , dataVencimento , descricaoMulta , numeroApartamento FROM tbMulta INNER JOIN tbTipoMulta ON tbMulta.codTipoMulta = tbTipoMulta.codTipoMulta  INNER JOIN tbApartamento ON tbMulta.codApartamento = tbApartamento.codApartamento  WHERE status = 1 AND codTipoMulta LIKE '" + pesquisa + "%'", conexao.con);

            }
            else if (cbCat == 3)
            {
                cmd = new SqlCommand("SELECT tbMulta.codMulta , data , dataVencimento , descricaoMulta , numeroApartamento FROM tbMulta INNER JOIN tbTipoMulta ON tbMulta.codTipoMulta = tbTipoMulta.codTipoMulta  INNER JOIN tbApartamento ON tbMulta.codApartamento = tbApartamento.codApartamento  WHERE status = 1 AND codApartamento LIKE '" + pesquisa + "%'", conexao.con);

            }
            conexao.conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    
    }
}
