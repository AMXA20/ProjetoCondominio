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
    public partial class RelatorioProprietario : Form
    {
        public RelatorioProprietario()
        {
            InitializeComponent();
            lblData.Text = Convert.ToString(DateTime.Now);
        }

        private void RelatorioProprietario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdCondominioDataSet.tbProprietario' table. You can move, or remove it, as needed.
            this.tbProprietarioTableAdapter.Fill(this.bdCondominioDataSet.tbProprietario);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbProprietarioTableAdapter.Fill(this.bdCondominioDataSet.tbProprietario);

            this.reportViewer1.RefreshReport();
        }
    }
}
