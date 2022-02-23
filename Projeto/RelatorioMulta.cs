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
    public partial class RelatorioMulta : Form
    {
        public RelatorioMulta()
        {
            InitializeComponent();
            lblData.Text = Convert.ToString(DateTime.Now);
        }

        private void RelatorioMulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdCondominioDataSet.tbMulta' table. You can move, or remove it, as needed.
            this.tbMultaTableAdapter.Fill(this.bdCondominioDataSet.tbMulta);

            this.reportViewer1.RefreshReport();
        }
    }
}
