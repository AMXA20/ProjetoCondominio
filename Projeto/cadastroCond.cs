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
    public partial class cadastroCond : Form
    {
        int linhaAtual = 0;
        bool[] focus = new bool[8];
        
        public cadastroCond()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                focus[0] = true;
                
                
               
            }
            if (txtNome.Text != "")
            {
                focus[0] = false;

                
            }
            if (textBox1.Text == "")
            {
                focus[1] = true;

                
                
            }
            if (textBox1.Text != "")
            {
                focus[1] = false;

                
            }
            if (txtBairro.Text == "")
            {
                focus[2] = true;

                
                
            }
            if (txtBairro.Text != "")
            {
                focus[2] = false;

                
            }
            if (txtCidade.Text == "")
            {
                focus[3] = true;

                
                
            }
            if (txtCidade.Text != "")
            {
                focus[3] = false;

                
            }
            if (txtEstado.Text == "")
            {
                focus[4] = true;

                
                
            }
            if (txtEstado.Text != "")
            {
                focus[4] = false;

                
            }
            if (txtSindico.Text == "")
            {
                focus[5] = true;

                
                
            }
            if (txtSindico.Text != "")
            {
                focus[5] = false;

                
            }
            if (txtValor.Text == "")
            {
                focus[6] = true;

                
                
            }
            if (txtValor.Text != "")
            {
                focus[6] = false;

                
            }
            if (txtLogradouro.Text == "")
            {
                focus[7] = true;

                
                
            }
            if (txtLogradouro.Text != "")
            {
                focus[7] = false;

                
            }
            this.Refresh();

            if (txtNome.BorderStyle == BorderStyle.Fixed3D
                 && txtCidade.Text != "" && txtEstado.Text != "" && txtLogradouro.Text != "" 
                && txtSindico.Text != "" && txtValor.Text != "")
            {
                Condominio cond = new Condominio();
                cond.nomeCondominio = txtNome.Text;
                cond.numeroCondominio = Convert.ToInt32(textBox1.Text);
                cond.bairroCondominio = txtBairro.Text;
                cond.cidadeCondominio = txtCidade.Text;
                cond.estadoCondominio = txtEstado.Text;
                cond.logradouroCondominio = txtLogradouro.Text;
                cond.sindicoCondominio = txtSindico.Text;
                cond.valorCondominio = Convert.ToDouble(txtValor.Text);
                entity_Condominio etc = new entity_Condominio();
                MessageBox.Show(etc.cadastrarCondominio(cond));
                txtNome.Text = "";
                
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtEstado.Text = "";
                txtLogradouro.Text = "";
                textBox1.Text = "";
                txtSindico.Text = "";
                txtValor.Text = "";
                entity_Condominio ec = new entity_Condominio();
                dataGridViewCondominio.DataSource = ec.SelectCondominio();
            }
            else
            {
                MessageBox.Show("Campos Inválidos");
            }
        }

        private void cadastroCond_Load(object sender, EventArgs e)
        {
            entity_Condominio ec = new entity_Condominio();
            dataGridViewCondominio.DataSource = ec.SelectCondominio();

            cbCat.Items.Add("Nome");          
            cbCat.Items.Add("Bairro");
            cbCat.Items.Add("Cidade");
            cbCat.Items.Add("Valor");
            cbCat.Items.Add("Estado");
            cbCat.Items.Add("Logradouro");
            cbCat.Items.Add("numero");
            cbCat.Items.Add("Sindico");

            cbCat.Text = "Nome" ;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Condominio cond = new Condominio();
            String codigo = dataGridViewCondominio[0, linhaAtual].Value.ToString();
            int codCond = int.Parse(codigo);

            editarCondominio editc = new editarCondominio(codCond);
            editc.ShowDialog();

            entity_Condominio ec = new entity_Condominio();
            dataGridViewCondominio.DataSource = ec.SelectCondominio();
        }
        private void dataGridViewCondominio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            textBox1.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtLogradouro.Text = "";
            txtSindico.Text = "";
            txtValor.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String codigo = dataGridViewCondominio[0, linhaAtual].Value.ToString();
            int codCond = int.Parse(codigo);
            entity_Condominio eap = new entity_Condominio();
            MessageBox.Show(eap.deleteCondominio(codCond));

            entity_Condominio ec = new entity_Condominio();
            dataGridViewCondominio.DataSource = ec.SelectCondominio();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == (char)44) || txtValor.Text.Contains(",") && e.KeyChar == (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtLogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            entity_Condominio ec = new entity_Condominio();
            dataGridViewCondominio.DataSource = ec.pesquisaCondominio(txtPesquisa.Text, cbCat.SelectedIndex);
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            entity_Condominio ec = new entity_Condominio();
            dataGridViewCondominio.DataSource = ec.pesquisaCondominio(txtPesquisa.Text, cbCat.SelectedIndex);
        }

        private void cadastroCond_Paint(object sender, PaintEventArgs e)
        {

            if (focus[0] == true)
            {
                txtNome.BorderStyle = BorderStyle.Fixed3D;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txtNome.Location.X - variance + 2, txtNome.Location.Y - variance + 2, txtNome.Width + variance - 2, txtNome.Height + variance - 2));
            }
            else
            {
                
            }
                if (focus[1] == true)
                {
                    textBox1.BorderStyle = BorderStyle.Fixed3D;
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(textBox1.Location.X - variance + 2, textBox1.Location.Y - variance + 2, textBox1.Width + variance - 2, textBox1.Height + variance - 2));
                }
                else
                {
                    
                }
                if (focus[2] == true)
                {
                    txtBairro.BorderStyle = BorderStyle.Fixed3D;
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(txtBairro.Location.X - variance + 2, txtBairro.Location.Y - variance + 2, txtBairro.Width + variance - 2, txtBairro.Height + variance - 2));
                }
                else
                {
                    
                }
                if (focus[3] == true)
                {
                    txtCidade.BorderStyle = BorderStyle.Fixed3D;
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(txtCidade.Location.X - variance + 2, txtCidade.Location.Y + 2 - variance, txtCidade.Width + variance - 2, txtCidade.Height + variance - 2));
                }
                else
                {
                    
                }
                if (focus[4] == true)
                {
                    txtEstado.BorderStyle = BorderStyle.Fixed3D;
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(txtEstado.Location.X - variance + 2, txtEstado.Location.Y - variance + 2, txtEstado.Width + variance - 2, txtEstado.Height + variance - 2));
                }
                else
                {
                   
                }
                if (focus[5] == true)
                {
                    txtSindico.BorderStyle = BorderStyle.Fixed3D;
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(txtSindico.Location.X - variance + 2, txtSindico.Location.Y - variance + 2, txtSindico.Width + variance - 2, txtSindico.Height + variance - 2));
                }
                else
                {
                    
                }
                if (focus[6] == true)
                {
                    txtValor.BorderStyle = BorderStyle.Fixed3D;
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(txtValor.Location.X - variance + 2, txtValor.Location.Y - variance + 2, txtValor.Width + variance - 2, txtValor.Height + variance - 2));
                }
                else
                {
                    
                }
                if (focus[7] == true)
                {
                    txtLogradouro.BorderStyle = BorderStyle.Fixed3D;
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(txtLogradouro.Location.X - variance+2, txtLogradouro.Location.Y+2 - variance, txtLogradouro.Width + variance-2, txtLogradouro.Height + variance-2 ));
                }
                else
                {
                    
                }
            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
           
            
        }

        

     
    }

