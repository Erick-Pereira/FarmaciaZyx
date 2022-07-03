using BusinessLogicalLayer;
using Entities;
using Shared;
using System.Globalization;
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
        GeneroBLL generoBLL = new GeneroBLL();
        EnderecoBLL enderecoBLL = new EnderecoBLL();
        DateTimeValidator dateTimeValidator = new DateTimeValidator();
        Funcionario funcionario = new Funcionario();
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelUpdateSenha.Controls.Add(childForm);
            panelUpdateSenha.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FormUpdateFuncionario_Load(object sender, EventArgs e)
        {
            funcionario = (Funcionario)StaticItem.item;
            cmbTipoFuncionario.DataSource = tipoFuncionario.GetAll().Dados;
            cmbTipoFuncionario.DisplayMember = "Nome";
            cmbTipoFuncionario.ValueMember = "ID";
            cmbEstados.DataSource = estadoBLL.GetAll().Dados;
            cmbEstados.DisplayMember = "NomeEstado";
            cmbEstados.ValueMember = "ID";
            cmbGenero.DataSource = generoBLL.GetAll().Dados;
            cmbGenero.DisplayMember = "Nome";
            cmbGenero.ValueMember = "ID";
            txtNome.Text = funcionario.Nome;
            mtxtCpf.Text = funcionario.CPF;
            txtRg.Text = funcionario.RG;
            cmbGenero.SelectedValue = funcionario.GeneroId;
            cmbTipoFuncionario.SelectedValue = funcionario.TipoFuncionarioId;
            mtxtDataNascimento.Text = Convert.ToString(funcionario.DataNascimento, new CultureInfo("pt-br"));
            txtEmail.Text = funcionario.Email;
            mtxtTelefone.Text = funcionario.Telefone;
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
            update.EnderecoId = funcionario.EnderecoId;
            Endereco enderecoUpdate = new Endereco();
            Bairro bairroUpdate = new Bairro();
            Cidade cidadeUpdate = new Cidade();
            update.Nome = txtNome.Text;
            update.CPF = mtxtCpf.Text.Replace(",", ".");
            update.RG = txtRg.Text.Replace(",", ".");
            update.GeneroId = Convert.ToInt32(cmbGenero.SelectedValue);
            update.TipoFuncionarioId = Convert.ToInt32(cmbTipoFuncionario.SelectedValue);
            DateTime dataNascimento = new DateTime();
            string erro = dateTimeValidator.VerifyIfIsNull(mtxtDataNascimento.Text);
            if (string.IsNullOrWhiteSpace(erro))
            {
                dataNascimento = Convert.ToDateTime(mtxtDataNascimento.Text,new CultureInfo("pt-br"));
                update.DataNascimento = dataNascimento;
                //DateTime dataNascimento = DateTime.Parse(mtxtDataDeNascimento.Text, new CultureInfo("pt-br"));
                update.Email = txtEmail.Text;
                update.Telefone = mtxtTelefone.Text;
                //string senha = txtSenha.Text;
                //string confirmarSenha = txtConfirmarSenha.Text;
                enderecoUpdate.CEP = mtxtCep.Text;
                enderecoUpdate.Rua = txtRua.Text.ToUpper();
                enderecoUpdate.NumeroCasa = mtxtNumero.Text;
                enderecoUpdate.Complemento = txtComplemento.Text.ToUpper();
                cidadeUpdate.EstadoId = Convert.ToInt32(cmbEstados.SelectedValue);
                cidadeUpdate.NomeCidade = txtCidade.Text.ToUpper();
                bairroUpdate.NomeBairro = txtBairro.Text.ToUpper();
                stringBuilder.AppendLine(stringValidator.ValidateCEP(enderecoUpdate.CEP));
                stringBuilder.AppendLine(validator.Validate(update).Message);
                FuncionarioComEndereco funcionarioComEnderecoUpdate = new FuncionarioComEndereco(update, enderecoUpdate, bairroUpdate, cidadeUpdate);
                string erros = stringBuilder.ToString().Trim();
                stringBuilder.Clear();
                if (string.IsNullOrWhiteSpace(erros))
                {
                    Response response = funcionarioBLL.UpdateFuncionarioComEndereco(funcionarioComEnderecoUpdate);
                    MessageBox.Show(response.Message);
                }
            }
            else
            {
                MessageBox.Show(erro);
            }

        }


        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            panelUpdateSenha.BringToFront();
            OpenChildForm(new FormUpdateSenha());
        }
    }
}