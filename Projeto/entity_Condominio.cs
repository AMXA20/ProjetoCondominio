using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Projeto
{
    class entity_Condominio
    {
        public String cadastrarCondominio(Condominio cond)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbCondominio(nomeCondominio,numeroCondominio, bairroCondominio, cidadeCondominio, valorCondominio, estadoCondominio, logradouroCondominio, sindico, dataCadastro, status) " +
                    "values('" + cond.nomeCondominio + "','" + cond.numeroCondominio + "','" + cond.bairroCondominio + "','" + cond.cidadeCondominio + "'," + cond.valorCondominio + ",'" + cond.estadoCondominio + "','" + cond.logradouroCondominio + "','" + cond.sindicoCondominio + "', getdate(), 1 )", conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Condominio cadastrado com sucesso!";
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




        public DataTable SelectCondominio()
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbCondominio WHERE status = 1", conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public Condominio SelectCondominioCod(Condominio cond, int codCond)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbCondominio WHERE codCondominio = " + codCond, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cond.nomeCondominio = dr["nomeCondominio"] + "";
                cond.numeroCondominio = int.Parse(dr["numeroCondominio"] + "");
                cond.bairroCondominio = dr["bairroCondominio"] + "";
                cond.cidadeCondominio = dr["cidadeCondominio"] + "";
                cond.estadoCondominio = dr["estadoCondominio"] + "";
                cond.valorCondominio = double.Parse(dr["valorCondominio"] + "");
                cond.logradouroCondominio = dr["logradouroCondominio"] + "";
                cond.sindicoCondominio = dr["sindico"] + "";
            }
            return cond;
        }

        public String editarCondominio(Condominio cond, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbCondominio SET nomeCondominio='" + cond.nomeCondominio + "',numeroCondominio='" + cond.numeroCondominio + "',bairroCondominio='" + cond.bairroCondominio + "',cidadeCondominio='" + cond.cidadeCondominio + "',valorCondominio='" + cond.valorCondominio + "',estadoCondominio='" + cond.estadoCondominio + "',logradouroCondominio='" + cond.logradouroCondominio + "',sindico='" + cond.sindicoCondominio + "' WHERE codCondominio=" + cod, conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Apartamento editado com sucesso!";
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

        public String deleteCondominio(int codCond)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbCondominio SET status = 0 WHERE codCondominio=" + codCond, conexao.con);
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

        public List<Condominio> buscarTodos()
        {

            List<Condominio> cnds = new List<Condominio>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select * from tbCondominio WHERE status = 1", c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Condominio cnd = new Condominio();
                    cnd.codCondominio = int.Parse(sdr["codCondominio"] + "");
                    cnd.nomeCondominio = sdr["nomeCondominio"] + "";
                    cnds.Add(cnd);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return cnds;
        }

        public DataTable pesquisaCondominio(String pesquisa, int cbCat)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if(cbCat == 0){
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND nomeCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 1)
            {
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND numeroCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 2)
            {
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND bairroCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 3)
            {
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND cidadeCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 4)
            {
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND valorCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 5)
            {
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND estadoCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 6)
            {
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND logradouroCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 7)
            {
                cmd = new SqlCommand("SELECT * FROM tbCondominio WHERE status = 1 AND sindico LIKE '" + pesquisa + "%'", conexao.con);
            }
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
