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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)

        {
            Usuario usuario = new Usuario();

            usuario.Nome = txtNomeCompleto.Text;
            usuario.Email = txtEmail.Text;
            usuario.possFilhos = rdbPossuiFilhos.Text;
            usuario.DddCelular = Convert.ToDouble(mtbDddCelular.Text);
            usuario.cpf = Convert.ToDouble(mkbCPF.Text);
            usuario.TipoTelefone = gbxTipoTelefone.Text;
            usuario.Codigo = Convert.ToInt32(mtbCodigo.Text);

            Usuario.ListaUsuarios.Add(usuario);


            if (txtNomeCompleto.Text == "" || txtEmail.Text == "" || mtbDddCelular.Text == "" || mkbCPF.Text == "" || mtbCodigo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                Usuario usuario1 = new Usuario();
                usuario.Nome = txtNomeCompleto.Text;
                usuario.Email = txtEmail.Text;
                usuario.possFilhos = rdbPossuiFilhos.Text;
                usuario.DddCelular = Convert.ToDouble(mtbDddCelular.Text);
                usuario.cpf = Convert.ToDouble(mkbCPF.Text);
                usuario.TipoTelefone = gbxTipoTelefone.Text;
                usuario.Codigo = Convert.ToInt32(mtbCodigo.Text);

                Usuario.ListaUsuarios.Add(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!");

                txtNomeCompleto.Text = "";
                txtEmail.Text = "";
                rdbPossuiFilhos.Text = "";
                mtbDddCelular.Text = "";
                mkbCPF.Text = "";
                gbxTipoTelefone.Text = "";
                mtbCodigo.Text = "";
            }

            if (rdbPossuiFilhos.Checked)
            {
                rdbPossuiFilhos.Text = "Sim";
            }
            else
            {
                rdbPossuiFilhos.Text = "Não";
            }
             
        }
    }
}
