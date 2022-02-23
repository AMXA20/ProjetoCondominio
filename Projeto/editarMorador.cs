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
    public partial class editarMorador : Form
    {
        private List<Apartamento> listApart = new List<Apartamento>();
        int cod = 0;
        public editarMorador(int codMor, int codCond)
        {
            InitializeComponent();
            cod = codMor;
            Morador mor = new Morador();
            
            entity_Morador emor = new entity_Morador();
            emor.SelectMoradorCod(mor, codMor);
            txtNome.Text = mor.nomeMorador + "";
            txtSobrenome.Text = mor.sobrenomeMorador + "";
            txtCPF.Text = mor.cpfMorador + "";
            txtRG.Text = mor.rgMorador + "";
            emor.SelectTelefone(mor, codMor);
            txtTel.Text = mor.telefoneMorador + "";

            listApart = emor.buscarTodos(codCond);
            for (int i = 0; i < listApart.Count; i++)
            {
                cbApartamento.Items.Add("Número: " + listApart[i].numApartamento + " - Bloco: " + listApart[i].blocoApartamento + " - Andar: " + listApart[i].andarApartamento);
                if (listApart[i].codApartamento == mor.codApartamento)
                    cbApartamento.Text = "Número: " + listApart[i].numApartamento + " - Bloco: " + listApart[i].blocoApartamento + " - Andar: " + listApart[i].andarApartamento;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Morador mor = new Morador();
            mor.nomeMorador = txtNome.Text;
            mor.sobrenomeMorador = txtSobrenome.Text;
            mor.rgMorador = txtRG.Text;
            mor.cpfMorador = txtCPF.Text;
            mor.telefoneMorador = txtTel.Text;
            mor.codApartamento = Convert.ToInt32(listApart[cbApartamento.SelectedIndex].codApartamento + "");

            entity_Morador emor = new entity_Morador();
            MessageBox.Show("" + emor.editarMorador(mor, cod));
            this.Close();
        }

        private void editarMorador_Load(object sender, EventArgs e)
        {

        }

       
    }
}
