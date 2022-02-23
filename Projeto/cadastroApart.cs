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
    public partial class cadastroApart : Form
    {
        private List<Condominio> cnds = new List<Condominio>();
        private List<Proprietario> pros = new List<Proprietario>();
        int linhaAtual = 0;
        public cadastroApart()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.BackColor = Color.Wheat;
            }
            if (txtNum.Text != "")
            {
                txtNum.BackColor = Color.White;
            }
            if (txtBloco.Text == "")
            {
                txtBloco.BackColor = Color.Wheat;
            }
            if (txtBloco.Text != "")
            {
                txtBloco.BackColor = Color.White;
            }
            if (txtAndar.Text == "")
            {
                txtAndar.BackColor = Color.Wheat;
            }
            if (txtAndar.Text != "")
            {
                txtAndar.BackColor = Color.White;
            }

            if (txtNum.BackColor == Color.White && txtBloco.BackColor == Color.White && txtAndar.BackColor == Color.White)
            {
                if (rbAlugadoN.Checked == true)
                {
                    Apartamento ap = new Apartamento();
                    ap.numApartamento = Int32.Parse(txtNum.Text);
                    ap.blocoApartamento = txtBloco.Text;
                    ap.andarApartamento = Int32.Parse(txtAndar.Text);
                    ap.statusApartamento = 0;
                    ap.codCondominio = Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + "");
                    
                    ap.codProprietario = 1;
                    entity_Apartamento eap = new entity_Apartamento();
                    MessageBox.Show(eap.cadastrarApartamento(ap));
                    dataGridViewApartamento.DataSource = eap.SelectApartamento();
                    txtNum.Text = "";
                    txtBloco.Text = "";
                    txtAndar.Text = "";
                    
                }
                else if (rbAlugadoS.Checked == true)
                {
                    
                    Apartamento ap = new Apartamento();
                    ap.numApartamento = Int32.Parse(txtNum.Text);
                    ap.blocoApartamento = txtBloco.Text;
                    ap.andarApartamento = Int32.Parse(txtAndar.Text);
                    ap.statusApartamento = 1;
                    ap.codCondominio = Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + "");
                    ap.codProprietario = Convert.ToInt32(pros[cbProprietario.SelectedIndex].codProprietario + "");
                    entity_Apartamento eap = new entity_Apartamento();
                    MessageBox.Show(eap.cadastrarApartamento(ap));
                    dataGridViewApartamento.DataSource = eap.SelectApartamento();
                    txtNum.Text = "";
                    txtBloco.Text = "";
                    txtAndar.Text = "";
                }
                else
                {
                    MessageBox.Show("Selecione se está alugado ou não!");
                }
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtBloco.Text = "";
            txtAndar.Text = "";
            rbAlugadoN.Checked = false;
            rbAlugadoS.Checked = false;
        }

        private void cadastroApart_Load(object sender, EventArgs e)
        {
            entity_Apartamento eap = new entity_Apartamento();
            dataGridViewApartamento.DataSource = eap.SelectApartamento();
            entity_Condominio e_cnd = new entity_Condominio();
          
           
            cnds = e_cnd.buscarTodos();
           
            cbProprietario.Visible = false;
            lblProprietario.Visible = false;
            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
            }
            cbCond.Text = "Selecione";
            entity_Proprietario e_pro = new entity_Proprietario();
            pros = e_pro.buscarTodos();
            for (int i = 0; i < pros.Count; i++)
            {
                cbProprietario.Items.Add(pros[i].nomeProprietario);
            }
            
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String codigo = dataGridViewApartamento[0, linhaAtual].Value.ToString();
            int codAp = int.Parse(codigo);
            entity_Apartamento eap = new entity_Apartamento();
            MessageBox.Show(eap.deleteApartamento(codAp));
            dataGridViewApartamento.DataSource = eap.SelectApartamento();
        }

        private void dataGridViewApartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String codigo = dataGridViewApartamento[0, linhaAtual].Value.ToString();
            int codAp = int.Parse(codigo);

            editarApartamento editap = new editarApartamento(codAp);
            editap.ShowDialog();

            entity_Apartamento eap = new entity_Apartamento();
            dataGridViewApartamento.DataSource = eap.SelectApartamento();

        }

        private void cbCond_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbAlugadoS_MouseClick(object sender, MouseEventArgs e)
        {
            CadastroProprietario cap = new CadastroProprietario();

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string message = "Cadastrar Proprietário Existente?";
            string caption = "Cadastrar Proprietário";
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                
                MessageBoxButtons button = MessageBoxButtons.OK;
                string messag = "Cadastre um novo Proprietário";
                string captio = "Cadastrar Proprietário";
                DialogResult resul;
                resul = MessageBox.Show(messag, captio, button);

                    cbProprietario.Items.Clear();
                    cbProprietario.Visible = true;
                    lblProprietario.Visible = true;
                    cap.ShowDialog();
                    entity_Proprietario e_pro = new entity_Proprietario();
                    pros = e_pro.buscarTodos();
                    for (int i = 0; i < pros.Count; i++)
                    {
                        cbProprietario.Items.Add(pros[i].nomeProprietario);
                       
                    }
                    cbProprietario.Text = pros[pros.Count-1].nomeProprietario;
                
            }
            else if (result == System.Windows.Forms.DialogResult.Yes)
            {
                cbProprietario.Text = pros[0].nomeProprietario;
                cbProprietario.Visible = true;
                lblProprietario.Visible = true;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioApart ra = new RelatorioApart();
            ra.ShowDialog();
        }

        private void txtAndar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void rbAlugadoN_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Aviso: se o apartamento não for alugado, o proprietário do apartamento será a administradora do condominio", "Apartamento não alugado",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cbProprietario.Visible = false;
            lblProprietario.Visible = false;
        }

     
    }
}
