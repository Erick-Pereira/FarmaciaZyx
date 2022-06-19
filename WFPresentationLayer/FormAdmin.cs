﻿namespace WFPresentationLayer
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            formCadastroCliente.ShowDialog();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario formCadastroFuncionario = new FormCadastroFuncionario();
            formCadastroFuncionario.ShowDialog();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
        }
    }
}
