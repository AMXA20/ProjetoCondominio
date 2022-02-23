using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
namespace Projeto
{
    class entity_TipoMulta
    {
        public String cadastrarTipoMulta(TipoMulta tm)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbTipoMulta(descricaoTipoMulta, valorMulta, dataCadastro, status) " +
                    "values('" + tm.nomeTipoMulta + "','" + tm.valorMulta.Replace(",",".") + "', getdate(), 1 )", conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Multa cadastrada com sucesso!";
                }
                else
                {
                    return "Erro no cadastro!";
                }

            }
            catch (SqlException e)
            {
                return (e.ToString());
            }
        }




        public DataTable SelectTipoMulta()
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbTipoMulta WHERE status = 1", conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public TipoMulta SelectTipoMultaCod(TipoMulta tm, int codTipoMulta)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbTipoMulta WHERE codTipoMulta = " + codTipoMulta, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tm.nomeTipoMulta = dr["descricaoTipoMulta"] + "";
                tm.valorMulta = dr["valorMulta"] + "";   
            }
            return tm;
        }

        public String editarTipoMulta(TipoMulta tm, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbTipoMulta SET descricaoTipoMulta='" + tm.nomeTipoMulta + "',valorMulta='" + tm.valorMulta.Replace(",", ".") + "' WHERE codTipoMulta=" + cod, conexao.con);
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

        public String deleteTipoMulta(int codTIpoMulta)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbTipoMulta SET status = 0 WHERE codTipoMulta=" + codTIpoMulta, conexao.con);
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

        public List<TipoMulta> buscarTodos()
        {

            List<TipoMulta> tms = new List<TipoMulta>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select * from tbTipoMulta WHERE status = 1", c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    TipoMulta tm = new TipoMulta();
                    tm.codTipoMulta = int.Parse(sdr["codTipoMulta"] + "");
                    tm.nomeTipoMulta = sdr["descricaoTipoMulta"] + "";
                    tm.valorMulta = sdr["valorMulta"] + "";
                    tms.Add(tm);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return tms;
        }

        public DataTable pesquisaTipoMulta(String pesquisa, int cbCat)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            if(cbCat == 0){
                cmd = new SqlCommand("SELECT * FROM tbTipoMulta WHERE status = 1 AND descricaoTipoMulta LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 1)
            {
                cmd = new SqlCommand("SELECT * FROM tbTipoMulta WHERE status = 1 AND valorMulta LIKE '" + pesquisa + "%'", conexao.con);
            }
            conexao.conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
