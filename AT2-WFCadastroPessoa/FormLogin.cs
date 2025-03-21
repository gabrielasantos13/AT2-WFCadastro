using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            btnAcessar.Click += new EventHandler(btnAcessar_Click);

            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Bem-vindo!");
                FormCadastro formCadastro = new FormCadastro();
                formCadastro.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
    }
}
