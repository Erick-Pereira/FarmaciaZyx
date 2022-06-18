using BusinessLogicalLayer;
using Entities;
using Shared;
using System.Text;
using WFPresentationLayer;

namespace WfPresentationLayer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            Login login = new Login(email, senha);
            LoginBLL loginBLL = new LoginBLL();
            string erros = loginBLL.Validate(email, senha);
            if (!string.IsNullOrWhiteSpace(erros.ToString()))
            {
                MessageBox.Show(erros.ToString());
            }
            else
            {
                SingleResponse<Funcionario> response = loginBLL.Logar(login);
                MessageBox.Show(response.Message);
                if (response.HasSuccess)
                {
                    this.Hide();
                    if (response.Item.TipoFuncionarioId == 1)
                    {
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}