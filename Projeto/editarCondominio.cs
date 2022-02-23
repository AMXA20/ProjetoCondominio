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
    public partial class editarCondominio : Form
    {
        int cod = 0;
        public editarCondominio(int codCond)
        {
            InitializeComponent();
            cod = codCond;
            Condominio cond = new Condominio();
            entity_Condominio ec = new entity_Condominio();
            ec.SelectCondominioCod(cond, codCond);
            txtNum.Text = Convert.ToString(cond.numeroCondominio);
            txtNome.Text = cond.nomeCondominio;
            txtBairro.Text = cond.bairroCondominio;
            txtCidade.Text = cond.cidadeCondominio;
            txtEstado.Text = cond.estadoCondominio;
            txtValor.Text = "" + cond.valorCondominio;
            txtLogradouro.Text = "" + cond.logradouroCondominio;
            txtSindico.Text = cond.sindicoCondominio;
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Condominio cond = new Condominio();
            cond.nomeCondominio = txtNome.Text;
            cond.numeroCondominio = Convert.ToInt32(txtNum.Text);
            cond.bairroCondominio = txtBairro.Text;
            cond.cidadeCondominio = txtCidade.Text;
            cond.estadoCondominio = txtEstado.Text;
            cond.valorCondominio = double.Parse(txtValor.Text);
            cond.logradouroCondominio = txtLogradouro.Text;
            cond.sindicoCondominio = txtSindico.Text;
            

            entity_Condominio ec = new entity_Condominio();
            MessageBox.Show("" + ec.editarCondominio(cond, cod));
            this.Close();
        }

        private void editarCondominio_Load(object sender, EventArgs e)
        {

        }
    }
}
