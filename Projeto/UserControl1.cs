using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnSimNao_Click(object sender, EventArgs e)
        {
            if (label1.Text == String.Empty || label1.Text == "nao")
            {
                label1.Text = "Sim";
            }
            else
            {
                label1.Text = "Não";
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
