using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class RatearConta : Form
    {
        public RatearConta()
        {
            InitializeComponent();
        }
        int linhaAtual = 0;
        private List<Condominio> cnds = new List<Condominio>();
        private List<Apartamento> listApart = new List<Apartamento>();
        private List<TipoConta> tcs = new List<TipoConta>();
        private void RatearConta_Load(object sender, EventArgs e)
        {
            RateioConta rc = new RateioConta();
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");

            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();

            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
            }

            cbCat.Items.Add("Valor Total");
            cbCat.Items.Add("Quantidade de Parcela");
            cbCat.Items.Add("1ª Parcela");
            cbCat.Items.Add("Condominio");
            cbCat.Items.Add("Tipo de Conta");
            cbCat.Text = "Valor Total";
            
            entity_Apartamento e_apart = new entity_Apartamento();

            entity_TipoConta e_tc = new entity_TipoConta();

            entity_Conta e_conta = new entity_Conta();
            dgvConta.DataSource = e_conta.SelecConta();

            tcs = e_tc.buscarTodos();

            for (int i = 0; i < tcs.Count; i++)
            {
                cbTp.Items.Add(tcs[i].descricaoTipoConta);
            }

        }

        private void cbCond_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (cbCond.Text == "")
            {
                cbCond.BackColor = Color.Wheat;
            }
            if (cbCond.Text != "")
            {
                cbCond.BackColor = Color.White;
            }
 
            if (cbTp.Text == "")
            {
                cbTp.BackColor = Color.Wheat;
            }
            if (cbTp.Text != "")
            {
                cbTp.BackColor = Color.White;
            }
            if (cbMes.Text == "")
            {
                cbMes.BackColor = Color.Wheat;
            }
            if (cbMes.Text != "")
            {
                cbMes.BackColor = Color.White;
            }
            if (txtValor.Text == "")
            {
                txtValor.BackColor = Color.Wheat;
            }
            if (txtValor.Text != "")
            {
                txtValor.BackColor = Color.White;
            }
            if (txtQtdParc.Text == "")
            {
                txtQtdParc.BackColor = Color.Wheat;
            }
            if (txtQtdParc.Text != "")
            {
                txtQtdParc.BackColor = Color.White;
            }


            if (cbCond.BackColor == Color.White && cbTp.BackColor == Color.White && txtValor.BackColor == Color.White && cbMes.BackColor == Color.White && txtQtdParc.BackColor == Color.White)
            {
                RateioConta rc = new RateioConta();
                
                rc.codCondominio = Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + "");
                rc.codTipoConta = Convert.ToInt32(tcs[cbTp.SelectedIndex].codTipoConta + "");
                rc.valorTotal = txtValor.Text;
                rc.quantidadeParcela = Convert.ToInt32(txtQtdParc.Text);
                rc.mesPrimeiraParcela = cbMes.Text;
                MessageBox.Show(string.Format("{0:#.00}", Convert.ToDecimal(rc.valorTotal)));
                entity_Conta ec = new entity_Conta();
                MessageBox.Show(ec.Conta(rc));
                cbCond.Text = "";
                cbMes.Text = "Janeiro";
                txtQtdParc.Text = "";
                txtValor.Text = "";
                cbTp.Text = "";
                dgvConta.DataSource = ec.SelecConta();
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == (char)44) || txtValor.Text.Contains(",") && e.KeyChar == (char)44)
            {                
                    e.Handled = true;
            }
        }

        private void txtQtdParc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            String codigo = dgvConta[0, linhaAtual].Value.ToString();
            int codConta = int.Parse(codigo);
            entity_Conta ec = new entity_Conta();
            MessageBox.Show(ec.deleteConta(codConta));

            entity_Conta ect = new entity_Conta();
            dgvConta.DataSource = ect.SelecConta();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cbCat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            entity_Conta ec = new entity_Conta();
            dgvConta.DataSource = ec.pesquisaConta(txtPesquisa.Text, cbCat.SelectedIndex); ;
        }

        private void txtPesquisa_TextChanged(object sender, System.EventArgs e)
        {
            entity_Conta ec = new entity_Conta();
            dgvConta.DataSource = ec.pesquisaConta(txtPesquisa.Text, cbCat.SelectedIndex);
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            RateioConta rc = new RateioConta();
            String codigo = dgvConta[0, linhaAtual].Value.ToString();
            int codConta = int.Parse(codigo);

            editarRateioConta editrc = new editarRateioConta(codConta);
            editrc.ShowDialog();

            entity_Conta ec = new entity_Conta();
            dgvConta.DataSource = ec.SelecConta();
        }

        private void dgvConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

    }
}
