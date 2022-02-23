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
    public partial class CadastroProprietario : Form
    {
        
        int linhaAtual = 0;
        entity_Proprietario ep = new entity_Proprietario();
        public CadastroProprietario()
        {
            InitializeComponent();
        }
        
        private void CadastroProprietario_Load(object sender, EventArgs e)
        {
            cbCat.Items.Add("Nome");
            cbCat.Items.Add("Sobrenome");
            cbCat.Items.Add("RG");
            cbCat.Items.Add("CPF");
            cbCat.Text = "Nome";
            dgvProprietario.DataSource = ep.SelectProprietario();
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
                entity_Proprietario epro = new entity_Proprietario();
                if (epro.SelectCPF(txtCPF.Text) == true)
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
                Proprietario pro = new Proprietario();
                pro.nomeProprietario = txtNome.Text;
                pro.sobrenomeProprietario = txtSobrenome.Text;
                pro.rgProprietario = txtRG.Text;
                pro.cpfProprietario = txtCPF.Text;
                pro.telefoneProprietario = txtTel.Text;
                
                entity_Proprietario epro = new entity_Proprietario();
                MessageBox.Show(epro.cadastroProprietario(pro));
                
                txtNome.Text = "";
                txtRG.Text = "";
                txtSobrenome.Text = "";
                txtCPF.Text = "";
                txtTel.Text = "";
                dgvProprietario.DataSource = ep.SelectProprietario();
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String codigo = dgvProprietario[0, linhaAtual].Value.ToString();
            int codpro = int.Parse(codigo);

            editarProprietario editPro = new editarProprietario(codpro);
            editPro.ShowDialog();

            entity_Proprietario emor = new entity_Proprietario();
            dgvProprietario.DataSource = emor.SelectProprietario();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String codigo = dgvProprietario[0, linhaAtual].Value.ToString();
            int codpro = int.Parse(codigo);
            entity_Proprietario epro = new entity_Proprietario();
            MessageBox.Show(epro.deleteProprietario(codpro));
            dgvProprietario.DataSource = ep.SelectProprietario();
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
            dgvProprietario.Enabled = false;
            btnCadastrar.Enabled = false;
            btnEditar.Enabled = false;
            btnDelete.Enabled = false;
            txtSobrenome.Enabled = false;
            txtTel.Enabled = false;
 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            entity_Proprietario epro = new entity_Proprietario();
            dgvProprietario.DataSource = epro.pesquisaProprietario(txtPesquisa.Text, cbCat.SelectedIndex);
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCat.Enabled == true)
            {
                entity_Proprietario epro = new entity_Proprietario();
                dgvProprietario.DataSource = epro.pesquisaProprietario(txtPesquisa.Text, cbCat.SelectedIndex);
            }
        }

        private void dgvProprietario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

       
        

        
    }
}
