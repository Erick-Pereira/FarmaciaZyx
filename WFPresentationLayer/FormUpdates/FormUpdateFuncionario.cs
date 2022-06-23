using BusinessLogicalLayer;
using Entities;
using Shared;
using System.Text;

namespace WFPresentationLayer
{
    public partial class FormUpdateFuncionario : Form
    {
        public FormUpdateFuncionario()
        {
            InitializeComponent();
        }
        FuncionarioValidator validator = new FuncionarioValidator();
        StringValidator stringValidator = new StringValidator();
        TipoFuncionarioBLL tipoFuncionario = new TipoFuncionarioBLL();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        EstadoBLL estadoBLL = new EstadoBLL();
        BairroBLL bairroBLL = new BairroBLL();
        CidadeBLL cidadeBLL = new CidadeBLL();
        EnderecoBLL enderecoBLL = new EnderecoBLL();
        Funcionario funcionario = new Funcionario();
        private void FormUpdateFuncionario_Load(object sender, EventArgs e)
        {
            funcionario = (Funcionario)StaticItem.item;
            cmbTipoFuncionario.DataSource = tipoFuncionario.GetAll().Dados;
            cmbTipoFuncionario.DisplayMember = "Nome";
            cmbTipoFuncionario.ValueMember = "ID";
            cmbEstados.DataSource = estadoBLL.GetAll().Dados;
            cmbEstados.DisplayMember = "NomeEstado";
            cmbEstados.ValueMember = "ID";
            txtNome.Text = funcionario.Nome;
            mtxtCpf.Text = funcionario.CPF;
            mtxtRg.Text = funcionario.RG;
            cmbTipoFuncionario.SelectedValue = funcionario.TipoFuncionarioId;
            //DateTime dataNascimento = DateTime.Parse(mtxtDataDeNascimento.Text, new CultureInfo("pt-br"));
            txtEmail.Text = funcionario.Email;
            mtxtTelefone.Text = funcionario.Telefone;
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            //Genero genero = (Genero)cmbGenero.SelectedIndex;
            SingleResponse<Endereco> singleResponseEndereco = enderecoBLL.GetByID(funcionario.EnderecoId);
            SingleResponse<Bairro> singleResponseBairro = bairroBLL.GetByID(singleResponseEndereco.Item.BairroID);
            SingleResponse<Cidade> singleResponseCidade = cidadeBLL.GetByID(singleResponseBairro.Item.CidadeId);
            mtxtCep.Text = singleResponseEndereco.Item.CEP;
            txtRua.Text = singleResponseEndereco.Item.Rua;
            txtBairro.Text = singleResponseBairro.Item.NomeBairro;
            cmbEstados.SelectedValue = singleResponseCidade.Item.EstadoId;
            txtCidade.Text = singleResponseCidade.Item.NomeCidade;
            mtxtNumero.Text = singleResponseEndereco.Item.NumeroCasa;
            txtComplemento.Text = singleResponseEndereco.Item.Complemento;
            if (funcionario.ID == FuncionarioLogin.id)
            {
                cmbTipoFuncionario.Enabled = false;
            }
        }
        private void btnUpdateFuncionario_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Funcionario update = new Funcionario();
            update.ID = funcionario.ID;
            Endereco enderecoUpdate = new Endereco();
            Bairro bairroUpdate = new Bairro();
            Cidade cidadeUpdate = new Cidade();
            update.Nome = txtNome.Text;
            update.CPF = mtxtCpf.Text.Replace(",", ".");
            update.RG = mtxtRg.Text.Replace(",", ".");
            update.TipoFuncionarioId = Convert.ToInt32(cmbTipoFuncionario.SelectedValue);
            //DateTime dataNascimento = DateTime.Parse(mtxtDataDeNascimento.Text, new CultureInfo("pt-br"));
            update.Email = txtEmail.Text;
            update.Telefone = mtxtTelefone.Text; ;
            //string senha = txtSenha.Text;
            //string confirmarSenha = txtConfirmarSenha.Text;
            //Genero genero = (Genero)cmbGenero.SelectedIndex;
            enderecoUpdate.CEP = mtxtCep.Text;
            enderecoUpdate.Rua = txtRua.Text.ToUpper();
            enderecoUpdate.NumeroCasa = mtxtNumero.Text;
            enderecoUpdate.Complemento = txtComplemento.Text.ToUpper();
            cidadeUpdate.EstadoId = Convert.ToInt32(cmbEstados.SelectedValue);
            cidadeUpdate.NomeCidade = txtCidade.Text.ToUpper();
            bairroUpdate.NomeBairro = txtBairro.Text.ToUpper();
            stringBuilder.AppendLine(stringValidator.ValidateCEP(enderecoUpdate.CEP));
            //stringBuilder.AppendLine(stringValidator.ValidateSenha(senha));
            //stringBuilder.AppendLine(stringValidator.ValidateIfSenha1EqualsToSenha2(senha, confirmarSenha));
            stringBuilder.AppendLine(validator.Validate(update).Message);
           
            FuncionarioComEndereco funcionarioComEnderecoUpdate = new FuncionarioComEndereco(update, enderecoUpdate, bairroUpdate, cidadeUpdate, update.TipoFuncionarioId);
            string erros = stringBuilder.ToString().Trim();

            if (string.IsNullOrWhiteSpace(erros))
            {
                Response response = funcionarioBLL.Update(funcionarioComEnderecoUpdate);
                MessageBox.Show(response.Message);
            }
            else
            {
                MessageBox.Show(erros);
            }
        }


        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }
    }
}

//update.CPF = update.CPF.Replace(",", ".");
//    update.RG = update.RG.Replace(",", ".");


