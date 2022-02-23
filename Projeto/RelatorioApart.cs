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
    public partial class RelatorioApart : Form
    {
        public RelatorioApart()
        {
            InitializeComponent();
            lblData.Text = Convert.ToString(DateTime.Now);
        }

        private void RelatorioApart_Load(object sender, EventArgs e)
        {   
            this.tbApartamentoTableAdapter.Fill(this.bdCondominioDataSet.tbApartamento, textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbApartamentoTableAdapter.Fill(this.bdCondominioDataSet.tbApartamento, textBox1.Text);
            this.reportViewer1.RefreshReport();
        }


    }
}
