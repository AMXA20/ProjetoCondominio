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
    public partial class editarMultar : Form
    {
        int cod = 0;
        private List<Condominio> cnds = new List<Condominio>();
        private List<Apartamento> listApart = new List<Apartamento>();
        private List<TipoMulta> tms = new List<TipoMulta>();
        public editarMultar(int codMulta)
        {
            InitializeComponent();

            cod = codMulta;
            Multa m = new Multa();
            entity_Multa em = new entity_Multa();
            em.SelecMultaCod(m, codMulta);

            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();
            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
                if (cnds[i].codCondominio == m.codCondominio)
                    cbCond.Text = Convert.ToString(cnds[i].nomeCondominio);
            }
            cbCond.Text = m.nomeCondominio;
            
            
            entity_TipoMulta e_tp = new entity_TipoMulta();
            tms = e_tp.buscarTodos();
            for (int i = 0; i < tms.Count; i++)
            {
                cbTp.Items.Add(tms[i].nomeTipoMulta);
                if (tms[i].codTipoMulta == m.codTipoMulta)
                    cbTp.Text = Convert.ToString(tms[i].nomeTipoMulta);
            }
            cbTp.Text = m.descricaoTipoMulta;

            entity_Morador emor = new entity_Morador();
            cbApartamento.Enabled = true;
            listApart = emor.buscarTodos(Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + ""));
            for (int i = 0; i < listApart.Count; i++)
            {
                cbApartamento.Items.Add("Número: " + listApart[i].numApartamento + " - Bloco: " + listApart[i].numApartamento + " - Andar: " + listApart[i].numApartamento);
            }
           
            cbApartamento.Text = "Número: " + m.numeroApartamento + " - Bloco: " + m.blocoApartamento + " - Andar: " + m.andarApartamento;

            rtDesc.Text = m.descricaoMulta;
            dtEnvio.Text = Convert.ToString(m.dataEnvio);
            dtVencimento.Text = Convert.ToString(m.dataVencimento);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
            if (rtDesc.Text == "")
            {
                rtDesc.BackColor = Color.Wheat;
            }
            if (rtDesc.Text != "")
            {
                rtDesc.BackColor = Color.White;
            }

            if (cbCond.BackColor == Color.White && cbApartamento.BackColor == Color.White && cbTp.BackColor == Color.White && rtDesc.BackColor == Color.White)
            {
                Multa m = new Multa();
                m.codApartamento = Convert.ToInt32(listApart[cbApartamento.SelectedIndex].codApartamento + "");
                m.codCondominio = Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + "");
                m.codTipoMulta = Convert.ToInt32(tms[cbTp.SelectedIndex].codTipoMulta + "");
                m.dataEnvio = dtEnvio.Text;
                m.dataVencimento = dtVencimento.Text;
                m.descricaoMulta = rtDesc.Text;

                entity_Multa em = new entity_Multa();
                MessageBox.Show(""+em.editarMulta(m,cod));
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void cbCond_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarMultar_Load(object sender, EventArgs e)
        {

        }

        private void rtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbApartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
