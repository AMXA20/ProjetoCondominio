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
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void btnCondominio_Click(object sender, EventArgs e)
        {
            cadastroCond cond = new cadastroCond();
            cond.ShowDialog();
        }

        private void btnApartamento_Click(object sender, EventArgs e)
        {
            cadastroApart apart = new cadastroApart();
            apart.ShowDialog();
        }

        private void btnMorador_Click(object sender, EventArgs e)
        {
            cadastroMora cadMora = new cadastroMora();
            cadMora.ShowDialog();
        }

        private void btnProprietario_Click(object sender, EventArgs e)
        {
            CadastroProprietario cadPro = new CadastroProprietario();
            cadPro.ShowDialog();
        }

        private void btnMulta_Click(object sender, EventArgs e)
        {
            cadastroMulta cadMulta = new cadastroMulta();
            cadMulta.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroConta cadConta = new cadastroConta();
            cadConta.ShowDialog();
        }
    }
}
