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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListar.DataSource = Usuario.ListaUsuarios;
        }
    }
}
