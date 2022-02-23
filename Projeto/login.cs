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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "adm" && txtPass.Text == "123456")
            {
                Programa p = new Programa();
                this.Hide();
                p.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("User ou Pass inválidos!");
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }
    }
}
