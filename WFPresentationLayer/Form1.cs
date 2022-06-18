using BusinessLogicalLayer;
using Entities;
using Shared;
using System.Text;

namespace WfPresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            StringValidator stringValidator = new StringValidator();
            erros.AppendLine(stringValidator.ValidateEmail(email));
            erros.AppendLine(stringValidator.ValidateSenha(senha));
            if (!string.IsNullOrWhiteSpace(erros.ToString()))
            {
                MessageBox.Show(erros.ToString());
            }
            else
            {
                Login login = new Login(email, senha);
                LoginBLL loginBLL = new LoginBLL();
                Response response = loginBLL.Logar(login);
                MessageBox.Show(response.Message);
            }
        }
    }
}