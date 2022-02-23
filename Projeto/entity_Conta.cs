using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Projeto
{
    class entity_Conta
    {
        public String Conta(RateioConta rc)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand crcd = new SqlCommand(
                    "INSERT INTO tbContaRateio(valorTotal, quantidadeParcela, mesPrimeiraParcela, codCondominio, codTipoConta, dataCadastro, status) " +
                    "values( " + rc.valorTotal.Replace(",",".") +" , "+ rc.quantidadeParcela + ",'" + rc.mesPrimeiraParcela + "'," + rc.codCondominio + "," + rc.codTipoConta + ", getdate(), 1 )", conexao.con);

                conexao.conectar();
                int i = crcd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Ratiado!";
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
        public DataTable SelecConta()
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT tbContaRateio.codContaRateio as 'Código', valorTotal as 'Valor Total', quantidadeParcela as 'Quantidade de Parcelas', mesPrimeiraParcela as '1ª Parcela', descricaoTipoConta as 'Tipo de Conta', nomeCondominio as 'Nome do Condominio' , valorTotal / quantidadeParcela as 'parcelado' FROM tbContaRateio INNER JOIN tbTipoConta ON tbContaRateio.codTipoConta = tbTipoConta.codTipoConta  INNER JOIN tbCondominio ON tbContaRateio.codCondominio = tbCondominio.codCondominio  WHERE tbContaRateio.status = 1", conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public RateioConta SelecContaCod(RateioConta rc, int codConta)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand(
                "SELECT tbContaRateio.codContaRateio, valorTotal, quantidadeParcela, mesPrimeiraParcela, descricaoTipoConta, nomeCondominio FROM tbContaRateio INNER JOIN tbTipoConta ON tbContaRateio.codTipoConta = tbTipoConta.codTipoConta  INNER JOIN tbCondominio ON tbContaRateio.codCondominio = tbCondominio.codCondominio  WHERE codContaRateio = " + codConta, conexao.con);
            conexao.conectar();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rc.mesPrimeiraParcela = dr["mesPrimeiraParcela"] + "";
                rc.valorTotal = dr["valorTotal"] + "";
                rc.quantidadeParcela = int.Parse(dr["quantidadeParcela"] + "");
                rc.descricaoTipoConta = dr["descricaoTipoConta"] + "";
                rc.nomeCondominio = dr["nomeCondominio"] + "";
               
            }
            return rc;
        }

        public String editarConta(RateioConta rc, int cod)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbContaRateio SET valorTotal='" + rc.valorTotal.Replace(",",".") + "', quantidadeParcela='" + rc.quantidadeParcela + "', mesPrimeiraParcela='" + rc.mesPrimeiraParcela + "', codTipoConta='" + rc.codTipoConta + "', codCondominio='" + rc.codCondominio + "' WHERE codContaRateio=" + cod, conexao.con);
                conexao.conectar();
                int i = cmd.ExecuteNonQuery();
                conexao.desconectar();
                if (i > 0)
                {
                    return "Conta editada com sucesso!";
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

        public String deleteConta(int codConta)
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbContaRateio SET status = 0 WHERE codContaRateio=" + codConta, conexao.con);
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

        public List<RateioConta> buscarTodos()
        {

            List<RateioConta> rcs = new List<RateioConta>();

            try
            {
                Conexao c = new Conexao();
                c.conectar();
                SqlCommand cmd = new SqlCommand("Select * from tbContaRateio WHERE status = 1", c.con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    RateioConta rc = new RateioConta();
                    rc.quantidadeParcela = int.Parse(sdr["quantidadeParcela"] + "");
                    rc.mesPrimeiraParcela = sdr["mesPrimeiraParcela"] + "";
                    rc.valorTotal = sdr["dataVencimento"] + "";
                    rc.codTipoConta = int.Parse(sdr["codTipoConta"] + "");
                    rc.codCondominio = int.Parse(sdr["codCondominio"] + "");
                    rcs.Add(rc);
                }
                c.desconectar();
            }
            catch (Exception e)
            {
            }

            return rcs;
        }

        public DataTable pesquisaConta(String pesquisa, int cbCat)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            if (cbCat == 0)
            {
                cmd = new SqlCommand("SELECT tbContaRateio.codContaRateio as 'Código', valorTotal as 'Valor Total', quantidadeParcela as 'Quantidade de Parcelas', mesPrimeiraParcela as '1ª Parcela', descricaoTipoConta as 'Tipo de Conta', nomeCondominio as 'Nome do Condominio' , valorTotal / quantidadeParcela as 'parcelado' FROM tbContaRateio INNER JOIN tbTipoConta ON tbContaRateio.codTipoConta = tbTipoConta.codTipoConta  INNER JOIN tbCondominio ON tbContaRateio.codCondominio = tbCondominio.codCondominio  WHERE tbContaRateio.status = 1 AND tbContaRateio.valorTotal LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 1)
            {
                cmd = new SqlCommand("SELECT tbContaRateio.codContaRateio as 'Código', valorTotal as 'Valor Total', quantidadeParcela as 'Quantidade de Parcelas', mesPrimeiraParcela as '1ª Parcela', descricaoTipoConta as 'Tipo de Conta', nomeCondominio as 'Nome do Condominio' , valorTotal / quantidadeParcela as 'parcelado' FROM tbContaRateio INNER JOIN tbTipoConta ON tbContaRateio.codTipoConta = tbTipoConta.codTipoConta  INNER JOIN tbCondominio ON tbContaRateio.codCondominio = tbCondominio.codCondominio  WHERE tbContaRateio.status = 1 AND tbContaRateio.quantidadeParcela LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 2)
            {
                cmd = new SqlCommand("SELECT tbContaRateio.codContaRateio as 'Código', valorTotal as 'Valor Total', quantidadeParcela as 'Quantidade de Parcelas', mesPrimeiraParcela as '1ª Parcela', descricaoTipoConta as 'Tipo de Conta', nomeCondominio as 'Nome do Condominio' , valorTotal / quantidadeParcela as 'parcelado' FROM tbContaRateio INNER JOIN tbTipoConta ON tbContaRateio.codTipoConta = tbTipoConta.codTipoConta  INNER JOIN tbCondominio ON tbContaRateio.codCondominio = tbCondominio.codCondominio  WHERE tbContaRateio.status = 1  AND tbContaRateio.mesPrimeiraParcela LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 3)
            {
                cmd = new SqlCommand("SELECT tbContaRateio.codContaRateio as 'Código', valorTotal as 'Valor Total', quantidadeParcela as 'Quantidade de Parcelas', mesPrimeiraParcela as '1ª Parcela', descricaoTipoConta as 'Tipo de Conta', nomeCondominio as 'Nome do Condominio' , valorTotal / quantidadeParcela as 'parcelado' FROM tbContaRateio INNER JOIN tbTipoConta ON tbContaRateio.codTipoConta = tbTipoConta.codTipoConta  INNER JOIN tbCondominio ON tbContaRateio.codCondominio = tbCondominio.codCondominio  WHERE tbContaRateio.status = 1  AND tbCondominio.nomeCondominio LIKE '" + pesquisa + "%'", conexao.con);
            }
            else if (cbCat == 4)
            {
                cmd = new SqlCommand("SELECT tbContaRateio.codContaRateio as 'Código', valorTotal as 'Valor Total', quantidadeParcela as 'Quantidade de Parcelas', mesPrimeiraParcela as '1ª Parcela', descricaoTipoConta as 'Tipo de Conta', nomeCondominio as 'Nome do Condominio' , valorTotal / quantidadeParcela as 'parcelado' FROM tbContaRateio INNER JOIN tbTipoConta ON tbContaRateio.codTipoConta = tbTipoConta.codTipoConta  INNER JOIN tbCondominio ON tbContaRateio.codCondominio = tbCondominio.codCondominio  WHERE tbContaRateio.status = 1  AND tbTipoConta.descricaoTipoConta LIKE '" + pesquisa + "%'", conexao.con);
            }
            conexao.conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
