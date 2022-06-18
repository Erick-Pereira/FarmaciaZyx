using BusinessLogicalLayer;
using Entities;
using Shared;

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
            string rg = "";
            int tipoFuncionarioId = cmbTipoFuncionario.SelectedIndex;
            //DateTime dataNascimento = DateTime.Parse(mtxtDataDeNascimento.Text, new CultureInfo("pt-br"));
            string email = txtEmail.Text;
            string telefone = mtxtTelefone.Text;
            int enderecoId = 0;
            string senha = "";
            //string nomeresponsavel = txtNomeResponsavel.Text;
            //Genero genero = (Genero)cmbGenero.SelectedIndex;
            string cep = mtxtCep.Text;
            string rua = txtRua.Text;
            string bairro = txtBairro.Text;
            string estado = txtEstado.Text;
            string cidade = txtCidade.Text;
            string numero = mtxtNumero.Text;
            Funcionario funcionario = new Funcionario(nome,cpf, rg, telefone,email, senha, enderecoId, tipoFuncionarioId);
            //string pontoReferencia = txtPontoDeReferencia.Text;
            //Endereco endereco = new Endereco(rua, bairro, cep, numero, cidade, estado);
            //endereco.Complemento = txtComplemento.Text;
            //endereco.PontoReferencia = txtPontoDeReferencia.Text;
            //Cliente cli = new Cliente(0, nome, cpf, dataNascimento, email, endereco, telefone, genero, nomeresponsavel, true);
            FuncionarioValidator validator = new FuncionarioValidator();
            Response response = validator.Validate(funcionario);
            MessageBox.Show(response.Message);
        }


    }
}
