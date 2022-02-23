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
    public partial class editarConta : Form
    {
        int cod = 0;
        public editarConta(int codTipoConta)
        {
            InitializeComponent();
            cod = codTipoConta;
            TipoConta tc = new TipoConta();
            entity_TipoConta etp = new entity_TipoConta();
            etp.SelectTipoContaCod(tc, codTipoConta);
            txtTipo.Text = tc.descricaoTipoConta;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                Color cor = new Color();
                txtTipo.BackColor = cor = Color.FromArgb(141, 0, 21);
                txtTipo.ForeColor = Color.White;
            }
            if (txtTipo.Text != "")
            {
                txtTipo.BackColor = Color.White;
            }

            if (txtTipo.BackColor == Color.White)
            {
                TipoConta tc = new TipoConta();
                tc.descricaoTipoConta = txtTipo.Text;
                entity_TipoConta ec = new entity_TipoConta();
                MessageBox.Show("" + ec.editarTipoConta(tc, cod));
                this.Close();
            }
            else
            {
                MessageBox.Show("Campo Inválidos");
            }
        }

        private void editarConta_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
