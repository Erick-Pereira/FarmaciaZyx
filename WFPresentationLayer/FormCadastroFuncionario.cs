using BusinessLogicalLayer;

namespace WFPresentationLayer
{
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            TipoFuncionarioBLL tipoFuncionario = new TipoFuncionarioBLL();
            cmbTipoFuncionario.DataSource = tipoFuncionario.GetAll().Dados;
            cmbTipoFuncionario.DisplayMember = "Nome";
            cmbTipoFuncionario.ValueMember = "ID";
            ((Control)this.tabEndereço).Enabled = false;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            ((Control)this.tabEndereço).Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = mtxtCpf.Text;
            //DateTime dataNascimento = DateTime.Parse(mtxtDataDeNascimento.Text, new CultureInfo("pt-br"));
            string email = txtEmail.Text;
            string telefone = mtxtTelefone.Text;
            //string nomeresponsavel = txtNomeResponsavel.Text;
            //Genero genero = (Genero)cmbGenero.SelectedIndex;
            string cep = mtxtCep.Text;
            string rua = txtRua.Text;
            string bairro = txtBairro.Text;
            string estado = txtEstado.Text;
            string cidade = txtCidade.Text;
            string complemento = txtComplemento.Text;
            string numero = mtxtNumero.Text;
            //string pontoReferencia = txtPontoDeReferencia.Text;
            //Endereco endereco = new Endereco(rua, bairro, cep, numero, cidade, estado);
            //endereco.Complemento = txtComplemento.Text;
            //endereco.PontoReferencia = txtPontoDeReferencia.Text;
            //Cliente cli = new Cliente(0, nome, cpf, dataNascimento, email, endereco, telefone, genero, nomeresponsavel, true);
            //ClienteValidator validator = new ClienteValidator();
            //Response response = validator.Validate(cli);
            //MessageBox.Show(response.Message);
        }


    }
}
