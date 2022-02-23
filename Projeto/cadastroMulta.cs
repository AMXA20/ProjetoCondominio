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
    public partial class cadastroMulta : Form
    {
        public cadastroMulta()
        {
            InitializeComponent();
        }
        private List<TipoMulta> tms = new List<TipoMulta>();
        int linhaAtual = 0;
        private void cadastroMulta_Load(object sender, EventArgs e)
        {
            entity_TipoMulta etm = new entity_TipoMulta();
            dgvMulta.DataSource = etm.SelectTipoMulta();
            cbPesquisa.Items.Add("Nome");
            cbPesquisa.Items.Add("Valor");
            cbPesquisa.Text = "Nome";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {      
            TipoMulta tm = new TipoMulta();
            tm.valorMulta = txtValor.Text;
            tm.nomeTipoMulta = txtNome1.Text;
            entity_TipoMulta etm = new entity_TipoMulta();
            MessageBox.Show(etm.cadastrarTipoMulta(tm));
            dgvMulta.DataSource = etm.SelectTipoMulta();
            txtNome1.Text = "";
            txtValor.Text = "";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            entity_TipoMulta em = new entity_TipoMulta();
            dgvMulta.DataSource = em.pesquisaTipoMulta(txtPesquisa.Text, cbPesquisa.SelectedIndex);
        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            entity_TipoMulta em = new entity_TipoMulta();
            dgvMulta.DataSource = em.pesquisaTipoMulta(txtPesquisa.Text, cbPesquisa.SelectedIndex);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == (char)44) || txtValor.Text.Contains(",") && e.KeyChar == (char)44)
            {
                e.Handled = true;
            }
        }

        private void dgvMulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String codigo = dgvMulta[0, linhaAtual].Value.ToString();
            int codTipoMulta = int.Parse(codigo);
            entity_TipoMulta etm = new entity_TipoMulta();
            MessageBox.Show(etm.deleteTipoMulta(codTipoMulta));
            entity_TipoMulta em = new entity_TipoMulta();
            dgvMulta.DataSource = em.SelectTipoMulta();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoMulta tm = new TipoMulta();
            String codigo = dgvMulta[0, linhaAtual].Value.ToString();
            int codTipoMulta = int.Parse(codigo);

            editarMulta editc = new editarMulta(codTipoMulta);
            editc.ShowDialog();

            entity_TipoMulta em = new entity_TipoMulta();
            dgvMulta.DataSource = em.SelectTipoMulta();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome1.Text = "";
            txtValor.Text = "";
            txtPesquisa.Text = "";
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
