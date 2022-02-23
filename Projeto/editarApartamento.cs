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
    public partial class editarApartamento : Form
    {
        private List<Condominio> cnds = new List<Condominio>();
        private List<Proprietario> pros = new List<Proprietario>();
        int cod = 0;
        public editarApartamento(int codAp)
        {
            InitializeComponent();
            cod = codAp;

            Apartamento ap = new Apartamento();
            
            entity_Apartamento eap = new entity_Apartamento();
            eap.SelectApartamentoCod(ap, codAp);
            txtNum.Text = ap.numApartamento + "";
            txtBloco.Text = ap.blocoApartamento;
            txtAndar.Text = ap.andarApartamento + "";
            if (ap.statusApartamento == 0)
            {
                rbAlugadoN.Checked = true;
            }
            else
            {
                cbProprietario.Visible = true;
                lblProprietario.Visible = true;
                rbAlugadoS.Checked = true;

            }
            entity_Condominio e_cnd = new entity_Condominio();
            cnds = e_cnd.buscarTodos();
            for (int i = 0; i < cnds.Count; i++)
            {
                cbCond.Items.Add(cnds[i].nomeCondominio);
                if (cnds[i].codCondominio == ap.codCondominio)
                    cbCond.Text = cnds[i].nomeCondominio;
            }
            entity_Proprietario e_pro = new entity_Proprietario();
            pros = e_pro.buscarTodos();
            for (int i = 0; i < pros.Count; i++)
            {
                cbProprietario.Items.Add(pros[i].nomeProprietario);
                if (pros[i].codProprietario == ap.codProprietario)
                    cbProprietario.Text = pros[i].nomeProprietario;
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarApartamento_Load(object sender, EventArgs e)
        {
            
        
        }

        

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (rbAlugadoN.Checked == true)
            {
                Apartamento ap = new Apartamento();
                ap.numApartamento = Int32.Parse(txtNum.Text);
                ap.blocoApartamento = txtBloco.Text;
                ap.andarApartamento = Int32.Parse(txtAndar.Text);
                ap.statusApartamento = 0;
                ap.codCondominio = Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + "");
                ap.codProprietario = 0;
                entity_Apartamento eap = new entity_Apartamento();
                MessageBox.Show(eap.editarApartamento(ap, cod));
                txtNum.Text = "";
                txtBloco.Text = "";
                txtAndar.Text = "";
                this.Close();
            }
            else if (rbAlugadoS.Checked == true)
            {
                Apartamento ap = new Apartamento();
                ap.numApartamento = Int32.Parse(txtNum.Text);
                ap.blocoApartamento = txtBloco.Text;
                ap.andarApartamento = Int32.Parse(txtAndar.Text);
                ap.statusApartamento = 1;
                ap.codCondominio = Convert.ToInt32(cnds[cbCond.SelectedIndex].codCondominio + "");
                ap.codProprietario = Convert.ToInt32(pros[cbCond.SelectedIndex].codProprietario + "");
                entity_Apartamento eap = new entity_Apartamento();
                MessageBox.Show(eap.editarApartamento(ap, cod));

                txtNum.Text = "";
                txtBloco.Text = "";
                txtAndar.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione se está alugado ou não!");
            }

        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAndar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void rbAlugadoN_DragOver(object sender, DragEventArgs e)
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
                cbProprietario.Text = pros[pros.Count - 1].nomeProprietario;

            }
            else if (result == System.Windows.Forms.DialogResult.Yes)
            {
                
                cbProprietario.Visible = true;
                lblProprietario.Visible = true;
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
