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
    public partial class editarProprietario : Form
    {
        int cod = 0;
        public editarProprietario(int codPro)
        {
            InitializeComponent();
            cod = codPro;
            Proprietario pro = new Proprietario();
            entity_Proprietario epro = new entity_Proprietario();
            epro.SelectProprietarioCod(pro, codPro);
            txtNome.Text = pro.nomeProprietario + "";
            txtSobrenome.Text = pro.sobrenomeProprietario + "";
            txtCPF.Text = pro.cpfProprietario + "";
            txtRG.Text = pro.rgProprietario + "";
            epro.SelectTelefone(pro, codPro);
            txtTel.Text = pro.telefoneProprietario + "";
        }

        private void editarProprietario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Proprietario pro = new Proprietario();
            pro.nomeProprietario = txtNome.Text;
            pro.sobrenomeProprietario = txtSobrenome.Text;
            pro.rgProprietario = txtRG.Text;
            pro.cpfProprietario = txtCPF.Text;
            pro.telefoneProprietario = txtTel.Text;
            entity_Proprietario epro = new entity_Proprietario();
            MessageBox.Show("" + epro.editarProprietario(pro, cod));
            
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
