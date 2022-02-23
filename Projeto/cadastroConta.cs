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
    public partial class cadastroConta : Form
    {
        private List<TipoConta> tcs = new List<TipoConta>();
        int linhaAtual = 0;
        entity_TipoConta etm = new entity_TipoConta();
        public cadastroConta()
        {
            InitializeComponent();
        }

        
        private void cadastroConta_Load(object sender, EventArgs e)
        {
            entity_TipoConta etc = new entity_TipoConta();
            
            dgvConta.DataSource = etc.SelectTipoConta();
            DataGridViewColumn coluna = dgvConta.Columns[2];
            coluna.Width = 189;
            dgvConta.DataSource = etc.SelectTipoConta();
            cbPesquisa.Items.Add("Tipo");
            cbPesquisa.Text = "Tipo";
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                Color cor = new Color();
                txtTipo.BackColor = cor = Color.FromArgb(247, 231, 156);
                
            }
            if (txtTipo.Text != "")
            {
                txtTipo.BackColor = Color.White;
            }


            if (txtTipo.BackColor == Color.White)
            {
                TipoConta tc = new TipoConta();
                tc.descricaoTipoConta = txtTipo.Text;
                entity_TipoConta etc = new entity_TipoConta();
                MessageBox.Show(etc.cadastrarTipoConta(tc));

                dgvConta.DataSource = etc.SelectTipoConta();
                txtTipo.Text = "";
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void dgvConta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            entity_TipoConta em = new entity_TipoConta();
            dgvConta.DataSource = em.pesquisaTipoConta(txtPesquisa.Text, cbPesquisa.SelectedIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String codigo = dgvConta[0, linhaAtual].Value.ToString();
            int codTipoConta = int.Parse(codigo);
            
            MessageBox.Show(etm.deleteTipoConta(codTipoConta));
            dgvConta.DataSource = etm.SelectTipoConta();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTipo.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoConta tc = new TipoConta();
            String codigo = dgvConta[0, linhaAtual].Value.ToString();
            int codTipoConta = int.Parse(codigo);

            editarConta editc = new editarConta(codTipoConta);
            editc.ShowDialog();

            entity_TipoConta em = new entity_TipoConta();
            dgvConta.DataSource = em.SelectTipoConta();
        }
    }
}
