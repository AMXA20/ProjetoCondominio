using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Projeto
{
    class entity_Proprietario
    {
        public DataTable SelectProprietario()
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT tbProprietario.codProprietario as 'Código', nomeProprietario as 'Nome do Proprietário', rgProprietario as 'RG do Proprietario', cpfProprietario as 'CPF do Proprietario', numeroTelefoneProprietario as 'Telefone' FROM tbProprietario INNER JOIN tbTelefoneProprietario ON tbProprietario.codProprietario = tbTelefoneProprietario.codProprietario  WHERE tbProprietario.status = 1 AND tbTelefoneProprietario.status = 1", conexao.con);
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
                SqlCommand cmd = new SqlCommand("Select codApartamento, numeroApartamento, blocoApartamento, andarApartamento, codProprietario from tbApartamento WHERE status = 1 AND codProprietario = " + codAp, c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Apartamento ap = new Apartamento();
                    ap.codApartamento = int.Parse(sdr["codApartamento"] + "");
                    ap.numApartamento = int.Parse(sdr["numeroApartamento"] + "");
                    ap.blocoApartamento = sdr["blocoApartamento"] + "";
                    ap.andarApartamento = int.Parse(sdr["andarApartamento"] + "");
                    
                    listApart.Add(ap);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return listApart;
        }

        public List<Proprietario> buscarTodos()
        {

            List<Proprietario> pros = new List<Proprietario>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select * from tbProprietario WHERE status = 1 AND codProprietario != 1", c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Proprietario cnd = new Proprietario();
                    cnd.codProprietario = int.Parse(sdr["codProprietario"] + "");
                    cnd.nomeProprietario = sdr["nomeProprietario"] + "";
                    pros.Add(cnd);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return pros;
        }

        public String cadastroProprietario(Proprietario pro)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbProprietario(nomeProprietario, sobrenomeProprietario, rgProprietario, cpfProprietario, dataCadastro, status) " +
                    "values('" + pro.nomeProprietario + "','" + pro.sobrenomeProprietario + "','" + pro.rgProprietario + "','" + pro.cpfProprietario + "', getdate(), 1 )", conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    SqlCommand cmd2 = new SqlCommand(
                    "SELECT codProprietario FROM tbProprietario WHERE cpfProprietario LIKE '" + pro.cpfProprietario + "'", conexao.con);
                    conexao.conectar();

                    SqlDataReader dr = cmd2.ExecuteReader();
                    while (dr.Read())
                    {
                        pro.codProprietario = int.Parse(dr["codProprietario"] + "");
                    }
                    conexao.desconectar();
                    SqlCommand cmd3 = new SqlCommand(
                        "INSERT INTO tbTelefoneProprietario(numeroTelefoneProprietario, codProprietario,dataCadastro, status) " +
                        "values('" + pro.telefoneProprietario + "'," + pro.codProprietario + ", getdate(), 1 )", conexao.con);
                    conexao.conectar();
                    int j = cmd3.ExecuteNonQuery();
                    conexao.desconectar();
                    if (j > 0)
                    {
                        return "Proprietario cadastrado com sucesso!";

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

        public String deleteProprietario(int codpro)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbProprietario SET status = 0 WHERE codProprietario = " + codpro, conexao.con);
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

        public Proprietario SelectProprietarioCod(Proprietario pro, int codpro)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbProprietario WHERE codProprietario = " + codpro, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pro.nomeProprietario = dr["nomeProprietario"] + "";
                pro.sobrenomeProprietario = dr["sobrenomeProprietario"] + "";
                pro.rgProprietario = dr["rgProprietario"] + "";
                pro.cpfProprietario = dr["cpfProprietario"] + ""; 
            }
            return pro;
        }

        public Proprietario SelectTelefone(Proprietario pro, int codpro)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbTelefoneProprietario WHERE codProprietario = " + codpro, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pro.telefoneProprietario = dr["numeroTelefoneProprietario"] + "";
            }
            return pro;
        }

        public Boolean SelectCPF(String cpf)
        {
            try
            {
                Conexao conexao = new Conexao();

                SqlCommand cmd = new SqlCommand("SELECT * FROM tbProprietario WHERE cpfProprietario = '" + cpf + "'", conexao.con);
                conexao.conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                String cpfM = "";
                if (dr.Read())
                {
                    cpfM = dr["cpfProprietario"] + "";
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

        public String editarProprietario(Proprietario pro, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbProprietario SET nomeProprietario='" + pro.nomeProprietario + "',sobrenomeProprietario='" + pro.sobrenomeProprietario + "',rgProprietario='" + pro.rgProprietario + "',cpfProprietario='" + pro.cpfProprietario + "' WHERE codProprietario=" + cod, conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    SqlCommand cmd2 = new SqlCommand(
                    "SELECT codProprietario FROM tbProprietario WHERE cpfProprietario LIKE '" + pro.cpfProprietario + "'", conexao.con);
                    conexao.conectar();

                    SqlDataReader dr = cmd2.ExecuteReader();
                    while (dr.Read())
                    {
                        pro.codProprietario = int.Parse(dr["codProprietario"] + "");
                    }
                    conexao.desconectar();
                    SqlCommand cmd3 = new SqlCommand(
                        "UPDATE tbTelefoneProprietario SET numeroTelefoneProprietario='" + pro.telefoneProprietario+ "' WHERE codTelefoneProprietario=" + cod, conexao.con);
                    conexao.conectar();
                    int j = cmd3.ExecuteNonQuery();
                    conexao.desconectar();
                    if (j > 0)
                    {
                        return "Proprietario editado com sucesso!";

                    }
                    else
                    {
                        return ""+j;
                    }
                
                }
                else
                {
                    return "Erro na edição!";
                }
            }
            catch (SqlException e)
            {
                return (e.ToString());
            }
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

        public DataTable pesquisaProprietario(String pesquisa, int cbCat)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (cbCat == 0)
            {
                cmd = new SqlCommand("SELECT codProprietario, nomeProprietario, rgProprietario, cpfProprietario FROM tbProprietario WHERE status = 1 AND tbProprietario.nomeProprietario LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 1)
            {
                cmd = new SqlCommand("SELECT codProprietario, nomeProprietario, rgProprietario, cpfProprietario FROM tbProprietario WHERE status = 1 AND tbProprietario.sobrenomeProprietario LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 2)
            {
                cmd = new SqlCommand("SELECT codProprietario, nomeProprietario, rgProprietario, cpfProprietario FROM tbProprietario WHERE status = 1 AND tbProprietario.rgProprietario LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 3)
            {
                cmd = new SqlCommand("SELECT codProprietario, nomeProprietario, rgProprietario, cpfProprietario FROM tbProprietario WHERE status = 1 AND tbProprietario.cpfProprietario LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 4)
            {
                cmd = new SqlCommand("SELECT codProprietario, nomeProprietario, rgProprietario, cpfProprietario FROM tbProprietario WHERE status = 1 AND tbProprietario.codApartamento LIKE '" + pesquisa + "%'", conexao.con);
            }
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
