using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AT2_WFCadastro
{
    public partial class FormCadastrar : Form
    {

        public FormCadastrar()
        {
            InitializeComponent();
        }

       public void erro()
        {
            MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }   
        public void sucesso()
        {
            MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnCadastrar_Click(object sender, EventArgs e)
        {

          
            Produto produto = new Produto();

            produto.nome = txtNomeProduto.Text;
            produto.descricao = txtDescricao.Text;
            produto.codigo = Convert.ToInt32(mkbCodigo.Text);
            produto.status = gpbStatus.Text;
            produto.dataCadastro = dtpDataCadastro.Value;
            produto.Ativo = rdbAtivo.Text;
            produto.Inativo = rdbInativo.Text;

            Produto.ListaProdutos.Add(produto);

            MessageBox.Show("Produto Cadastrado com Sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            

            txtNomeProduto.Clear();
            txtDescricao.Clear();
            mkbCodigo.Clear();
            gpbStatus.ResetText();

             

            
          
        }
       

      
        
    }
}

