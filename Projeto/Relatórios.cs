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
    public partial class Relatórios : Form
    {
        public Relatórios()
        {
            InitializeComponent();
        }

        private void btnApartamento_Click(object sender, EventArgs e)
        {
            RelatorioApart ra = new RelatorioApart();
            ra.ShowDialog();
        }

        private void Relatórios_Load(object sender, EventArgs e)
        {
            cbEscolha.Enabled = false;
        }

        private void rbCad_CheckedChanged(object sender, EventArgs e)
        {
            cbEscolha.Enabled = true;
            cbEscolha.Items.Clear();
            cbEscolha.Text = "Condominio";
            cbEscolha.Items.Add("Condominio");
            cbEscolha.Items.Add("Apartamento");
            cbEscolha.Items.Add("Morador");
            cbEscolha.Items.Add("Proprietario");
            cbEscolha.Items.Add("Tipo de Multa"); 
        }

        private void rbMovimentação_CheckedChanged(object sender, EventArgs e)
        {
            cbEscolha.Enabled = true;
            cbEscolha.Items.Clear();
            cbEscolha.Text = "Multas";
            cbEscolha.Items.Add("Multas");
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (cbEscolha.Text == "Condominio")
            {
                RelatorioCondominio rc = new RelatorioCondominio();
                rc.ShowDialog();
            }
            else if (cbEscolha.Text == "Apartamento")
            {
                RelatorioApart ra = new RelatorioApart();
                ra.ShowDialog();
            }
            else if (cbEscolha.Text == "Morador")
            {
                RelatorioMorador rm = new RelatorioMorador();
                rm.ShowDialog();
            }
            else if (cbEscolha.Text == "Proprietario")
            {
                RelatorioProprietario rp = new RelatorioProprietario();
                rp.ShowDialog();
            }
            else if (cbEscolha.Text == "Tipo de Multa")
            {
                RelatorioTipoMulta rtp = new RelatorioTipoMulta();
                rtp.ShowDialog();
            }
            else if (cbEscolha.Text == "Multas")
            {
                RelatorioMulta rm = new RelatorioMulta();
                rm.ShowDialog();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
