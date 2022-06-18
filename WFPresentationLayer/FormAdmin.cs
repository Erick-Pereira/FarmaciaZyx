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
            
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario formCadastroCliente = new FormCadastroFuncionario();
            formCadastroCliente.ShowDialog();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
        }
    }
}
