using BusinessLogicalLayer;
using Entities;
using Shared;
using System.Text;
using System.Text.RegularExpressions;

namespace WFPresentationLayer
{
    public partial class FormCadastroFuncionario : Form
    {

        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }
        FuncionarioValidator validator = new FuncionarioValidator();
        StringValidator stringValidator = new StringValidator();
        TipoFuncionarioBLL tipoFuncionario = new TipoFuncionarioBLL();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        EstadoBLL estadoBLL = new EstadoBLL();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string nome = txtNome.Text;
            string cpf = mtxtCpf.Text;
            string rg = mtxtRg.Text;
            int tipoFuncionarioId = Convert.ToInt32(cmbTipoFuncionario.SelectedValue);
            //DateTime dataNascimento = DateTime.Parse(mtxtDataDeNascimento.Text, new CultureInfo("pt-br"));
            string email = txtEmail.Text;
            string telefone = mtxtTelefone.Text; ;
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;
            //Genero genero = (Genero)cmbGenero.SelectedIndex;
            string cep = mtxtCep.Text;
            string rua = txtRua.Text.ToUpper();
            string bairro = txtBairro.Text.ToUpper();
            int estado = Convert.ToInt32(cmbEstados.SelectedValue);
            string cidade = txtCidade.Text.ToUpper();
            string numero = mtxtNumero.Text;
            string complemento = txtComplemento.Text.ToUpper();
            cpf = cpf.Replace(",", ".");
            rg = rg.Replace(",", ".");
            stringBuilder.AppendLine(stringValidator.ValidateCEP(cep));
            stringBuilder.AppendLine(stringValidator.ValidateSenha(senha));
            stringBuilder.AppendLine(stringValidator.ValidateIfSenha1EqualsToSenha2(senha, confirmarSenha));
            Funcionario funcionario = new Funcionario(nome, cpf, rg, telefone, email, senha, tipoFuncionarioId);
            stringBuilder.AppendLine(validator.Validate(funcionario).Message);
            Endereco endereco = new Endereco(cep, numero, rua, complemento);
            Bairro bairro1 = new Bairro(bairro);
            Cidade cidade1 = new Cidade(cidade, estado);
            FuncionarioComEndereco funcionarioComEndereco = new FuncionarioComEndereco(funcionario, endereco, bairro1, cidade1, tipoFuncionarioId);
            string erros = stringBuilder.ToString().Trim();
            if (string.IsNullOrWhiteSpace(erros))
            {
                Response response = funcionarioBLL.Insert(funcionarioComEndereco);
                MessageBox.Show(response.Message);
                if (response.HasSuccess)
                {
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    mtxtRg.Text = "";
                    cmbTipoFuncionario.SelectedIndex = 1;
                    //DateTime dataNascimento = DateTime.Parse(mtxtDataDeNascimento.Text, new CultureInfo("pt-br"));
                    txtEmail.Text = "";
                    mtxtTelefone.Text = "";
                    txtSenha.Text = "";
                    txtConfirmarSenha.Text = "";
                    //Genero genero = (Genero)cmbGenero.SelectedIndex;
                    mtxtCep.Text = "";
                    txtRua.Text = "";
                    txtBairro.Text = "";
                    cmbEstados.SelectedIndex = 1;
                    txtCidade.Text = "";
                    mtxtNumero.Text = "";
                    txtComplemento.Text = "";
                }
            }
            else
            {
                MessageBox.Show(erros);
            }
        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            cmbTipoFuncionario.DataSource = tipoFuncionario.GetAll().Dados;
            cmbTipoFuncionario.DisplayMember = "Nome";
            cmbTipoFuncionario.ValueMember = "ID";
            cmbEstados.DataSource = estadoBLL.GetAll().Dados;
            cmbEstados.DisplayMember = "NomeEstado";
            cmbEstados.ValueMember = "ID";
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
