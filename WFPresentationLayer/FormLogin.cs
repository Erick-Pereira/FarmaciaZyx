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
            SingleResponse<Funcionario> singleResponse = loginBLL.Logar(login);
            if (!string.IsNullOrWhiteSpace(singleResponse.Message))
            {
                MessageBox.Show(singleResponse.Message);
            }
            else
            {
                MessageBox.Show(singleResponse.Message);
                if (singleResponse.HasSuccess)
                {
                    this.Hide();
                    if (singleResponse.Item.TipoFuncionarioId == 1)
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