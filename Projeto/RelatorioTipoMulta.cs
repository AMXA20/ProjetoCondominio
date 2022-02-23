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
    public partial class RelatorioTipoMulta : Form
    {
        public RelatorioTipoMulta()
        {
            InitializeComponent();
            lblData.Text = Convert.ToString(DateTime.Now);
        }

        private void RelatorioTipoMulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdCondominioDataSet.tbTipoMulta' table. You can move, or remove it, as needed.
            this.tbTipoMultaTableAdapter.Fill(this.bdCondominioDataSet.tbTipoMulta);

            this.reportViewer1.RefreshReport();
        }
    }
}
