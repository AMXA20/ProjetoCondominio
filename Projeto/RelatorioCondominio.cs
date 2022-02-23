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
    public partial class RelatorioCondominio : Form
    {
        public RelatorioCondominio()
        {
            InitializeComponent();
            lblData.Text = Convert.ToString(DateTime.Now);
        }

        private void RelatorioCondominio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdCondominioDataSet.tbCondominio' table. You can move, or remove it, as needed.
            this.tbCondominioTableAdapter.Fill(this.bdCondominioDataSet.tbCondominio,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbCondominioTableAdapter.Fill(this.bdCondominioDataSet.tbCondominio, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
