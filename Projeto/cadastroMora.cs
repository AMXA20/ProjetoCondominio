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
    public partial class cadastroMora : Form
    {
        private List<Condominio> cnds = new List<Condominio>();
        private List<Apartamento> listApart = new List<Apartamento>();
        int linhaAtual = 0;
        public cadastroMora()
        {
            InitializeComponent();
        }

        private void cadastroMora_Load(object sender, EventArgs e)
        {
            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();

            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
            }

            cbCat.Items.Add("Nome");
            cbCat.Items.Add("Sobrenome");
            cbCat.Items.Add("RG");
            cbCat.Items.Add("CPF");
            cbCat.Items.Add("Apartamento");

            cbCat.Text = "Nome";
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.BackColor = Color.Red;
            }
            if (txtNome.Text != "")
            {
                txtNome.BackColor = Color.White;
            }
            if (txtSobrenome.Text == "")
            {
                txtSobrenome.BackColor = Color.Red;
            }
            if (txtSobrenome.Text != "")
            {
                txtSobrenome.BackColor = Color.White;
            }
            if (txtCPF.Text == "")
            {
                txtCPF.BackColor = Color.Red;
            }
            if (txtCPF.Text != "")
            {
                entity_Morador emor = new entity_Morador();
                if (emor.SelectCPF(txtCPF.Text) == true)
                {
                    txtCPF.BackColor = Color.Red;
                    MessageBox.Show("CPF já cadastrado!");
                }
                else
                txtCPF.BackColor = Color.White;
            }
            if (txtRG.Text == "")
            {
                txtRG.BackColor = Color.Red;
            }
            if (txtRG.Text != "")
            {
                txtRG.BackColor = Color.White;
            }
            if (txtTel.Text == "")
            {
                txtTel.BackColor = Color.Red;
            }
            if (txtTel.Text != "")
            {
                txtTel.BackColor = Color.White;
            }

            if (txtNome.BackColor == Color.White && txtCPF.BackColor == Color.White && txtRG.BackColor == Color.White && txtSobrenome.BackColor == Color.White)
            {
                Morador mor = new Morador();
                mor.nomeMorador = txtNome.Text;
                mor.sobrenomeMorador = txtSobrenome.Text;
                mor.rgMorador = txtRG.Text;
                mor.cpfMorador = txtCPF.Text;
                mor.telefoneMorador = txtTel.Text;
                mor.codApartamento = Convert.ToInt32(listApart[cbApartamento.SelectedIndex].codApartamento + "");
                entity_Morador emor = new entity_Morador();
                MessageBox.Show(emor.cadastrarMorador(mor));
                dataGridViewMorador.DataSource = emor.SelectMorador(Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
                txtNome.Text = "";
                txtRG.Text = "";
                txtSobrenome.Text = "";
                txtCPF.Text = "";
                txtTel.Text = "";
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";

            txtNome.Enabled = false;
            txtRG.Enabled = false;
            txtCPF.Enabled = false;
            dataGridViewMorador.Enabled = false;
            btnCadastrar.Enabled = false;
            btnEditar.Enabled = false;
            btnDelete.Enabled = false;
            txtSobrenome.Enabled = false;
            txtTel.Enabled = false;

            cbApartamento.Items.Clear();
            cbCond.Items.Clear();

            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();

            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
            }
        }

        private void dataGridViewMorador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String codigo = dataGridViewMorador[0, linhaAtual].Value.ToString();
            int codMor = int.Parse(codigo);
            entity_Morador emor = new entity_Morador();
            MessageBox.Show(emor.deleteMorador(codMor));

            dataGridViewMorador.DataSource = emor.SelectMorador(Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String codigo = dataGridViewMorador[0, linhaAtual].Value.ToString();
            int codMor = int.Parse(codigo);

            editarMorador editMor = new editarMorador(codMor, Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
            editMor.ShowDialog();

            entity_Morador emor = new entity_Morador();
            dataGridViewMorador.DataSource = emor.SelectMorador(Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            entity_Morador emor = new entity_Morador();
            dataGridViewMorador.DataSource = emor.pesquisaMorador(txtPesquisa.Text, cbCat.SelectedIndex, Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCat.Enabled == true){
            entity_Morador emor = new entity_Morador();
            dataGridViewMorador.DataSource = emor.pesquisaMorador(txtPesquisa.Text, cbCat.SelectedIndex, Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
            }
        }

        private void cbCond_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbApartamento.Items.Clear();
            
            entity_Morador emor = new entity_Morador();
            dataGridViewMorador.DataSource = emor.SelectMorador(Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));

            txtNome.Enabled = true;
            txtRG.Enabled = true;
            txtCPF.Enabled = true;
            dataGridViewMorador.Enabled = true;
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = true;
            btnDelete.Enabled = true;
            txtSobrenome.Enabled = true;
            txtTel.Enabled = true;
            cbApartamento.Enabled = true;
            cbCat.Enabled = true;
            txtPesquisa.Enabled = true;

            listApart = emor.buscarTodos(Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
            for (int i = 0; i < listApart.Count; i++)
            {
                cbApartamento.Items.Add("Número: " + listApart[i].numApartamento + " - Bloco: " + listApart[i].numApartamento + " - Andar: " + listApart[i].numApartamento);
            }
        }
    }
}
