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
    
    public partial class editarMulta : Form
    {
        int cod = 0;
        public editarMulta(int codTipoMulta)
        {
            InitializeComponent();

            cod = codTipoMulta;
            TipoMulta tm = new TipoMulta();
            entity_TipoMulta em = new entity_TipoMulta();
            em.SelectTipoMultaCod(tm, codTipoMulta);
            txtNome.Text = tm.nomeTipoMulta;
            txtValor.Text = "" + tm.valorMulta;
           
        }

        private void editarMulta_Load(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TipoMulta tm = new TipoMulta();
            tm.nomeTipoMulta = txtNome.Text;
            tm.valorMulta = txtValor.Text;
            entity_TipoMulta em = new entity_TipoMulta();
            MessageBox.Show("" + em.editarTipoMulta(tm, cod));
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == (char)44) || txtValor.Text.Contains(",") && e.KeyChar == (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
