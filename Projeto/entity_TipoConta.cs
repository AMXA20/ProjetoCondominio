using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Projeto
{
    class entity_TipoConta
    {
        public String cadastrarTipoConta(TipoConta tm)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbTipoConta(descricaoTipoConta,dataCadastro, status) " +
                    "values('" + tm.descricaoTipoConta + "', getdate(), 1 )", conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Tipo de Conta cadastrada com sucesso!";
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




        public DataTable SelectTipoConta()
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT codTipoConta as 'Código',descricaoTipoConta as 'Tipo de Conta', dataCadastro as 'Data de Cadastro' FROM tbTipoConta WHERE status = 1", conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public TipoConta SelectTipoContaCod(TipoConta tm, int codTipoConta)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbTipoConta WHERE codTipoConta = " + codTipoConta, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tm.descricaoTipoConta = dr["descricaoTipoConta"] + "";
                
            }
            return tm;
        }

        public String editarTipoConta(TipoConta tm, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbTipoConta SET descricaoTipoConta='" + tm.descricaoTipoConta +"' WHERE codTipoConta=" + cod, conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Tipo de Conta editada com sucesso!";
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

        public String deleteTipoConta(int codTIpoConta)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbTipoConta SET status = 0 WHERE codTipoConta=" + codTIpoConta, conexao.con);
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

        public List<TipoConta> buscarTodos()
        {

            List<TipoConta> tms = new List<TipoConta>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select * from tbTipoConta WHERE status = 1", c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    TipoConta tm = new TipoConta();
                    tm.codTipoConta = int.Parse(sdr["codTipoConta"] + "");
                    tm.descricaoTipoConta = sdr["descricaoTipoConta"] + "";
                    tms.Add(tm);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return tms;
        }

        public DataTable pesquisaTipoConta(String pesquisa, int cbCat)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            if (cbCat == 0)
            {
                cmd = new SqlCommand("SELECT codTipoConta as 'Código',descricaoTipoConta as 'Tipo de Conta', dataCadastro as 'Data de Cadastro' FROM tbTipoConta WHERE status = 1 AND descricaoTipoConta LIKE '" + pesquisa + "%'", conexao.con);
            }
            conexao.conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
