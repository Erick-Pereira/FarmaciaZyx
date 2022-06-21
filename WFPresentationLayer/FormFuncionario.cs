using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            formCadastroCliente.ShowDialog();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
        }

        private void btnRegistrarFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor formCadastroFornecedor = new FormCadastroFornecedor();
            formCadastroFornecedor.ShowDialog();
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            FormRegistroEntrada formRegistroEntrada = new FormRegistroEntrada();
            formRegistroEntrada.ShowDialog();
        }

        private void btnRegistrarSaida_Click(object sender, EventArgs e)
        {
            FormRegistroSaida formRegistroSaida = new FormRegistroSaida();
            formRegistroSaida.ShowDialog();
        }
    }
}
