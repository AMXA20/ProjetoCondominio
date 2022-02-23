using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Projeto
{
    class entity_Apartamento
    {
        public String cadastrarApartamento(Apartamento ap)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbApartamento(numeroApartamento, blocoApartamento, andarApartamento, statusApartamento, codCondominio,codProprietario, dataCadastro, status) " +
                    "values('" + ap.numApartamento + "','" + ap.blocoApartamento + "','" + ap.andarApartamento + "'," + ap.statusApartamento + "," + ap.codCondominio + "," + ap.codProprietario + ", getdate(), 1 )", conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Apartamento cadastrado com sucesso!";
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


        public String editarApartamento(Apartamento ap, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbApartamento SET numeroApartamento='" + ap.numApartamento + "',blocoApartamento='" + ap.blocoApartamento + "',andarApartamento='" + ap.andarApartamento + "',StatusApartamento='" + ap.statusApartamento + "',codCondominio='" + ap.codCondominio + "',codProprietario='" + ap.codProprietario + "' WHERE codApartamento=" + cod, conexao.con);
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

        public List<Apartamento> buscarTodos()
        {

            List<Apartamento> listApart = new List<Apartamento>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select codApartamento, numeroApartamento, blocoApartamento, andarApartamento, codCondominio from tbApartamento WHERE status = 1 " + c.con);
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

        public DataTable SelectApartamento()
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT codApartamento, nomeCondominio, numeroApartamento, blocoApartamento, andarApartamento, statusApartamento as 'Alugado',nomeProprietario FROM tbApartamento INNER JOIN tbCondominio ON tbApartamento.codCondominio = tbCondominio.codCondominio INNER JOIN tbProprietario ON tbApartamento.codProprietario = tbProprietario.codProprietario WHERE tbApartamento.status = 1 AND tbCondominio.status = 1 AND tbProprietario.status = 1", conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public Apartamento SelectApartamentoCod(Apartamento ap, int codAp)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tbApartamento WHERE codApartamento = " + codAp, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ap.numApartamento = int.Parse(dr["numeroApartamento"] + "");
                ap.blocoApartamento = dr["blocoApartamento"] + "";
                ap.andarApartamento = int.Parse(dr["andarApartamento"] + "");
                ap.statusApartamento = int.Parse(dr["statusApartamento"] + "");
                ap.codCondominio = int.Parse(dr["codCondominio"] + "");
                ap.codProprietario = int.Parse(dr["codProprietario"] + "");
            }
            return ap;
        }

       

        public String deleteApartamento(int codAp)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbApartamento SET status = 0 WHERE codApartamento = " + codAp, conexao.con);
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
    }
}
