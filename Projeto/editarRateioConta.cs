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
    public partial class editarRateioConta : Form
    {
        int cod = 0;
        private List<Condominio> cnds = new List<Condominio>();
        private List<Apartamento> listApart = new List<Apartamento>();
        private List<TipoConta> tcs = new List<TipoConta>();
        public editarRateioConta(int codConta)
        {
            InitializeComponent();
            cod = codConta;
            RateioConta rc = new RateioConta();
            entity_Conta e_c = new entity_Conta();
            e_c.SelecContaCod(rc, codConta);
            txtQtdParc.Text = Convert.ToString(rc.quantidadeParcela);
            txtValor.Text = Convert.ToString(rc.valorTotal);

           
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
            cbMes.Text = rc.mesPrimeiraParcela;
            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();

            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
            }
            cbCond.Text = rc.nomeCondominio;

            entity_TipoConta e_tc = new entity_TipoConta();
            tcs = e_tc.buscarTodos();

            for (int i = 0; i < tcs.Count; i++)
            {
                cbTp.Items.Add(tcs[i].descricaoTipoConta);
            }
            cbTp.Text = rc.descricaoTipoConta;
        }

        private void editarRateioConta_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

                entity_Conta ec = new entity_Conta();
                MessageBox.Show("" + ec.editarConta(rc, cod));
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void txtQtdParc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == (char)44) || txtValor.Text.Contains(",") && e.KeyChar == (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
