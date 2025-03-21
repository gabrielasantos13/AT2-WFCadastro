using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastro
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto produto = new Produto();
            {
               

                

                void FormListar_Load(object sender, EventArgs e)
                {
                    dgvListar.DataSource = Produto.ListaProdutos;
                }
                
            }
        }
    }
}
