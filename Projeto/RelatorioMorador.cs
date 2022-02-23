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
    public partial class RelatorioMorador : Form
    {
        public RelatorioMorador()
        {
            InitializeComponent();
            lblData.Text = Convert.ToString(DateTime.Now);
        }

        private void RelatorioMorador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdCondominioDataSet.tbMorador' table. You can move, or remove it, as needed.
            this.tbMoradorTableAdapter.Fill(this.bdCondominioDataSet.tbMorador, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbMoradorTableAdapter.Fill(this.bdCondominioDataSet.tbMorador,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
