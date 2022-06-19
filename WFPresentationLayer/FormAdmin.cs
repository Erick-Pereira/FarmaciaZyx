namespace WFPresentationLayer
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
