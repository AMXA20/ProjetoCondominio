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
    public partial class Multar : Form
    {

        private List<Condominio> cnds = new List<Condominio>();
        private List<Apartamento> listApart = new List<Apartamento>();
        private List<TipoMulta> tms = new List<TipoMulta>();
        int linhaAtual = 0;
      
        public Multar()
        {
            InitializeComponent();
        }
     

        private void Multar_Load(object sender, EventArgs e)
        {
            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();

            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
            }
            
            cbCat.Items.Add("Data de Envio");
            cbCat.Items.Add("Data de Vencimento");
            cbCat.Items.Add("Tipo de Multa");
            cbCat.Items.Add("Apartamento");
            cbCat.Text = "Data de Envio";
            
            entity_Apartamento e_apart = new entity_Apartamento();

            entity_TipoMulta e_tp = new entity_TipoMulta();
       
            entity_Multa e_multa = new entity_Multa();
            dgvMulta.DataSource = e_multa.SelecMulta();
          
            tms = e_tp.buscarTodos();

            for (int i = 0; i < tms.Count; i++)
            {
                cbTp.Items.Add(tms[i].nomeTipoMulta);
            }


        }

        private void dgvMulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void cbCond_SelectedIndexChanged(object sender, EventArgs e)
        {
            entity_Morador emor = new entity_Morador();
            cbApartamento.Enabled = true;
            listApart = emor.buscarTodos(Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
            for (int i = 0; i < listApart.Count; i++)
            {
                cbApartamento.Items.Add("Número: " + listApart[i].numApartamento + " - Bloco: " + listApart[i].numApartamento + " - Andar: " + listApart[i].numApartamento);
            }
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
            if (cbApartamento.Text == "")
            {
                cbApartamento.BackColor = Color.Wheat;
            }
            if (cbApartamento.Text != "")
            {
                cbApartamento.BackColor = Color.White;
            }
            if (cbTp.Text == "")
            {
                cbTp.BackColor = Color.Wheat;
            }
            if (cbTp.Text != "")
            {
                cbTp.BackColor = Color.White;
            }

            if (cbCond.BackColor == Color.White && cbApartamento.BackColor == Color.White && cbTp.BackColor == Color.White)
            {
                    Multa m = new Multa();
                    m.codApartamento = Convert.ToInt32(listApart[cbApartamento.SelectedIndex].codApartamento + "");
                    m.codCondominio = Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + "");
                    m.codTipoMulta = Convert.ToInt32(tms[cbTp.SelectedIndex].codTipoMulta + "");
                    m.descricaoMulta = rtDesc.Text;
                    m.dataEnvio = dtEnvio.Text;
                    m.dataVencimento = dtVencimento.Text;
                    entity_Multa em = new entity_Multa();
                    MessageBox.Show(em.Multar(m));
                    dgvMulta.DataSource = em.SelecMulta();


                    cbCond.Items.Clear();
                    cbApartamento.Items.Clear();
                    cbTp.Items.Clear();
                    cbApartamento.Enabled = false;
                    rtDesc.Text = "";
                    txtPesquisa.Text = "";
                    entity_Condominio e_cnd = new entity_Condominio();
                    cnds = e_cnd.buscarTodos();

                    for (int i = 0; i < cnds.Count; i++)
                    {
                        cbCond.Items.Add(cnds[i].nomeCondominio);
                    }
                    entity_TipoMulta e_tp = new entity_TipoMulta();
                    tms = e_tp.buscarTodos();

                    for (int i = 0; i < tms.Count; i++)
                    {
                        cbTp.Items.Add(tms[i].nomeTipoMulta);
                    }
    
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String codigo = dgvMulta[0, linhaAtual].Value.ToString();
            int codMulta = int.Parse(codigo);
            entity_Multa etm = new entity_Multa();
            MessageBox.Show(etm.deleteMulta(codMulta));
            entity_Multa em = new entity_Multa();
            dgvMulta.DataSource = em.SelecMulta();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Multa m = new Multa();
            String codigo = dgvMulta[0, linhaAtual].Value.ToString();
            int codMulta = int.Parse(codigo);

            editarMultar editc = new editarMultar(codMulta);
            editc.ShowDialog();

            entity_Multa em = new entity_Multa();
            dgvMulta.DataSource = em.SelecMulta();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            cbCond.Items.Clear();
            cbApartamento.Items.Clear();
            cbTp.Items.Clear(); 
            cbApartamento.Enabled = false;
            rtDesc.Text = "";
            txtPesquisa.Text = "";
            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();

            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
            }
            entity_TipoMulta e_tp = new entity_TipoMulta();
            tms = e_tp.buscarTodos();

            for (int i = 0; i < tms.Count; i++)
            {
                cbTp.Items.Add(tms[i].nomeTipoMulta);
            }
        }
    }
}
