using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Projeto
{
    class entity_Morador
    {
        public DataTable SelectMorador(int codCond)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT codMorador, nomeMorador, rgMorador, cpfMorador, tbMorador.codApartamento FROM tbMorador INNER JOIN tbApartamento ON tbMorador.codApartamento = tbApartamento.codApartamento INNER JOIN tbCondominio ON tbApartamento.codCondominio = tbCondominio.codCondominio WHERE tbMorador.status = 1 AND tbApartamento.status = 1 AND tbCondominio.status = 1 AND tbApartamento.codCondominio = "+ codCond, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public List<Apartamento> buscarTodos(int codAp)
        {

            List<Apartamento> listApart = new List<Apartamento>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select codApartamento, numeroApartamento, blocoApartamento, andarApartamento, codCondominio from tbApartamento WHERE status = 1 AND codCondominio = " + codAp, c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Apartamento ap = new Apartamento();
                    ap.codApartamento = int.Parse(sdr["codApartamento"] + "");
                    ap.numApartamento = int.Parse(sdr["numeroApartamento"] + "");
                    ap.blocoApartamento = sdr["blocoApartamento"] + "";
                    ap.andarApartamento = int.Parse(sdr["andarApartamento"] + "");
                    ap.codCondominio = int.Parse(sdr["codCondominio"] + "");
                    listApart.Add(ap);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return listApart;
        }

        public String cadastrarMorador(Morador mor)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbMorador(nomeMorador, sobrenomeMorador, rgMorador, cpfMorador, codApartamento, dataCadastro, status) " +
                    "values('" + mor.nomeMorador + "','" + mor.sobrenomeMorador + "','" + mor.rgMorador + "','" + mor.cpfMorador + "'," + mor.codApartamento + ", getdate(), 1 )", conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    SqlCommand cmd2 = new SqlCommand(
                    "SELECT codMorador FROM tbMorador WHERE cpfMorador LIKE '" + mor.cpfMorador + "'", conexao.con);
                    conexao.conectar();

                    SqlDataReader dr = cmd2.ExecuteReader();
                    while (dr.Read())
                    {
                        mor.codMorador = int.Parse(dr["codMorador"] + "");
                    }
                    conexao.desconectar();
                        SqlCommand cmd3 = new SqlCommand(
                            "INSERT INTO tbTelefoneMorador(numeroTelefoneMorador, codMorador, dataCadastro, status) " +
                            "values('" + mor.telefoneMorador + "'," + mor.codMorador + ", getdate(), 1 )", conexao.con);
                        conexao.conectar();
                        int j = cmd3.ExecuteNonQuery();
                        conexao.desconectar();
                        if (j > 0)
                        {
                            return "Morador cadastrado com sucesso!";

                        }
                        else
                        {
                            return "Erro no cadastro!";
                        }
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

        public String deleteMorador(int codMor)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbMorador SET status = 0 WHERE codMorador = " + codMor, conexao.con);
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

        public Morador SelectMoradorCod(Morador mor, int codMor)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbMorador WHERE codMorador = " + codMor, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mor.nomeMorador = dr["nomeMorador"] + "";
                mor.sobrenomeMorador = dr["sobrenomeMorador"] + "";
                mor.rgMorador = dr["rgMorador"] + "";
                mor.cpfMorador = dr["cpfMorador"] + "";
                mor.codApartamento = int.Parse(dr["codApartamento"] + "");
            }
            return mor;
        }

        public Morador SelectTelefone(Morador mor, int codMor)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbTelefoneMorador WHERE codMorador = " + codMor, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mor.telefoneMorador = dr["numeroTelefoneMorador"] + "";
            }
            return mor;
        }

        public Boolean SelectCPF(String cpf)
        {
            try
            {
                Conexao conexao = new Conexao();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbMorador WHERE cpfMorador = '" + cpf + "'", conexao.con);
                conexao.conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                String cpfM = "";
                if (dr.Read())
                {
                     cpfM = dr["cpfMorador"]+"";
                }
                if (cpfM != "")
                    return true;            

                conexao.desconectar();
            }
            catch (SqlException e)
            {
                return false;
            }
            return false;
        }

        public String editarMorador(Morador mor, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbMorador SET nomeMorador='" + mor.nomeMorador + "',sobrenomeMorador='" + mor.sobrenomeMorador + "',rgMorador='" + mor.rgMorador + "',cpfMorador='" + mor.cpfMorador + "',codApartamento='" + mor.codApartamento + "' WHERE codMorador=" + cod, conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Morador editado com sucesso!";
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

        public DataTable pesquisaMorador(String pesquisa, int cbCat, int codCond)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (cbCat == 0)
            {
                cmd = new SqlCommand("SELECT codMorador, nomeMorador, rgMorador, cpfMorador, tbMorador.codApartamento FROM tbMorador INNER JOIN tbApartamento ON tbMorador.codApartamento = tbApartamento.codApartamento INNER JOIN tbCondominio ON tbApartamento.codCondominio = tbCondominio.codCondominio WHERE tbMorador.status = 1 AND tbApartamento.status = 1 AND tbCondominio.status = 1 AND tbApartamento.codCondominio = " + codCond + " AND tbMorador.nomeMorador LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 1)
            {
                cmd = new SqlCommand("SELECT codMorador, nomeMorador, rgMorador, cpfMorador, tbMorador.codApartamento FROM tbMorador INNER JOIN tbApartamento ON tbMorador.codApartamento = tbApartamento.codApartamento INNER JOIN tbCondominio ON tbApartamento.codCondominio = tbCondominio.codCondominio WHERE tbMorador.status = 1 AND tbApartamento.status = 1 AND tbCondominio.status = 1 AND tbApartamento.codCondominio = " + codCond + " AND tbMorador.sobrenomeMorador LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 2)
            {
                cmd = new SqlCommand("SELECT codMorador, nomeMorador, rgMorador, cpfMorador, tbMorador.codApartamento FROM tbMorador INNER JOIN tbApartamento ON tbMorador.codApartamento = tbApartamento.codApartamento INNER JOIN tbCondominio ON tbApartamento.codCondominio = tbCondominio.codCondominio WHERE tbMorador.status = 1 AND tbApartamento.status = 1 AND tbCondominio.status = 1 AND tbApartamento.codCondominio = " + codCond + " AND tbMorador.rgMorador LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 3)
            {
                cmd = new SqlCommand("SELECT codMorador, nomeMorador, rgMorador, cpfMorador, tbMorador.codApartamento FROM tbMorador INNER JOIN tbApartamento ON tbMorador.codApartamento = tbApartamento.codApartamento INNER JOIN tbCondominio ON tbApartamento.codCondominio = tbCondominio.codCondominio WHERE tbMorador.status = 1 AND tbApartamento.status = 1 AND tbCondominio.status = 1 AND tbApartamento.codCondominio = " + codCond + " AND tbMorador.cpfMorador LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 4)
            {
                cmd = new SqlCommand("SELECT codMorador, nomeMorador, rgMorador, cpfMorador, tbMorador.codApartamento FROM tbMorador INNER JOIN tbApartamento ON tbMorador.codApartamento = tbApartamento.codApartamento INNER JOIN tbCondominio ON tbApartamento.codCondominio = tbCondominio.codCondominio WHERE tbMorador.status = 1 AND tbApartamento.status = 1 AND tbCondominio.status = 1 AND tbApartamento.codCondominio = " + codCond + " AND tbMorador.codApartamento LIKE '" + pesquisa + "%'", conexao.con);
            }
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
