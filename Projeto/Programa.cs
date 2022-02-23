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
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Multar multa= new Multar();
            multa.ShowDialog();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            Cadastros cad = new Cadastros();
            cad.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatórios rel = new Relatórios();
            rel.ShowDialog();
        }

        private void btnRateio_Click(object sender, EventArgs e)
        {
            RatearConta rc = new RatearConta();
            rc.ShowDialog();
        }

        private void btnCadastros_MouseHover(object sender, EventArgs e)
        {
            btnCadastros.SetBounds(29, 124, 150, 150);
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Visible = true;
        }

        private void btnCadastros_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(100,Color.Gray);
            label1.Visible = false;
            btnCadastros.SetBounds(29, 174, 150, 150);
            btnCadastros.Size = new Size(124, 39);
        }

     
    }
}
